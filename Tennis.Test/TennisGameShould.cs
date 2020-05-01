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

            Assert.That(score, Is.EqualTo("love-love"));
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

        [Test]
        public void Let_Both_Players_Score_2_Points()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("thirty-thirty"));
        }

        [Test]
        public void Let_Player_1_Win_With_Forty_And_A_Winning_Ball()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("player 1 wins"));
        }

        [Test]
        public void Let_Player_2_Win_With_Forty_And_A_Winning_Ball()
        {
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);
            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("player 2 wins"));
        }

        [Test]
        public void Detect_A_Deuce()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);

            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("deuce"));
        }

        [Test]
        public void Let_Player_1_Have_Advantage()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);

            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("advantage player 1"));
        }

        [Test]
        public void Let_Player_2_Have_Advantage()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);

            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("advantage player 2"));
        }

        [Test]
        public void Let_Player_1_Win_After_Advantage()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);

            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("player 1 wins"));
        }

        [Test]
        public void Let_Player_2_Win_After_Advantage()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);

            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("player 2 wins"));
        }

        [Test]
        public void Let_Player_1_Win_After_An_Advantage_Battle()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(1);

            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("player 1 wins"));
        }

        [Test]
        public void Let_Player_2_Win_After_An_Advantage_Battle()
        {
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(1);
            _tennisGame.ScorePoint(2);
            _tennisGame.ScorePoint(2);

            var score = _tennisGame.GetScore();

            Assert.That(score, Is.EqualTo("player 2 wins"));
        }
    }
}
