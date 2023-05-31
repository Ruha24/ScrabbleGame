using System.Windows;

namespace Scrabble.View
{
    public partial class BlankTileForm : Window
    {
        public BlankTileForm()
        {
            InitializeComponent();
            this.Topmost = true;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            for( char i = 'А' ; i <= 'Я' ; i++ )
            {
                List.Items.Add(i);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
