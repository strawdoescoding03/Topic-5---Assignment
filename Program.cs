using System.Security.Cryptography;

namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gravVenus, gravMars, gravJupiter, gravSaturn, gravUranus, gravNeptune, weightLbs;

            int planetChoice, secretNum, secretNumGuess, scoreCount;

            string agreeHelpBoogie, teletubbyCount ;

            gravVenus = 0.78;
            gravMars = 0.39;
            gravJupiter = 2.65;
            gravSaturn = 1.17;
            gravUranus = 1.05;
            gravNeptune = 1.23;

            //// 1

            //Console.WriteLine("Welcome to the Interplanatary Boxing League!");
            //Console.WriteLine();
            //Console.WriteLine("You are the esteemed Julio Cesar Chavez Mark VII undefeated champion!");
            //Console.WriteLine("Before you enter your next big championship, what is your current earth weight?");
            //double.TryParse(Console.ReadLine(), out weightLbs);
            //Console.WriteLine();
            //while (weightLbs < 29.99)
            //{
            //    Console.WriteLine("Your weight is too small to compete in the championships!");
            //    Console.WriteLine("Go eat a sandwhich! Or try again!");

            //    double.TryParse(Console.ReadLine(), out weightLbs);

            //}

            //if (weightLbs > 30)

            //{
            //    Console.WriteLine("Thank you esteemed champion!");
            //    Console.WriteLine("Your weight has qualified for the championship!");

            //}
            //Console.WriteLine();
            //Console.WriteLine("What Planet Would You Like to Attend First?");
            //Console.WriteLine("===========================================");
            //Console.WriteLine("1) Venus");
            //Console.WriteLine("2) Mars");
            //Console.WriteLine("3) Jupiter");
            //Console.WriteLine("4) Saturn");
            //Console.WriteLine("5) Uranus");
            //Console.WriteLine("6) Neptune");
            //Console.WriteLine("===========================================");
            //Console.WriteLine();

            //int.TryParse(Console.ReadLine(), out planetChoice);

            //while (planetChoice < 0 || planetChoice > 6)
            //{
            //    Console.WriteLine("Invalid Answer! Please Pick an Actuall Planet :)");
            //    int.TryParse(Console.ReadLine(), out planetChoice);
            //}

            //if (planetChoice >= 1 && planetChoice <= 6)

            //{
            //    Console.WriteLine("Valid Choice! Calculating Weight Class Now!");
            //    Console.WriteLine();
            //}


            //if (planetChoice == 1)
            //{
            //    weightLbs = Math.Round((weightLbs * gravVenus), 2, MidpointRounding.AwayFromZero); ;

            //    Console.WriteLine("Your weight on Venus is " + weightLbs);

            //}

            //else if (planetChoice == 2)

            //{
            //    weightLbs = Math.Round((weightLbs * gravMars), 2, MidpointRounding.AwayFromZero);

            //    Console.WriteLine("Your weight on Mars is " + weightLbs);

            //}

            //else if (planetChoice == 3)

            //{
            //    weightLbs = Math.Round((weightLbs * gravJupiter), 2, MidpointRounding.AwayFromZero);

            //    Console.WriteLine("Your weight on Jupiter is " + weightLbs);
            //}

            //else if (planetChoice == 4)

            //{
            //    weightLbs = Math.Round((weightLbs * gravSaturn), 2, MidpointRounding.AwayFromZero);
            //    Console.WriteLine("Your weight on Saturn is " + weightLbs);
            //}

            //else if (planetChoice == 5)

            //{
            //    weightLbs = Math.Round((weightLbs * gravUranus), 2, MidpointRounding.AwayFromZero);
            //    Console.WriteLine("Your weight on Uranus is " + weightLbs);
            //}

            //else if (planetChoice == 6)
            //{
            //    weightLbs = Math.Round((weightLbs * gravNeptune), 2, MidpointRounding.AwayFromZero);
            //    Console.WriteLine("Your weight on Neptune is " + weightLbs);
            //}


            // 2 


            //secretNum = 9;

            //Console.WriteLine("The Boogeyman is in dire need of you help! He needs to get under his victim's bed");
            //Console.WriteLine("but he cannot enter unless he guesses the right number from 1 to 10! Will you help the Boogeyman?");
            //Console.Write("Type Yes or No: ");
            //agreeHelpBoogie = Console.ReadLine().ToLower();
            
            //Console.WriteLine();
            
            //if (agreeHelpBoogie == "yes")
            //    Console.WriteLine("The boogeyman is very happy! He thanks you for your service <3");

            //else
            //    Console.WriteLine("Too Bad! You are legally obliged to help the Boogeyman");

            //Console.WriteLine();

            //Console.WriteLine("Now guess the number (This it vital you get it right. The boogey will be angery >:(");

            //int.TryParse(Console.ReadLine(), out secretNumGuess);

            //if (secretNumGuess == secretNum)
            //{
            //    Console.WriteLine("You got it right! Congratulations! The boogeyman is greatful for your service.");
            //    Console.WriteLine("You are no longer imprisoned!");
            //}

            //else
            //{
            //    Console.WriteLine("Oh no! You got it wrong. The secret number was found on a card and it turned out to be " + secretNum + "!");
            //    Console.WriteLine("Since you got it wrong, you will forever be imprisoned by the boogeyman. Shame on you! Shame on your Cow.");

            //}


            scoreCount = 0;

            Console.WriteLine("Your teacher has sprung a pop quiz on you and you didn't study!");
            Console.WriteLine("Try your best, and best of luck");

            Console.WriteLine("===============================================================");
            Console.WriteLine("Question One: How many teletubies make up the core group?");
            Console.WriteLine("a) 5");
            Console.WriteLine("b) 3");
            Console.WriteLine("c) 4");
            Console.WriteLine("d) 6");
            Console.WriteLine();
            Console.Write("Your Answer: ");
            teletubbyCount = Console.ReadLine().ToLower();

            if (teletubbyCount == "c")

            {
                Console.WriteLine("Correct!");
                scoreCount += 1;
            }

            else
                Console.WriteLine("Incorrect!");



        }   
    }   
}
