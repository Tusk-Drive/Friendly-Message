using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;// This program makes it so I can change the color of the backround page.
            Console.Clear();// this line of code makes it so the whole page is colored insted of just the portion with the text. 
            Console.ForegroundColor = ConsoleColor.Black;// this changes the color of the text. 
            Console.WriteLine("Hello Everyone, I hope that this program works.");
            Console.WriteLine("I wanted to test my skill at writing a program in C#, it has been a few years.");
            Console.WriteLine("If this works and you are reading it, I hope you have a good day.");
            Console.WriteLine("If you are intrested I can show you how to write a program like this as well.");
            Console.WriteLine("- Your Friend Tusk");
            Console.WriteLine("Press the X in the corner to exit");
            Console.ReadKey();
        }
    }
}
