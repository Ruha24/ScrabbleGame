namespace Scrabble.Model
{
    public class Welcome
    {
        public static string NumOfPlayersInfo(int num)
        {
            return "В этой игре " + num + " игрока...";
        }
        public static string WelcomeText
        {
            get { return "Приветствую игроков! В игре Эрудит!"; }
        }

    }
}
