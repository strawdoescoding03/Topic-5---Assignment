namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gravVenus, gravMars, gravJupiter, gravSaturn, gravUranus, gravNeptune, weightLbs;

            int planetChoice;

            gravVenus = 0.78;
            gravMars = 0.39;
            gravJupiter = 2.65;
            gravSaturn = 1.17;
            gravUranus = 1.05;
            gravNeptune = 1.23;


            Console.WriteLine("Welcome to the Interplanatary Boxing League!");
            Console.WriteLine();
            Console.WriteLine("You are the esteemed Julio Cesar Chavez Mark VII undefeated champion!");
            Console.WriteLine("Before you enter your next big championship, what is your current earth weight?");
            double.TryParse(Console.ReadLine(), out weightLbs);
            Console.WriteLine();
            while (weightLbs < 29.99)
            {
                Console.WriteLine("Your weight is too small to compete in the championships!");
                Console.WriteLine("Go eat a sandwhich! Or try again!");


                double.TryParse(Console.ReadLine(), out weightLbs);

            }

            if (weightLbs > 30)

            {
                Console.WriteLine("Thank you esteemed champion!");
                Console.WriteLine("Your weight has qualified for the championship!");

            }
            Console.WriteLine();
            Console.WriteLine("What Planet Would You Like to Attend First?");
            Console.WriteLine("===========================================");
            Console.WriteLine("1) Venus");
            Console.WriteLine("2) Mars");
            Console.WriteLine("3) Jupiter");
            Console.WriteLine("4) Saturn");
            Console.WriteLine("5) Uranus");
            Console.WriteLine("6) Neptune");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out planetChoice);

            while (planetChoice < 0 || planetChoice > 6)
            {
                Console.WriteLine("Invalid Answer! Please Pick an Actuall Planet :)");
                int.TryParse(Console.ReadLine(), out planetChoice);
            }

                if (planetChoice >= 1 && planetChoice <= 6)

            {
                Console.WriteLine("Valid Choice! Calculating Weight Class Now!");
                Console.WriteLine();
            }

            if (planetChoice == 1)
            {
                weightLbs = (weightLbs * gravVenus);

                Console.WriteLine("Your weight on Venus is " + weightLbs);

            }

            else if (planetChoice == 2)

            {
                weightLbs = (weightLbs * gravMars);

                Console.WriteLine("Your weight on Mars is " + weightLbs);
            }
        }
    }
}
