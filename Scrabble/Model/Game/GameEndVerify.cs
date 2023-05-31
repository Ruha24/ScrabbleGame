namespace Scrabble.Model
{
    public static class GameEndVerify
    {
       // Класс, который используется, чтобы проверить, закончилась игра или нет
        public static Player p0;

        // проверка на количество фишек
        public static bool TilebagLessThanSeven(GameState gs)
        {
            if (gs.TilesBag.ListTiles.Count < 7) return true;
            return false;
        }

        // проверка на существования фишек у игрока
        public static bool ExistsPlayerNoTiles(GameState gs)
        {
            foreach (Player p in gs.ListOfPlayers)
            {
                if (p.PlayingTiles.Count == 0) { p0 = p; return true; }
            }
            return false;
        }

        // проверка на окончание игры
        public static bool GameEndScoring(GameState gs)
        {
            if (TilebagLessThanSeven(gs))
            {
                if (ExistsPlayerNoTiles(gs))
                {
                    foreach (Player p in gs.ListOfPlayers)
                    {
                        if (p != p0)
                        {
                            foreach (Tile t in p.PlayingTiles)
                            {
                                p0.Score += AllTiles.ScoreOfLetter(t.TileChar);
                                p.Score -= AllTiles.ScoreOfLetter(t.TileChar);
                            }
                        }
                    }
                }
                else
                {
                    foreach (Player p in gs.ListOfPlayers)
                    {
                        foreach (Tile t in p.PlayingTiles)
                        {
                            p.Score -= AllTiles.ScoreOfLetter(t.TileChar);
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
