using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            int playerScore =0, CPUScore = 0;

            Console.WriteLine("Choose Between Rock/Paper/Scissors:    ");
            inputPlayer = Console.ReadLine(); //takes input

            Random rnd = new Random();

            randomInt = rnd.Next(1, 4); //returns integer between 1 and 4 or range

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer choose Rock");

                    if (inputPlayer == "ROCK")
                        Console.WriteLine("Its a Draw");
                  
                    else if (inputPlayer == "PAPER") { 
                        Console.WriteLine("Player Won");
                        playerScore++;
                    }
                    
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("Computer Won");
                        CPUScore++; 
                    }

                    break;

                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer choose Paper");


                    if (inputPlayer == "PAPER")
                        Console.WriteLine("Its a Draw");

                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Computer Won");
                        CPUScore++;
                    }

                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("Player Won");
                        playerScore++;
                    }


                    break;

                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer choose Scissors");

                    if (inputPlayer == "SCISSORS")
                        Console.WriteLine("Its a Draw");

                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Player Won");
                        playerScore++;
                    }

                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Computer Won");
                        CPUScore++;
                    }



                    break;

                default:
                    Console.WriteLine("Computer choose wrong");
                    break;
            }




        }
    }
}
