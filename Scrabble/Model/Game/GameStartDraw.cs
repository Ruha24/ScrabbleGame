using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Model.Game
{
    public static class GameStartDraw
    {
        // Класс, который рисует начало приложения
        public static Dictionary<int, Tile> Drawn;
        private static Random rnd = new Random();
        private static AllTiles TilesBag;
        private static List<Tile> ListGot;
        public static void Draw()
        {
            Drawn = new Dictionary<int, Tile>();
            TilesBag = new AllTiles();
            for (int i = 0; i < GameState.GSInstance.NumOfPlayers; i++)
            {
                Drawn.Add(i, TilesBag.ListTiles[rnd.Next(0, TilesBag.ListTiles.Count)]);
            }
            ListGot = Drawn.Values.ToList();
            ListGot.Sort();
            GameState.GSInstance.PlayerNow = Drawn.FirstOrDefault(x => x.Value == ListGot[0]).Key;
        }
    }
}