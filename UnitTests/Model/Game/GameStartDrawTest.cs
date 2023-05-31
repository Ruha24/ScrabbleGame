using NUnit.Framework;
using Scrabble.Model.Game;

namespace UnitTests
{
    public class GameStartDrawTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GameStartDraw_Draw_Should_Pass()
        {
            
            GameStartDraw.Draw();
          
            Assert.IsTrue(true);
           
        }
    }
}