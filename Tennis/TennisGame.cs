using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Points;
        private int _player2Points;

        public string GetScore()
        {
            if (_player1Points == 1 && _player2Points == 1)
            {
                return "fifteen-fifteen";
            }

            if (_player1Points == 1)
            {
                return "fifteen-love";
            }

            if (_player1Points == 2)
            {
                return "thirty-love";
            }

            Dictionary<int, string> scoreLookup = new Dictionary<int, string>();
            scoreLookup.Add(3, "forty");

            if (_player1Points == 3)
            {
                return $"{scoreLookup[_player1Points]}-love";
            }

            return "love-all";
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
