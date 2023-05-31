using System.Windows;
using System.Windows.Controls;
using Scrabble.View;
using Scrabble.Model;
using Scrabble.Controller;

namespace Scrabble
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int cnt = 0;
            foreach (ComboBox c in Interfaces.Children)
            {
                ComboBoxItem ci = c.SelectedItem as ComboBoxItem;
                if (ci != null && ci.ToString() != "") cnt++;
            }
            if (cnt >= 2)
            {
                GameState.GSInstance.Initialise(cnt);
                int P = 0;
                Game g = new Game();
                foreach (ComboBox c in Interfaces.Children)
                {
                    ComboBoxItem ci = c.SelectedItem as ComboBoxItem;
                    if (ci == null) continue;
                    if (ci.Content.ToString() == "Desktop")
                    {
                        DesktopWindow dw = new DesktopWindow(P, g);
                        dw.Show();
                        P++;
                    }                
                    else if (ci.Content.ToString() == "Mobile")
                    {
                        MobileWindow mw = new MobileWindow(P, g);
                        mw.Show();
                        P++;
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Вам нужно больше друзей, чтобы начать игру Эрудит!!!", "Найди друзей!");
            }
        }


        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow ab = new AboutWindow();
            ab.ShowDialog();
        }


    }
}
