using System;

namespace lab6
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            /* an application that simulates dice rolling.  asks the user to enter the number
             * of sides for a pair of dice.
             * 
             * the application prompts the user to roll the dice.
             * 
             * the application "rolls" two n-sided dice, displays the results of each
             * and then asks the user if they would like to roll the dice again.
             * 
             * the application includes input validation, methods for generating random numbers, and 
             * customized messages for specified number combinations (snake eyes,
             * box cars, craps)
             * */

            Console.WriteLine("Welcome to the Grand Circus Casino! ");

            bool keepasking = true;
            while (keepasking)
            {
                Console.WriteLine("Roll the Dice? (y/n):  ");
                string initialask = Console.ReadLine().ToLower();

                if (initialask == "y")
                {
                    keepasking = false;
                    RollDice();
                }
                else if (initialask == "n")
                {
                    keepasking = false;
                    Console.WriteLine("Bye!");
                }

                else
                {
                    Console.WriteLine("You did not enter a valid response final (y/n).");
                    continue;

                }
            } 

        }

        // ** Method for randomization of two ints, prints ints to console, compares the two ints
        // and prints messages to the console pending on the values (snake eyes, box cars,
        // and craps).
        static void Randomer(int bob)
        {
            // create new Random object
            Random r = new Random();
            Random r2 = new Random();

            // sets the range for the random numbers from 1 to whatever the input is.
            int rando1 = r.Next(1, bob);
            int rando2 = r.Next(1, bob);
            Console.WriteLine(rando1);
            Console.WriteLine(rando2);

            if (rando1 == 1 && rando2 == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if (rando1 == 6 && rando2 == 6)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if (rando1 + rando2 == 7 || rando1 +rando2 == 1)
            {
                Console.WriteLine("Craps!");
            }
        }

        // ** RollDice() method for "rolling the dice". 
        // includes while loops for asing to play again **
        static void RollDice()
        {
            // game's start.
            bool gameplay = true;
            while (gameplay)
            {

                    bool validnumsides = true;
                    while (validnumsides)
                    {
                        Console.Write("How many sides should each die have?:  ");
                        string userinput = Console.ReadLine();

                        int diesides;
                        bool isvalidnumber = int.TryParse(userinput, out diesides);

                        if (isvalidnumber && diesides == 0)
                        {
                            Console.WriteLine("0 is not a valid number of sides.  Enter a number greater than 0.");
                            continue;
                        }

                        if (isvalidnumber)
                        {
                        Randomer(diesides);
                        validnumsides = false;
                        gameplay = false;

                        bool askagain = true;
                        while (askagain)
                        {
                            Console.Write("Roll Again? (y/n):  ");
                            string rollagainanswer = Console.ReadLine();

                            rollagainanswer.ToLower();

                            if (rollagainanswer == "y")
                            {
                                askagain = false;
                                gameplay = true;
                            }
                            else if (rollagainanswer == "n")
                            {
                                askagain = false;
                                Console.WriteLine("Bye!");
                            }

                            else if (rollagainanswer != "y" && rollagainanswer != "n")
                            {
                                Console.WriteLine("You did not enter a valid response (y/n).");
                                continue;

                            }  
                        }


                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid number of sides!");
                        continue;
                  
                    }
                }
            }


        }
    }

    }
