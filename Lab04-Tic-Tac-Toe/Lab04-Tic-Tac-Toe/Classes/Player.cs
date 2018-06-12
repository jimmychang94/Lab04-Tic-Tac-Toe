using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Tic_Tac_Toe.Classes
{
    public class Player
    {
        /// <summary>
        /// This stores the name for the players
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This stores whose turn it is
        /// </summary>
        public bool Turn { get; set; } = false;
        /// <summary>
        /// This stores what the icon for the player is
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// This is the constructor for a player object. It requires both a name and an icon
        /// </summary>
        /// <param name="name">The name of the player</param>
        /// <param name="icon">The icon to represent the player</param>
        public Player(string name, string icon)
        {
            Name = name;
            Icon = icon;
        }

        /// <summary>
        /// Blub...
        /// </summary>
        public static void OctoCat()
        {
            Console.WriteLine(@" 
                                    /\   /\    
                                   /  \_/  \    
                                  (  o - o  )  
                                   (  v v  )
                             ~~~~~._////\\\\_.~~~~~
                             ~~~~.__///  \\\__.~~~~
                             ~~~.___//    \\___.~~~
                             ~~.____/      \____.~~
                                                        ");
            Console.WriteLine("So you want to go to the cat stop?");
            Console.WriteLine("I'm feeling great since I won, I'll bring you there");
            Console.ReadLine();
            CatStop();
        }

        /// <summary>
        /// Shh...
        /// </summary>
        public static void CatStop()
        {
            Console.WriteLine(@"
                                    /\   /\
                                   /  \_/  \
                                  (  o . o  ) .
                                    ( v v )__/
                                                        ");
            Console.WriteLine("Welcome back to the the cat stop!");
            Console.WriteLine("Have three fish!");
            Console.WriteLine(@"
                         _J""-.               _J""-.                _J""-.
                        / o )) \ ,'`;        / o )) \ ,'`;         / o )) \ ,'`;
                        \   ))  ;   |        \   ))  ;   |         \   ))  ;   |
                         `v-.-'' \._;         `v-.-'' \._;          `v-.-'' \._;
                                                            ");
            Console.WriteLine("Thanks for visiting!");
            Console.WriteLine("No hints this time, good luck getting here next time!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
