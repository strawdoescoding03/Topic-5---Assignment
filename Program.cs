using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gravVenus, gravMars, gravJupiter, gravSaturn, gravUranus, gravNeptune, weightLbs;

            int planetChoice, secretNum, secretNumGuess, scoreCount, questionCount, genZStartYear;

            string agreeHelpBoogie, multipleCoiceAns, trueFalse;

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
            questionCount = 1;


            Console.WriteLine("Your teacher has sprung a pop quiz on you and you didn't study!");
            Console.WriteLine("Try your best, and best of luck");

            Console.WriteLine("===============================================================");
            Console.WriteLine("Question " + questionCount + ": How many teletubies make up the core group?");
            Console.WriteLine("a) 5");
            Console.WriteLine("b) 3");
            Console.WriteLine("c) 4");
            Console.WriteLine("d) 6");
            Console.WriteLine();
            Console.Write("Your Answer: ");
            multipleCoiceAns = Console.ReadLine().ToLower();

            if (multipleCoiceAns == "c")
            {
                Console.WriteLine("Correct! There will always only be four. Any others are frauds.");
                scoreCount += 1;
            }
            else if (multipleCoiceAns == "a")
                Console.WriteLine("Incorrect! How could you forget there were four! They were iconic mythical beings! Who would be the fifth??");

            else if (multipleCoiceAns == "b")
                Console.WriteLine("Incorrect! I believe you forgot the red one! How dare you 0_0");

            else if (multipleCoiceAns == "d")
                Console.WriteLine("Incorrect! The teletubies were always a quartet! Maybe youre confusing them with the lazy reboot!");

            else
            {
                Console.WriteLine("Do you not know how to answer a multiple choice question? Where was " + multipleCoiceAns + " on the list???");
                Console.WriteLine("Try better next time! Such a big dissapointment");
            }


            Console.WriteLine("Press Enter to Continue to the Next Question");
            Console.WriteLine("You have " + (4 - questionCount) + " questions left");
            Console.ReadLine();
            questionCount += 1;
            Console.Clear();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Question " + questionCount + ": What Year did Gen Z Begin?");
            int.TryParse(Console.ReadLine(), out genZStartYear);

            if (genZStartYear == 1997)
            {
                Console.WriteLine("Correct! Making this oldest Gen Z humans " + (2025 - genZStartYear) + "!");
                scoreCount += 1;
            }
            else
            {
                Console.WriteLine("That is Incorrect!");
                if (genZStartYear > 1997 && genZStartYear <= 2000)
                {
                    Console.WriteLine("You were really close! However, that year was too large! The correct answer was 1997");
                }
                else if (genZStartYear < 1997 && genZStartYear >= 1994)
                {
                    Console.WriteLine("You were really close ! However your answer was too small!");
                    Console.WriteLine("The correct answer was 1997!");
                }
                else
                {
                    Console.WriteLine("You were way off! Gen Z started in 1997!");
                }

            }
            Console.WriteLine("Press Enter to Continue to the Next Question");
            Console.WriteLine("You have " + (4 - questionCount) + " questions left");
            Console.ReadLine();
            questionCount += 1;
            Console.Clear();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Question " + questionCount + " Which Leonardo was the famous heartthrob from Titanic");
            Console.WriteLine("a) Da Vinchi");
            Console.WriteLine("b) Dicaprio");
            Console.WriteLine("c) Di-craprio");
            Console.WriteLine("d) The Dog Man");
            Console.WriteLine();
            Console.Write("Your answer is: ");
            multipleCoiceAns = Console.ReadLine().ToLower();

            if (multipleCoiceAns == "b")
            {
                Console.WriteLine("Correct! Dicaprio, played the 90s heartthrob Jack from Titanic");
                scoreCount += 1;
            }
            else if (multipleCoiceAns == "a")
            {
                Console.WriteLine("Incorrect! leonardo Da Vinchi was the famous renaissance painter, not modern-day actor!");
                Console.WriteLine("Maybe you should've payed attention to art history in grade school :P.");
            }

            else if (multipleCoiceAns == "c")
            {
                Console.WriteLine("Incorrect! Although it should be the correct answer, there is no such person as Leonardo Di-craprio :(");
            }

            else if (multipleCoiceAns == "d")
            {
                Console.WriteLine("Who is even Leonardo the Dog Man? I think you've finally lost it.");
                Console.WriteLine("Getting some help should be a good first step :) ");
            }

            else
            {
                Console.WriteLine("Do you not know how to answer a multiple choice question? Where was " + multipleCoiceAns + " on the list???");
                Console.WriteLine("Try better next time! Such a big dissapointment");
            }

            Console.WriteLine("Press Enter to Continue to the Next Question");
            Console.WriteLine("You have " + (4 - questionCount) + " questions left");
            Console.ReadLine();
            questionCount += 1;
            Console.Clear();

            Console.WriteLine("===============================================================");
            Console.WriteLine("Question " + questionCount + ": What Country has the Most Northern Human Settelment?");
            Console.WriteLine("a) Canada");
            Console.WriteLine("b) Denmark (Greenland)");
            Console.WriteLine("c) Russia");
            Console.WriteLine("d) Sweeden");
            Console.WriteLine();
            Console.WriteLine("Your Answer: ");
            multipleCoiceAns = Console.ReadLine().ToLower();

            if (multipleCoiceAns == "a")
            {
                Console.WriteLine("Correct! Alert, Nunavut is the most northern settlement in the world!");
                scoreCount += 1;
            }

            else if (multipleCoiceAns == "b")
            {
                Console.WriteLine("Incorrect! Denmark is a reasonable answer due to it's ownership, however,");
                Console.WriteLine("Canada has the most northern settlement in the world, located in Alert Nunavut!");
            }

            else if (multipleCoiceAns == "c")
            {
                Console.WriteLine("Although Russia is geographically very north, it does not contain the most northern settlement!");
                Console.WriteLine("Canada has the most northern settlement in the world, located in Alert Nunavut!");
            }

            else if (multipleCoiceAns == "d")
            {
                Console.WriteLine("Incorrect! Denmark is a reasonable answer due to it's ownership, however,");
                Console.WriteLine("Canada has the most northern settlement in the world, located in Alert Nunavut!");
            }


            else
            {
                Console.WriteLine("Do you not know how to answer a multiple choice question? Where was " + multipleCoiceAns + " on the list???");
                Console.WriteLine("Try better next time! Such a big dissapointment");
            }


            Console.WriteLine("You have " + (4 - questionCount) + " questions left");
            Console.WriteLine("Press Enter to Continue to the results");
            Console.ReadLine();
            questionCount += 1;
            Console.Clear();


            Console.WriteLine("===============================================================");
            Console.WriteLine("Question " + questionCount + " True or False; All birds can fly :) ");
            trueFalse = Console.ReadLine().ToLower();

            if (trueFalse == "t" || trueFalse == "true" || trueFalse == "ture" || trueFalse == "tru")

            {
                Console.WriteLine("No bueno! That is incorrect, think of the mighty penguin! How do you think they feel. You heartless psychopath.");
            }

            else if (trueFalse == "f" ||  trueFalse == "false" ||  trueFalse == "fals")
            {
                Console.WriteLine("Muy bueno! That it mighty correct! Thank you for acknowledging the existance of penguins");
                questionCount += 1;
            }

            else
            {
                Console.WriteLine("Do you not know how to answer a true or false question? Where was " + multipleCoiceAns + " as an option???");
                Console.WriteLine("Try better next time! Such a big dissapointment");
            }


            Console.WriteLine("You have " + (4 - questionCount) + " questions left");
            Console.WriteLine("Press Enter to Continue to the results");
            Console.ReadLine();
            questionCount += 1;
            Console.Clear();

            














            Console.WriteLine("===============================================================");
            Console.WriteLine("YOUR SCORE: " + scoreCount + "/4!");
            Console.WriteLine("\t    " + ((scoreCount / 4) * 100) + "%");
            Console.WriteLine();

            if (scoreCount == 0)
            {
                Console.WriteLine("Ever heard that saying that guessing on a true or false quiz would theoretically produce 50%?");
                Console.WriteLine("Unfortunatly for you, this is not a true or false quiz. You didn't even score one point! Not even one point? How tragic :(");
                Console.WriteLine("You failed hard -_-");
            }   

            else if (((scoreCount / 4) * 100) <= 50 && ((scoreCount / 4) * 100) > 25)
            {
                Console.WriteLine("You did not pass the quiz! Good effort tho :)");
            }

            else if (scoreCount == 3)
                Console.WriteLine("Congratulations! You Passed The Quiz with 75%!");

            else
                Console.WriteLine("Woohoo! You aced this quiz with a grand total of 100%! Keep up the good work!");
        }   
    }   
}
