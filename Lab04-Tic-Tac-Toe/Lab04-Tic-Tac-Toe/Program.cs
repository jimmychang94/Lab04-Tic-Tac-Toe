using System;
using Lab04_Tic_Tac_Toe.Classes;

namespace Lab04_Tic_Tac_Toe
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                playAgain = Play();
            }
        }

        /// <summary>
        /// This method acts as the menu behind the game.
        /// </summary>
        /// <returns>A boolean for whether the user wants to play again</returns>
        static bool Play()
        {
            Console.WriteLine("Player 1, what do you want your name to be?");
            Player player1 = new Player(Console.ReadLine(), "X");
            if (player1.Name == "Miss Kitty Gitty Enum")
            {
                Win(player1);
                return false;
            }
            Console.WriteLine("Player 2, what do you want your name to be?");
            Player player2 = new Player(Console.ReadLine(), "O");
            if (player2.Name == "Miss Kitty Gitty Enum")
            {
                Win(player2);
                return false;
            }
            Game.GameStart(player1, player2);
            Console.WriteLine("Do you want to play again? y/n");
            string response = Console.ReadLine().Trim().ToLower();
            if (response != "y")
            {
                return false;
            }
            return true;

        }

        /// <summary>
        /// Secret
        /// </summary>
        /// <param name="player">Reasons</param>
        static void Win(Player player)
        {
            string[][] board = new string[][]
            {
                new[] {player.Icon, player.Icon, player.Icon },
                new[] {player.Icon, player.Icon, player.Icon },
                new[] {player.Icon, player.Icon, player.Icon },
            };
            Game.PrintGame(board);
            Console.WriteLine("Nobody can beat Miss Kitty!!!");
            Console.WriteLine("Would you like to go to the cat stop? y/n");
            string reply = Console.ReadLine().Trim().ToLower();
            if (reply == "y")
            {
                Console.WriteLine("Let's go!");
            }
            else
            {
                Console.WriteLine("Well, I'm bringing you anyways!");
            }
            Player.CatStop();
        }
    }
}
