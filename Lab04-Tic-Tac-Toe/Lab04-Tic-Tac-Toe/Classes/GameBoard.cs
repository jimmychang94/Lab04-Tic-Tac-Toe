using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Tic_Tac_Toe.Classes
{
    public class GameBoard
    {
        /// <summary>
        /// This is the initial creation of the board.
        /// </summary>
        /// <returns>A blank board</returns>
        public static string[][] Board ()
        {
            string[][] board = new string[][]
            {
                new[] {"1", "2", "3" },
                new[] {"4", "5", "6" },
                new[] {"7", "8", "9" }
            };
            return board;
        }

        /// <summary>
        /// This method is used to find the corresponding row/column for a number between 1 and 9.
        /// </summary>
        /// <param name="number">Any number; though those not between 1 and 9 are dismissed</param>
        /// <returns>An array for the row/column corresponding to the number inputted</returns>
        public static int[] Positions(int number)
        {
            // The position is initially set to -1, -1 beceause there is a 0, 0 value and I'm unsure what would happen if I just do int[2].
            int[] position = new int[] { -1, -1 };
            switch (number)
            {
                case 1:
                    position[0] = 0;
                    position[1] = 0;
                    break;
                case 2:
                    position[0] = 0;
                    position[1] = 1;
                    break;
                case 3:
                    position[0] = 0;
                    position[1] = 2;
                    break;
                case 4:
                    position[0] = 1;
                    position[1] = 0;
                    break;
                case 5:
                    position[0] = 1;
                    position[1] = 1;
                    break;
                case 6:
                    position[0] = 1;
                    position[1] = 2;
                    break;
                case 7:
                    position[0] = 2;
                    position[1] = 0;
                    break;
                case 8:
                    position[0] = 2;
                    position[1] = 1;
                    break;
                case 9:
                    position[0] = 2;
                    position[1] = 2;
                    break;
            }
            return position;
        }

        /// <summary>
        /// A method to store the winning combinations.
        /// </summary>
        /// <returns>An array of arrays that hold winning combinations</returns>
        public static int[][] Winners ()
        {
            int[][] winners = new int[][]
            {
                new[] {1,2,3},
                new[] {4,5,6},
                new[] {7,8,9},

                new[] {1,4,7},
                new[] {2,5,8},
                new[] {3,6,9},

                new[] {1,5,9},
                new[] {3,5,7}
            };
            return winners;
        }
    }
}
