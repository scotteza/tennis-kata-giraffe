using NUnit.Framework;

namespace Tennis.Test
{
    internal class TennisGameShould
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void Setup()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void Drive_The_Testing_Framework()
        {
            Assert.That(true, Is.EqualTo(true));
        }

        [Test]
        public void Start_With_A_Score_Of_Love_All()
        {
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("love-all"));
        }

        [Test]
        public void Let_Player_1_Score_A_Single_Point()
        {
            _tennisGame.ScorePoint(1);
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("fifteen-love"));
        }

        [Test]
        public void Let_Player_1_Score_2_Points()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("thirty-love"));
        }
        [Test]
        public void Let_Player_1_Score_3_Points()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("forty-love"));
        }

        [Test]
        public void Let_Both_Players_Score_A_Single_Point()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("fifteen-fifteen"));
        }
    }
}
