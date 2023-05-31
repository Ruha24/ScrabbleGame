using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Scrabble.View;
using Scrabble.Model;
using Scrabble.Controller;
using Scrabble.Model.Game;

namespace Scrabble
{
    public partial class DesktopWindow : Window, IView
    {
        Game game;
        List<Button> RackTileButtons;
        private int ThisPlayer;
        int PlayerNow;
        Button[,] BoardButtons = new Button[15, 15];
        char[,] BoardCharView = new char[15, 15];
        List<Button> ListSwapRackButton = new List<Button>();
        public DesktopWindow(int P, Game g)
        {
            InitializeComponent();
            ThisPlayer = P;
            game = g;
            game.Subs(this);
            GameState.GSInstance.OnStateChanged += OnStateChanged;
            this.Title = "Игрок " + (P + 1) + " - ЭрудитДекстоп";
            ListSwapRackButton = new List<Button>();
            RackTileButtons = new List<Button>();
            // добавляем кнопки на доску, на каждую клетку
            for (int i = 0; i < 15; ++i)
            {
                for (int j = 0; j < 15; ++j)
                {
                    Button b = new Button();
                    b.Click += Copier;
                    b.FontSize = 33;
                    BoardGrid.Children.Add(b);
                    b.Content = '\0';
                    b.Background = BoardTiles.DetermineColor(i, j);
                    BoardButtons[i, j] = b;
                }
            }
            // добавляем кнопки на фишки
            for (int i = 0; i < 7; ++i)
            {
                Button t = new Button();
                t.Click += Poster;
                t.FontSize = 33;
                HandGrid.Children.Add(t);
                t.Background = Brushes.Chocolate;
                t.Content = '\0';
                RackTileButtons.Add(t);
            }
            LogBoardWriter(Welcome.WelcomeText);
            LogBoardWriter("Игра началась...");
            LogBoardWriter("В этой игре " + GameState.GSInstance.NumOfPlayers + " игрока.");

            foreach (KeyValuePair<int, Tile> kvp in GameStartDraw.Drawn)
            {
                LogBoardWriter("Игрок " + (kvp.Key + 1) + " получил " + kvp.Value.TileChar + "!");
            }
            LogBoardWriter("Игрок " + (GameState.GSInstance.PlayerNow + 1) + " первый!");

            for (int i = 0; i < RackTileButtons.Count; ++i)
            {
                char c = GameState.GSInstance.ListOfPlayers[ThisPlayer].PlayingTiles[i].TileChar;
                RackTileButtons[i].Content = c;
                if (GameState.GSInstance.PlayerNow == ThisPlayer) { RackTileButtons[i].IsEnabled = true; EnableAll(); }

                else { RackTileButtons[i].IsEnabled = false; DisableAll(); }
            }
            StorageLbl.Content = '\0';
        }

        Button LastButton;

        // метод, перемещающий фишки
        private void Poster(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;
            if (LastButton == SwapButton)
            {
                ListSwapRackButton.Add(clickedButton);
                clickedButton.IsEnabled = false;
            }
            else
            {
                if (Convert.ToChar(StorageLbl.Content) == '\0' || LastButton == null)
                {
                    StorageLbl.Content = clickedButton.Content;
                    LastButton = clickedButton;
                    clickedButton.IsEnabled = false;
                }
                else
                {
                    LastButton.IsEnabled = true;
                    StorageLbl.Content = clickedButton.Content;
                    LastButton = clickedButton;
                    clickedButton.IsEnabled = false;
                }
            }


        }

        // метод, определяющий кнопку
        /* 
         * Если буква равна = `-` - выбираем новую
         * Запись хода
         */
        private void Copier(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;
            if (Convert.ToChar(clickedButton.Content) != '\0')
                return;
            clickedButton.Content = StorageLbl.Content;
            StorageLbl.Content = '\0';

            for (int i = 0; i < BoardButtons.GetLength(0) && Convert.ToChar(clickedButton.Content) != '\0'; ++i)
            {
                for (int j = 0; j < BoardButtons.GetLength(1); ++j)
                {
                    if (BoardButtons[i, j] == clickedButton)
                    {
                        if ((char)BoardButtons[i, j].Content == '-')
                        {
                            BlankTileForm bf = new BlankTileForm();
                            if (bf.ShowDialog() == true)
                            {
                                BoardButtons[i, j].Content = bf.List.SelectedItem;
                            }
                        }
                        BoardCharView[i, j] = (char)BoardButtons[i, j].Content;
                        game.moveRecorder.Record(i, j);
                    }
                }

            }
        }


