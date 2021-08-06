using System;
using System.Collections.Generic;
using System.Threading;


namespace ProblematicProblem
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Random rng = new Random();        
         bool cont = true;
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
            bool fortheloveofgod;
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string checker = Console.ReadLine();
            if (checker == "yes")
                fortheloveofgod = true;
            else
            {
                Console.Write(" oh. well then. bye!");
                Thread.Sleep(500);
                System.Environment.Exit(0);
            }
            
               
                    


            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            string answerOne = Console.ReadLine();
            bool seeList;
            if (answerOne == "Sure")
                seeList = true;
            else
                seeList = false;

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;
                string answerTwo = Console.ReadLine();
                if (answerTwo == "yes")
                    addToList = true;
                else
                    addToList = false;

                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    string answerThree = Console.ReadLine();
                    if (answerThree == "yes")
                        addToList = true;
                    else
                        addToList = false;
                    
                    
                }
            }
            
            
            
            while (cont)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                int randomNumber =  rng.Next(activities.Count);

                string randomActivity = activities[randomNumber];

                if (userAge > 21 && randomActivity == "Wine Tasting")
                {
                    
                    Console.WriteLine($"Oh no! Looks like you are too young to do Wine Tasting");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                     randomNumber = rng.Next(activities.Count);

                     randomActivity = activities[randomNumber];
                }

                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                string answerFour = Console.ReadLine();
                if (answerFour == "Redo" )
                    cont = true;
                else
                    cont = false;
            }
        }
    }
}
