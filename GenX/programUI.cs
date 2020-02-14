using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenX
{
    class ProgramUI
    {
        public User user = new User();



       
        public void Run()
        {
            GetGamertag();
        }
        public void GetGamertag()
        {
            Console.Write("Enter GamerTag: ");
            user.Gamertag = Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
        public void MainMenu()
        {
            Console.WriteLine("   Main Menu");
            Console.WriteLine("---------------");
            Console.WriteLine("[1] Pick Mode");
            Console.WriteLine("[2] Instructions");
            Console.WriteLine("[3] HighScores");
            Console.WriteLine("[4] Exit Game");
            Console.WriteLine("---------------");
            Console.WriteLine("Please selecet an option from 1-4\n");
            string mainMenuChoice = Console.ReadLine();
            if (mainMenuChoice == "1" || mainMenuChoice == "2" || mainMenuChoice == "3" || mainMenuChoice == "4")
            {
                // if user input is 1-4 it will go to corresponding menu
                Console.Clear();
                MainSubMenu(mainMenuChoice);
            }
            else
            {   //  if user doesn't input 1-4
                Console.Clear();
                Console.WriteLine("Try again ;)\n" +
                        "Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
        }
        public void MainSubMenu(string mainMenuChoice)
        {

            switch (mainMenuChoice)
            {
                //  mode sub menu
                case "1":
                    Console.WriteLine("   Modes");
                    Console.WriteLine("---------------");
                    Console.WriteLine("[1] Easy Mode");
                    Console.WriteLine("[2] Medium Mode");
                    Console.WriteLine("[3] Hard Mode");
                    Console.WriteLine("---------------");
                    Console.WriteLine($"Games Left: {user.GameAttemptsLeft}");
                    Console.WriteLine($"Points Scored: {user.Points}");
                    //OutOfLives();
                    Console.WriteLine("Please selecet an option from 1 - 3\n");
                    string modeMenuChoice = Console.ReadLine();
                    if (modeMenuChoice == "1" || modeMenuChoice == "2" || modeMenuChoice == "3")
                    {
                        // if user input is 1-3 it will go to corresponding menu
                        Console.Clear();
                        //ModeSubMenu();
                        ModeSubMenu(modeMenuChoice);
                    }
                    else
                    {   //  if user doesn't input 1-3
                        Console.Clear();
                        Console.WriteLine("Try again ;)\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        MainSubMenu(mainMenuChoice);
                    }
                    break;
                //  instuctions submenu
                case "2":
                    Console.WriteLine("   Instrucions");
                    Console.WriteLine("---------------");
                    Console.WriteLine("instrucions eia;feiwajfeiaw");
                    Console.WriteLine("---------------");
                    Console.WriteLine("Press any key to return to Main Menu...");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                // highscores submenu
                case "3":
                    Console.WriteLine("   High Scores");
                    Console.WriteLine("---------------");
                    Console.WriteLine($"{user.Gamertag}      {user.Points}");
                    // collect high score data and display here
                    Console.WriteLine("---------------");
                    Console.WriteLine("Press any key to return to Main Menu...");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                // exit submenu
                case "4":
                    Console.WriteLine("Are you sure?!?!");
                    Console.WriteLine("[1] YES [2] NO");
                    string exitGame = Console.ReadLine();
                    if (exitGame == "1")
                    {
                        //exit game method goes here
                        //System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        MainMenu();
                    }
                    break;
            }
        }
        public void ModeSubMenu(string modeMenuChoice)
        {
            switch (modeMenuChoice)
            {   
                case "1":
                    // Easy Game Mode Here
                    EasyModeGame();
                    break;
                case "2":
                    // Medium Game Mode Here
                    MediumModeGame();
                    break;
                case "3":
                    // Hard Game Mode Here
                    HardModeGame();
                    break;
            }
        }
        public void EasyModeGame()
        {
            int attemptsLeft = 2;
            int points = 10; 

            Console.WriteLine("I'm thinking of a number...\n" +
                "Got it!");

            // RNG here
            Random randm = new Random();
            int randomNumber = randm.Next(1, 11);

            //  DELETE BEFORE DEPLOYMENT
            Console.WriteLine("your random # " + randomNumber);

            // Displays attempts left above userInput prompt
            Console.WriteLine($"Attempts Left: {attemptsLeft}");
            Console.Write("Pick a number 1-10: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (attemptsLeft > 0)
            {
                // Converts and stores user guess and checks if it's equal to the RNG
                if (userInput == randomNumber)
                {
                    // What happens if they guess the right number
                    Console.Clear();
                    Console.WriteLine($"Congrats {user.Gamertag}!\n" +
                        $"You scored {points} pts!");
                    Console.ReadLine();
                    user.Points += (points);
                    //Return to Mode Select Menu if GameAttemptsLeft > 0
                    if (user.GameAttemptsLeft > 1)
                    {
                        user.GameAttemptsLeft -= 1;
                        Console.Clear();
                        MainSubMenu("1");

                    }
                    else
                    {
                        Console.Clear();
                        HighScoresMenu();
                    }
                }
                else
                {
                    // What happens if they guess the wrong number
                    Console.Clear();
                    Console.WriteLine("Wrong!");
                    Console.WriteLine($"Attempts Left: {attemptsLeft -= 1}");
                    Console.Write("Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (attemptsLeft == 1)
                    {
                        //Return to Mode Select Menu if GameAttemptsLeft > 0
                        if (user.GameAttemptsLeft > 1)
                        {
                            user.GameAttemptsLeft -= 1;
                            Console.Clear();
                            MainSubMenu("1");
                        }
                        else
                        {
                            Console.Clear();
                            HighScoresMenu();
                        }
                    }
                }

            }
        }
        public void MediumModeGame()
        {
            int attemptsLeft = 3;
            int points = 50;

            Console.WriteLine("I'm thinking of a number...\n" +
                "Got it!");

            // RNG here
            Random randm = new Random();
            int randomNumber = randm.Next(1, 51);

            //  DELETE BEFORE DEPLOYMENT
            Console.WriteLine("your random # " + randomNumber);

            // Displays attempts left above userInput prompt
            Console.WriteLine($"Attempts Left: {attemptsLeft}");
            Console.Write("Pick a number 1-50: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (attemptsLeft > 0)
            {
                // Converts and stores user guess and checks if it's equal to the RNG
                if (userInput == randomNumber)
                {
                    // What happens if they guess the right number
                    Console.Clear();
                    Console.WriteLine($"Congrats {user.Gamertag}!\n" +
                        $"You scored {points} pts!");
                    Console.ReadLine();
                    user.Points += (points);
                    //Return to Mode Select Menu if GameAttemptsLeft > 0
                    if (user.GameAttemptsLeft > 1)
                    {
                        user.GameAttemptsLeft -= 1;
                        Console.Clear();
                        MainSubMenu("1");

                    }
                    else
                    {
                        Console.Clear();
                        HighScoresMenu();
                    }
                }
                else
                {
                    // What happens if they guess the wrong number
                    Console.Clear();
                    Console.WriteLine("Wrong!");
                    Console.WriteLine($"Attempts Left: {attemptsLeft -= 1}");
                    Console.Write("Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (attemptsLeft == 1)
                    {
                        //Return to Mode Select Menu if GameAttemptsLeft > 0
                        if (user.GameAttemptsLeft > 1)
                        {
                            user.GameAttemptsLeft -= 1;
                            Console.Clear();
                            MainSubMenu("1");
                        }
                        else
                        {
                            Console.Clear();
                            HighScoresMenu();
                        }
                    }
                }

            }
        }
        public void HardModeGame()
        {
            int attemptsLeft = 5;
            int points = 100;

            Console.WriteLine("I'm thinking of a number...\n" +
                "Got it!");

            // RNG here
            Random randm = new Random();
            int randomNumber = randm.Next(1, 101);

            //  DELETE BEFORE DEPLOYMENT
            Console.WriteLine("your random # " + randomNumber);

            // Displays attempts left above userInput prompt
            Console.WriteLine($"Attempts Left: {attemptsLeft}");
            Console.Write("Pick a number 1-100: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (attemptsLeft > 0)
            {
                // Converts and stores user guess and checks if it's equal to the RNG
                if (userInput == randomNumber)
                {
                    // What happens if they guess the right number
                    Console.Clear();
                    Console.WriteLine($"Congrats {user.Gamertag}!\n" +
                        $"You scored {points} pts!");
                    Console.ReadLine();
                    user.Points += (points);
                    //Return to Mode Select Menu if GameAttemptsLeft > 0
                    if (user.GameAttemptsLeft > 1)
                    {
                        user.GameAttemptsLeft -= 1;
                        Console.Clear();
                        MainSubMenu("1");

                    }
                    else
                    {
                        Console.Clear();
                        HighScoresMenu();
                    }
                }
                else
                {
                    // What happens if they guess the wrong number
                    Console.Clear();
                    Console.WriteLine("Wrong!");
                    Console.WriteLine($"Attempts Left: {attemptsLeft -= 1}");
                    Console.Write("Guess again: ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (attemptsLeft == 1)
                    {
                        //Return to Mode Select Menu if GameAttemptsLeft > 0
                        if (user.GameAttemptsLeft > 1)
                        {
                            user.GameAttemptsLeft -= 1;
                            Console.Clear();
                            MainSubMenu("1");
                        }
                        else
                        {
                            Console.Clear();
                            HighScoresMenu();
                        }
                    }
                }

            }
        }
        public void HighScoresMenu()
        {
            Console.WriteLine("   High Scores");
            Console.WriteLine("---------------");
            Console.WriteLine($"{user.Gamertag}      {user.Points}");
            // collect high score data and display here
            Console.WriteLine("---------------");
            Console.ReadKey();
            ExitGame();
        }
        public void OutOfLives()
        {
            if (user.GameAttemptsLeft == 0)
            {
                Console.Clear();
                Console.WriteLine($"Thanks for playing {user.Gamertag}!");

                HighScoresMenu();
            }
        }
        public void ExitGame()
        {
            System.Environment.Exit(0);
        }

    }

}


