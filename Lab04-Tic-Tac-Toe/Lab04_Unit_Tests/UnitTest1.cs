using System;
using Xunit;
using Lab04_Tic_Tac_Toe;
using Lab04_Tic_Tac_Toe.Classes;

namespace Lab04_Unit_Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// This is a basic test of win conditions.
        /// Horizontal, Vertical, and both Diagonals are tested using different players
        /// </summary>
        /// <param name="p1Value1">The 1st value taken by Player 1</param>
        /// <param name="p1Value2">The 2nd value taken by Player 1</param>
        /// <param name="p1Value3">The 3rd value taken by Player 1</param>
        /// <param name="p2Value1">The 1st value taken by Player 2</param>
        /// <param name="p2Value2">The 2nd value taken by Player 2</param>
        /// <param name="p2Value3">The 3rd value taken by Player 2</param>
        /// <param name="expectedWinningIcon">The icon of the player expected to win the round</param>
        [Theory]
        [InlineData(1, 2, 3 , 5, 7, 8, "X")]
        [InlineData(1, 2, 8 , 5, 7, 3, "O")]
        [InlineData(3, 5, 8 , 1, 4, 7, "O")]
        [InlineData(1, 5, 9 , 2, 4, 3, "X")]
        public void WinnersTest(int p1Value1, int p1Value2, int p1Value3, int p2Value1, int p2Value2, int p2Value3, string expectedWinningIcon)
        {
            //Arrange
            Player player1 = new Player("tester1", "X");
            Player player2 = new Player("tester2", "O");
            string[][] board = GameBoard.Board();
            board = Game.GameMechanics(player1, board, p1Value1);
            board = Game.GameMechanics(player1, board, p1Value2);
            board = Game.GameMechanics(player1, board, p1Value3);
            board = Game.GameMechanics(player2, board, p2Value1);
            board = Game.GameMechanics(player2, board, p2Value2);
            board = Game.GameMechanics(player2, board, p2Value3);

            // Act
            Player Winner = Game.CheckForWinner(player1, player2, board);

            // Assert
            Assert.Equal(expectedWinningIcon, Winner.Icon);

        }
        /// <summary>
        /// This test is to make sure that players can swap from Player 1 to Player 2
        /// </summary>
        [Fact]
        public void SwitchPlayerFromPlayer1ToPlayer2Test()
        {
            // Arrange
            Player player1 = new Player("tester1", "X");
            Player player2 = new Player("tester2", "O");
            player1.Turn = true;

            // Act
            Game.SwitchPlayer(player1, player2);

            // Assert 
            Assert.True(player2.Turn);
        }

        /// <summary>
        /// This test is to make sure that players can swap from Player 2 to Player 1
        /// </summary>
        [Fact]
        public void SwitchPlayerFromPlayer2ToPlayer1Test()
        {
            // Arrange
            Player player1 = new Player("tester1", "X");
            Player player2 = new Player("tester2", "O");
            player2.Turn = true;

            // Act
            Game.SwitchPlayer(player1, player2);

            // Assert 
            Assert.True(player1.Turn);
        }
        /// <summary>
        /// This test is to make sure that an input number is transformed into the correct coordinates
        /// </summary>
        /// <param name="number">The number that shall be transformed</param>
        /// <param name="x">The expected row after the transformation</param>
        /// <param name="y">The expected column after the transformation</param>
        [Theory]
        [InlineData(9, 2, 2)]
        [InlineData(5, 1, 1)]
        [InlineData(4, 1, 0)]
        [InlineData(7, 2, 0)]
        public void InputPositionIsCorrectIndexOfArray(int number, int x, int y)
        {
            // Arrange
            int[] index;
            bool correctPosition;

            // Act
            index = GameBoard.Positions(number);
            if ((index[0] == x) && (index[1] == y))
            {
                correctPosition = true;
            } else
            {
                correctPosition = false;
            }

            // Assert
            Assert.True(correctPosition);
        }
        
        /// <summary>
        /// This is a basic test to make sure that the boards are being correctly printed.
        /// </summary>
        [Fact]
        public void PrintingTheCorrectBoard()
        {
            // Arrange
            string[][] board = new string[][]
            {
                new[] {"X", "O", "X" },
                new[] {"4", "O", "X" },
                new[] {"O", "X", "9" }
            };

            // Act
            bool gamePrinted = Game.PrintGame(board);

            // Assert
            Assert.True(gamePrinted);
        }
    }
}
