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
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {   
            var result = AllTiles.ScoreOfLetter('�');

            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_1()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

       
        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }


        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_2()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_3()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(3, result);
        }


        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_4()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_4()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(4, result);
        }

        

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_5()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_8()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_8()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }
        
        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }
        
        [Test]
        public void AllTiles_ScoreOfLetter_�_Should_Return_10()
        {
            // Arrange

            // Act
            var result = AllTiles.ScoreOfLetter('�');

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