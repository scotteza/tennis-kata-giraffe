using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame
    {
        private int _player1Points;
        private int _player2Points;

        private readonly int _minimumPointsForWinEligibility;
        private readonly int _pointsDifferenceRequiredForWin;
        private readonly int _deucePoints;

        private readonly Dictionary<int, string> _scoreLookup;

        public TennisGame()
        {
            _player1Points = 0;
            _player2Points = 0;

            _minimumPointsForWinEligibility = 4;
            _pointsDifferenceRequiredForWin = 2;
            _deucePoints = 3;

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
            if (_player1Points == _deucePoints
                && _player2Points == _deucePoints)
            {
                return "deuce";
            }

            if (_player1Points >= _deucePoints
                && _player2Points >= _deucePoints
                && GetPointsDifference(_player1Points, _player2Points) == 1)
            {
                return "advantage player 1";
            }

            if (_player1Points >= _minimumPointsForWinEligibility
            && GetPointsDifference(_player1Points, _player2Points) >= _pointsDifferenceRequiredForWin)
            {
                return "player 1 wins";
            }

            if (_player2Points >= _minimumPointsForWinEligibility
                && GetPointsDifference(_player2Points, _player1Points) >= _pointsDifferenceRequiredForWin)
            {
                return "player 2 wins";
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

        private int GetPointsDifference(int playerAPoints, int playerBPoints)
        {
            return playerAPoints - playerBPoints;
        }
    }
}
