using NUnit.Framework;
using Scrabble.Model;

namespace UnitTests
{
    public class AllTilesTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AllTiles_Empty_Should_Return_False()
        {
            // Arrange
            AllTiles tiles = new AllTiles();

            // Act
            var result = tiles.Empty();

            // Reset

            // Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void AllTiles_Empty_Should_Return_True()
        {
            // Arrange
            AllTiles tiles = new AllTiles();

            // Act
            tiles.ListTiles.Clear();
            var result = tiles.Empty();

            // Reset

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_E_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Å');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_À_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('À');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Â_Should_Return_1()
        {   
            var result = AllTiles.ScoreOfLetter('Â');

            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_È_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('È');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Í_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Í');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Î_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Î');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ð_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ð');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ñ_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ñ');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ò_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ò');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

       
        [Test]
        public void AllTiles_ScoreOfLetter_Ä_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ä');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ê_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ê');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ë_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ë');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }


        [Test]
        public void AllTiles_ScoreOfLetter_Ì_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ì');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ï_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ï');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ó_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ó');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Á_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Á');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ã_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ã');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_¨_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('¨');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ü_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ü');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void AllTiles_ScoreOfLetter_ß_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('ß');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }


        [Test]
        public void AllTiles_ScoreOfLetter_É_Should_Return_4()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('É');

            // Reset

            // Assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Û_Should_Return_4()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Û');

            // Reset

            // Assert
            Assert.AreEqual(4, result);
        }

        

        [Test]
        public void AllTiles_ScoreOfLetter_Æ_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Æ');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ç_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ç');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Õ_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Õ');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ö_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ö');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_×_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('×');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ø_Should_Return_8()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ø');

            // Reset

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ý_Should_Return_8()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ý');

            // Reset

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Þ_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Þ');

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Ô_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ô');

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }
        
        [Test]
        public void AllTiles_ScoreOfLetter_Ù_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ù');

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }
        
        [Test]
        public void AllTiles_ScoreOfLetter_Ú_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('Ú');

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_Dash_Should_Return_0()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('-');

            // Reset

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_IllegalCharacter_Should_Return_0()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('*');

            // Reset

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}