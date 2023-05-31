using System;
using System.Collections.Generic;
using Scrabble.View;
using Scrabble.Model.Game;

namespace Scrabble.Model
{
    public class GameState
    {
        // Главный класс игры, отвечающий за состояния
        public char[,] BoardChar;
        public List<Player> ListOfPlayers;
        public AllTiles TilesBag;
        public List<string> WordsAppeared;
        public List<string> WordsAppearedInValidation;
        public PlayerManager playerManager;
        public BoardTiles boardTiles;
        public int PlayerCountingScore;
        public Dictionary<string, int> CorrectWords;
        public bool FirstMove;
        public int PlayerNow;
        public int PlayerFirst;
        public Random rnd = new Random();
        private bool InPlaying = false;
        public delegate void StateChangedHandler();
        public StateChangedHandler OnStateChanged = delegate { };
        public string LastAction;
        public int PrevPlayer;
        public int PrevScores;

        private static GameState gsInstance = null;
        public static GameState GSInstance
        {
            get
            {
                if (gsInstance == null) gsInstance = new GameState();
                return gsInstance;
            }
        }

        public static void ResetState() { gsInstance = null; }

        
        // метод отвечающий за пропуск хода
        public void GamePass()
        {
            PrevPlayer = PlayerNow;
            PlayerNow = NextPlayer();
            LastAction = "пропустить";
            OnStateChanged.Invoke();
        }

        // переход игрока к игроку
        public int NextPlayer()
        {
            if (++PlayerNow < NumOfPlayers)
            {
                return PlayerNow;
            }
            else
            {
                PlayerNow = 0;
                return 0;
            }
        }

        public int NumOfPlayers;

        public GameState()
        {
            this.ListOfPlayers = new List<Player>();
            this.TilesBag = new AllTiles();
            this.playerManager = new PlayerManager();

            this.WordsAppeared = new List<string>();
            this.WordsAppearedInValidation = new List<string>();
            this.BoardChar = new char[15, 15];
            this.boardTiles = new BoardTiles();
            this.CorrectWords = new Dictionary<string, int>();
            this.FirstMove = true;
            this.ListOfViews = new List<IView>();
            for (int i = 0; i < BoardChar.GetLength(0); ++i)
            {
                for (int j = 0; j < BoardChar.GetLength(1); ++j)
                {
                    BoardChar[i, j] = '\0';
                }
            }
        }


        // метод, обновления всего
        public void UpdateState(char[,] b)
        {
            PrevPlayer = PlayerNow;
            this.FirstMove = false;
            PlayerNow = NextPlayer();

            if (b == null) { LastAction = "поменять"; OnStateChanged.Invoke(); return; }

            LastAction = "играть";
            PrevScores = PlayerCountingScore;
            playerManager.AddScoresToPlayer(ListOfPlayers[PrevPlayer], PlayerCountingScore);

            for (int i = 0; i < b.GetLength(0); ++i)
            {
                for (int j = 0; j < b.GetLength(1); ++j)
                {
                    this.BoardChar[i, j] = b[i, j];

                }
            }

            PlayerCountingScore = 0;
            foreach (string s in WordsAppearedInValidation)
            {
                if (!WordsAppeared.Exists(e => e == s))
                {
                    WordsAppeared.Add(s);
                }
            }
            OnStateChanged.Invoke();
        }

        // метод, иницилизации
        public void Initialise(int num)
        {
            NumOfPlayers = num;
            playerManager.CreatePlayers(gsInstance);
            GameStartDraw.Draw();
           
            InPlaying = true;
        }

        public List<IView> ListOfViews;

        public void RegObserver(IView view)
        {
            if (view != null) ListOfViews.Add(view);
        }

        public void UnregObserver(IView view)
        {
            if (view != null) ListOfViews.Remove(view);
        }

        public void NotifyGameStateChange()
        {
            foreach (IView v in ListOfViews)
            {
                v.OnStateChanged();
            }
        }

    }
}
