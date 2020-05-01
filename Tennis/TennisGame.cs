﻿using System.Collections.Generic;

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

            var scoreLookup = new Dictionary<int, string>
            {
                { 0, "love" },
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
