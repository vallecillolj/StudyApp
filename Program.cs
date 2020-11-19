
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using static System.Console;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.ConstrainedExecution;
using System.IO;
using System.Text.Encodings;

namespace Study
{
    class Game
    {
        string gameName = "Leo's Study Guide";
        public Game()
        {
            //Beginning
            Title = gameName;




            WriteLine("Welcome to Leo's study guide!");
            WriteLine("Please enter your name.");
            string PlayerName = Console.ReadLine();

            WriteLine("Hello, " + PlayerName);
            WriteLine("Press enter to continue...");


            WriteLine("Here are your questions. Study!");
            string path = "questions.txt";
            string contents = "";
            if (File.Exists(path))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                contents = File.ReadAllText(path);

            }
            Console.WriteLine(contents);
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("Answers provided in answers.txt");
            string apath = "answers.txt";
            string[] aarray =
            {
                "c sharp",
                "letters",
                "numbers",
                "object",
                "increment",
                "decrement",
                "operators",
                "tolower",
                "toupper",
                "instance",
                "public",
                "boolean",
                "writeline",
                "binary",
                "conditional statements",
            };
            //WriteAllLines from https://www.c-sharpcorner.com/article/c-sharp-write-to-file/
            File.WriteAllLines(apath, aarray);
            WriteLine("Press enter to continue...");
            ReadKey();
            Clear();
            Start();
        }

        public void Start()
        {
            int Score = 0;
            string Input = "placeholder";

            Console.WriteLine("Type Your Answer and Hit Enter!");
            string[] Answers = new string[15]
           {
                "c sharp",
                "letters",
                "numbers",
                "object",
                "increment",
                "decrement",
                "operators",
                "tolower",
                "toupper",
                "instance",
                "public",
                "boolean",
                "writeline",
                "binary",
                "conditional statements",
           };

            string[] Questions = new string[15]
            {
                "How do you pronounce C#?",
                "What is a string made up of?",
                "What is an integer made up of?",
                "What is an instance of a class called?",
                "What is an increase by 1 called?",
                "What is a decrease by 1 called?",
                "+, -, /, * are examples of what?",
                "Changes all letters in a string to lowercase.",
                "Changes all letters in a string to uppercase",
                "An object is an _____ of a class.",
                "Makes classes accessible.",
                "True and False make up?",
                "Prints text.",
                "1 and 0 are integers used in ______ language.",
                "OR, AND, NOR, are examples of?",
            };
            //Random variable generator taken from https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netcore-3.1
            var Rand = new Random();

            //i int taken from Christmas Lyrics Assignment
            for (int i = 0; i < 15; i++)
            {

                //random range from https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netcore-3.1#code-try-5
                int num = Rand.Next(0, 15);

                WriteLine(Questions[num]);

                Input = Console.ReadLine();
                Input.ToLower();

                if (Input == Answers[num])
                {
                    WriteLine("Correct! +1!");
                    Score++;
                    WriteLine("Current Score: " + Score);
                    WriteLine("Press any key to continue...");
                    ReadKey();
                    Clear();
                }
                else
                {
                    WriteLine("Incorrect, the answer was " + Answers[num]);
                    Score--;
                    WriteLine("Current Score: " + Score);
                    WriteLine("Press any key to continue...");
                    ReadKey();
                    Clear();
                }
                while (Score <= -5)
                {
                    Clear();
                    WriteLine("You lost! Your score was: " + Score);
                    WriteLine("Press 1 to restart, 0 to exit.");
                    if (ReadKey().Key == ConsoleKey.D1)
                    {
                        Clear();
                        new Study.Game();
                    }
                    else if (ReadKey().Key == ConsoleKey.D0)
                    {
                        Environment.Exit(0);
                    }
                }
            }



            WriteLine("Final Score: " + Score);



            WriteLine("Play Again? 1 to restart, 0 to close.");

            //ConsoleKeys taken from https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=netcore-3.1
            if (ReadKey().Key == ConsoleKey.D1)
            {
                Clear();
                new Study.Game();
            }
            else if (ReadKey().Key == ConsoleKey.D0)
            {
                //exit command from https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console
                Environment.Exit(0);
            }
        }

    }

}

public class Player
{
    public string PlayerName = "John Doe";
}




class Program
{
    static void Main()
    {
        new Study.Game();
    }
}
