using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Points;
        private int _player2Points;

        public TennisGame()
        {
            _player1Points = 0;
            _player2Points = 0;
        }

        public string GetScore()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                { 0, "love" },
                { 1, "fifteen" },
                { 2, "thirty" },
                { 3, "forty" }
            };

            return $"{scoreLookup[_player1Points]}-{scoreLookup[_player2Points]}";
        }

        public void ScorePoint(int playerNumber)
        {
            if (playerNumber == 1)
            {
                _player1Points++;
            }

            if (playerNumber == 2)
            {
                _player2Points++;
            }
        }
    }
}
