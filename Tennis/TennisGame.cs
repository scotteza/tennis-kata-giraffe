using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Points;
        private int _player2Points;
        private readonly Dictionary<int, string> _scoreLookup;

        public TennisGame()
        {
            _player1Points = 0;
            _player2Points = 0;

            _scoreLookup = new Dictionary<int, string>
            {
                { 0, "love" },
                { 1, "fifteen" },
                { 2, "thirty" },
                { 3, "forty" }
            };
        }

        public string GetScore()
        {
            if (_player1Points >= 4 && _player1Points - _player2Points >= 2)
            {
                return "player 1 wins";
            }

            return $"{_scoreLookup[_player1Points]}-{_scoreLookup[_player2Points]}";
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
