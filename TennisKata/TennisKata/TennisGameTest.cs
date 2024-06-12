using FluentAssertions;
using NUnit.Framework;

namespace TennisKata
{
    public class Tests
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void Setup()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void LoveAll()
        {
            ScoreShouldBe("Love All");
        }

        [Test]
        public void FifteenLove()
        {
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void ThirtyLove()
        {
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void FortyLove()
        {
            ScoreShouldBe("Forty Love");
        }

        [Test]
        public void LoveFifteen()
        {
            ScoreShouldBe("Love Fifteen");
        }

        [Test]
        public void LoveThirty()
        {
            ScoreShouldBe("Love Thirty");
        }

        [Test]
        public void LoveForty()
        {
            ScoreShouldBe("Love Forty");
        }

        [Test]
        public void FifteenForty()
        {
            ScoreShouldBe("Fifteen Forty");
        }

        [Test]
        public void FifteenAll()
        {
            ScoreShouldBe("Fifteen All");
        }

        [Test]
        public void ThirtyAll()
        {
            ScoreShouldBe("Thirty All");
        }

        [Test]
        public void Deuce()
        {
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void FirstPlayer_Adv()
        {
            ScoreShouldBe($"Player1 Adv");
        }

        [Test]
        public void SecondPlayer_Adv()
        {
            ScoreShouldBe($"Player2 Adv");
        }

        [Test]
        public void FirstPlayer_Win()
        {
            ScoreShouldBe($"Player1 Win");
        }

        [Test]
        public void SecondPlayer_Win()
        {
            ScoreShouldBe($"Player2 Win");
        }


        private void ScoreShouldBe(string score)
        {
            _tennisGame.Score().Should().Be(score);
        }
    }
}