        // обновляем запись в логи
        private void UpdatePlayerInfoLbl(int p)
        {
            PlayerInfoLbl.Content = "Игрой " + (p + 1) + "твой ход.";
        }

        // добавяем фишки на форму
        private void LoadBoardView()
        {
            for (int i = 0; i < BoardButtons.GetLength(0); ++i)
            {
                for (int j = 0; j < BoardButtons.GetLength(1); ++j)
                {
                    BoardButtons[i, j].Content = game.gs.BoardChar[i, j];
                    BoardCharView[i, j] = game.gs.BoardChar[i, j];
                    BoardButtons[i, j].Background = game.UpdateColor(i, j);
                }

            }
        }

        // обновляем логи
        private void LogBoardWriter(string s)
        {
            LogBoard.Text = s + "\n" + LogBoard.Text;
        }

        // добавляем новый фишки
        private void GetNewTiles()
        {
            List<char> LoC = new List<char>();
            foreach (Button b in RackTileButtons)
            {
                if (b.IsEnabled == false)
                {
                    LoC.Add((char)b.Content);
                }
            }
            game.GetNewTiles(LoC, ThisPlayer);
        }

        // метод, для очистки движения
        private void Retry()
        {
            foreach (Button b in RackTileButtons)
            {
                if (b.IsEnabled == false)
                {
                    b.IsEnabled = true;
                }
            }
            game.ClearMovement();
        }

        private void LoadRackView()
        {
            DisableAll();
            for (int i = 0; i < game.gs.ListOfPlayers[ThisPlayer].PlayingTiles.Count; ++i)
            {
                char c = game.gs.ListOfPlayers[ThisPlayer].PlayingTiles[i].TileChar;
                RackTileButtons[i].Content = c;
            }
            if (ThisPlayer == GameState.GSInstance.PlayerNow)
            {
                EnableAll(); LogBoardWriter("Твой ход!");
            }
        }

        // добавляем в логи, слово, которое создал N игрок
        private void ListingPrevWords()
        {
            string s = "Игрок " + (GameState.GSInstance.PrevPlayer + 1) + " сделал это слово: ";
            foreach (KeyValuePair<string, int> kvp in GameState.GSInstance.CorrectWords)
            {
                s += kvp.Key + "(" + kvp.Value + " очков) ";
            }
            LogBoardWriter(s);
        }
        

        // метод нажатия на кнопку потвердить
        /*
         * Если фишка поставленна и оно проходит проверку, что слово существует, то обновляется у N игрока кол-во очков
         * Если нет, выводится сообщения и возращается всё на место
           */
        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (game.Validate(BoardCharView))
            {
                GetNewTiles();
                game.UpdateState(BoardCharView);
                PlayerNow = GameState.GSInstance.PlayerNow;
                UpdatePlayerInfoLbl(PlayerNow);

            }
            else
            {
                LogBoardWriter("Судья игры: \"Вы не поставили фишки или такого слова нету." +
                    " Попробуйте ещё раз!\"");
                LoadBoardView();
                Retry();
            }
        }

        // метод при нажатии на кнопку пропустить
        private void PassButton_Click(object sender, RoutedEventArgs e)
        {
            LogBoardWriter("Игрок " + (PlayerNow + 1) + " пропускает этот ход!");
            GameState.GSInstance.GamePass();
            UpdatePlayerInfoLbl(GameState.GSInstance.PlayerNow);
        }

        // проверка нажатия на кнопку поменять
        /* 
         * Создаём переменную - отвечающая за нажатия на кнопку поменять
         * Если она True - то мы меняем текст у кнопки, если нет оставляем всё 
         */

