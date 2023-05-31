using NUnit.Framework;
using Scrabble;
using Scrabble.Model;
using System;

namespace UnitTests
{
    public class TilesTest
    {
        Tile tile;
        [SetUp]
        public void Setup()
        {
            tile = new Tile('�', 10);
        }

        [Test]
        public void Tiles_TileChar_Get_Should_Return_c()
        {
            // Arrange

            // Act
            var result = tile.TileChar;

            // Reset

            // Assert
            Assert.AreEqual('�', result);
        }

        [Test]
        public void Tiles_TileChar_Set_Should_Return_�()
        {
            // Arrange
            tile.TileChar = '�';

            // Act
            var result = tile.TileChar;

            // Reset
            tile.TileChar = '�';

            // Assert
            Assert.AreEqual('�', result);
        }

        [Test]
        public void Tiles_TileChar_Get_Should_Return_10()
        {
            // Arrange

            // Act
            var result = tile.TileScore;

            // Reset

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Tiles_TileChar_Set_Should_Return_5()
        {
            // Arrange
            tile.TileScore = 5;

            // Act
            var result = tile.TileScore;

            // Reset
            tile.TileScore = 10;

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Tiles_TileChar_CompareTo_Null_Should_Return_1()
        {
            // Arrange

            // Act
            var result = tile.CompareTo(null);

            // Reset

            // Assert
            Assert.AreEqual(1, result);
        }

      
    }
}