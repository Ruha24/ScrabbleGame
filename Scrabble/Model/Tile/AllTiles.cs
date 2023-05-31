using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Scrabble.Model
{
    public class AllTiles
    {
        // проверка пусты ли фишки
        public bool Empty()
        {
            if (ListTiles.Count > 0) return false;
            else return true;
        }

        public List<Tile> ListTiles;

        public AllTiles()
        {
            MakeTiles();
        }


        // создаём фишки
        public void MakeTiles()
        {
            ListTiles = new List<Tile>();
            for (char c = 'А'; c <= 'Я'; c++)
            {
                for (int x = 0; x < NumOfLetters(c); x++)
                {
                    Tile t = new Tile(c, ScoreOfLetter(c));
                    ListTiles.Add(t);
                }
            }
            Tile b = new Tile('-', 0);
            ListTiles.Add(b);
            ListTiles.Add(b);
        }

        /*
         * Фишки
         * 98 количество
         * 2 пустые
         */

        // количесто очков за букву
        public static int ScoreOfLetter(char c)
        {
            switch (c)
            {
                case 'А':
                case 'В':
                case 'Е':
                case 'И':
                case 'Н':
                case 'О':
                case 'Р':
                case 'С':
                case 'Т':
                    return 1;
                   
                case 'Д':
                case 'К':
                case 'Л':
                case 'М':
                case 'П':
                case 'У':
                    return 2;
                    

                case 'Б':
                case 'Г':
                case 'Ё':
                case 'Ь':
                case 'Я':
                    return 3;

                case 'Й':
                case 'Ы':
                    return 4;

                case 'Ж':
                case 'З':
                case 'Х':
                case 'Ц':
                case 'Ч':
                    return 5;
                   

                case 'Ш':
                case 'Э':
                case 'Ю':
                    return 8;
                
                case 'Щ':
                case 'Ъ':
                case 'Ф':
                    return 10;
                   

                case '-':
                    return 0;
                   

                default:
                    return 0;
                   
            }
        }

        [ExcludeFromCodeCoverage]

        // количество букв
        private static int NumOfLetters(char c)
        {
            switch (c)
            {
                case 'Ё':
                case 'Ж':
                case 'Й':
                case 'Ф':
                case 'Х':
                case 'Ц':
                case 'Ч':
                case 'Ш':
                case 'Щ':
                case 'Ъ':
                case 'Э':
                case 'Ю':
                    return 1;

                case 'Б':
                case 'Г':
                case 'З':
                case 'Ы':
                case 'Ь':
                case 'Я':
                    return 2;

                case 'М':
                    return 3;

                case 'В':
                case 'Д':
                case 'К':
                case 'Л':
                case 'П':
                case 'У':
                    return 4;

                case 'И':
                case 'Н':
                case 'Р':
                case 'С':
                case 'Т':
                    return 5;

                case 'Е':
                case 'А':
                    return 8;

                case 'О':
                    return 10;

                default:
                    return 0;
            }
        }
    }
}