        bool SwapMode = false;
        private void SwapButton_Click(object sender, RoutedEventArgs e)
        {
            LastButton = SwapButton;
            if (!SwapMode)
            {
                SwapMode = true;
                LoadBoardView();
                LoadRackView();
                SwapButton.Content = "Подтвердить";
                ValidateButton.IsEnabled = false;
                PassButton.IsEnabled = false;
                ReloadButton.IsEnabled = false;
                if (game.CanSwap())
                {
                    LogBoardWriter("Выберите фишки, которые вам не нужны... Затем нажмите кнопку Подтвердить.");
                }
                else
                {
                    LogBoardWriter("Теперь вы не можете поменять фишки, потому что в мешке осталось менее 7 фишек!");
                    SwapButton.IsEnabled = false;
                }
            }
            else
            {
                foreach (Button b in ListSwapRackButton)
                {
                    b.Content = game.SwapChar((char)b.Content);
                }
                LastButton = null;
                SwapMode = false;
                ValidateButton.IsEnabled = true;
                ListSwapRackButton.Clear();
                PassButton.IsEnabled = true;
                SwapButton.Content = "Поменять";
                LogBoardWriter("Игрок " + (PlayerNow + 1) + " поменял свои фишки!");
                game.UpdateState(null);
            }
        }

        // метод на нажатия кнопки вернуть
        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadBoardView();
            Retry();
        }

        // включаем все кнопки
        private void EnableAll()
        {
            this.Topmost = true;
            foreach (Button b in RackTileButtons)
            {
                b.IsEnabled = true;
            }
            ValidateButton.IsEnabled = true;
            PassButton.IsEnabled = true;
            SwapButton.IsEnabled = true;
            ReloadButton.IsEnabled = true;
            HelpButton.IsEnabled = true;
        }


        // выключаем все кнопки
        private void DisableAll()
        {
            this.Topmost = false;
            foreach (Button b in RackTileButtons)
            {
                b.IsEnabled = false;
            }
            ValidateButton.IsEnabled = false;
            PassButton.IsEnabled = false;
            SwapButton.IsEnabled = false;
            ReloadButton.IsEnabled = false;
            HelpButton.IsEnabled = false;
        }

        private void DisableEverthing()
        {
            DisableAll();
            foreach (Button b in BoardGrid.Children)
            {
                b.IsEnabled = false;
            }
        }

        // метод проверки игры
        /*
         * Если игра закончилась, то выводится сообщения
         * Если нажимаем играть, пропустить, поменять
         */
        public void OnStateChanged()
        {
            LogBoardWriter("Игрок " + (GameState.GSInstance.PrevPlayer + 1) + " завершил свой ход!");
            if (game.GameEnd())
            {
                foreach (Player p in game.gs.ListOfPlayers)
                {
                    LogBoardWriter(game.gs.ListOfPlayers[PlayerNow].ToString());
                }
                game.gs.ListOfPlayers.Sort();
                LogBoardWriter("Игру выйграл " + (game.gs.ListOfPlayers[0].Id + 1) + " со счётом " + (game.gs.ListOfPlayers[0].Score) + "!!!");
                LogBoardWriter("Закрой игру и начни новую игру в Эрудит!!!");
                DisableEverthing();
                return;
            }
            // Enable all buttons
            if (GameState.GSInstance.LastAction == "играть")
            {
                ListingPrevWords();
                LogBoardWriter(game.gs.ListOfPlayers[GameState.GSInstance.PrevPlayer].ToString());
            }
            else if (GameState.GSInstance.LastAction == "пропустить")
            {
                LogBoardWriter("Игрок " + (GameState.GSInstance.PrevPlayer + 1) + " пропускает ход!");
            }
            else if (GameState.GSInstance.LastAction == "поменять")
            {
                LogBoardWriter("Игрок " + (GameState.GSInstance.PrevPlayer + 1) + " поменял свои фишки!");
            }
            PlayerNow = GameState.GSInstance.PlayerNow;
            UpdatePlayerInfoLbl(GameState.GSInstance.PlayerNow);
            LoadBoardView();
            LoadRackView();
        }


        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow hw = new HelpWindow();
            hw.ShowDialog();
        }
    }
}
