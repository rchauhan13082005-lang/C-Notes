//Chapter2//
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Chapter2
{
    //Based on Topic 3//
    enum Grade
    {       
        A = 90,
        B = 80,
        C = 70,
        D = 60,
        F = 0
    }

    class Program
    {
        public static void Main()
        {
            //Topic 1 - Initialization of datatypes, variable//
            
            string Name = "Rajat";
            int age = 21;
            double percentage = 70.5d;
            bool passed = true;
            char grade = 'B'; 

            Console.WriteLine($"Name:  {Name}");
            Console.WriteLine($"Age ,{age}");
            Console.WriteLine($"Pracentage,{percentage}");
            Console.WriteLine($"Passed,{passed}");
            Console.WriteLine($"Grade,{grade}");

            //Topic 2 - Type inference//

            var  AnimalName = "Bug Bunny";
            var  Age = 12;
            var isRabbit = true;

            Type nameType = AnimalName.GetType();
            Type AgeType = Age.GetType();
            Type AnimalType = isRabbit.GetType();

            Console.WriteLine($"Name of the Type of Animal: {nameType.ToString()}");
            Console.WriteLine($"Age of Animal: {AgeType.ToString()}");
            Console.WriteLine($"Type of Animal: {AnimalType.ToString()}");

            //Topic 3 - Condtional Statements, Enum//
             
            int StudentMarks = Convert.ToInt32(Console.ReadLine());
            if (StudentMarks <= 90)
            {
                Console.WriteLine("Excellent"+ Grade.A);
                
            }
            else if(StudentMarks <= 80)
            {
                Console.WriteLine("Good" + Grade.B);
               
            }
            else if(StudentMarks <= 70)
            {
                Console.WriteLine("Avarage"+Grade.C);
               
            }
            else if(StudentMarks <= 60)
            {
                Console.WriteLine("Avarage"+Grade.D);
             
            }
            else
            {
                Console.WriteLine("Fail" + Grade.F);
            }

            // Topic 4 - While,Do- While, Jump Statement, Switch case brake, Goto Statement//

            // While Loop//

            int attempt = 0;
            int pin = 1234;
            bool LoggedIn = false;

            while(attempt < 3 && !LoggedIn)
            {
                Console.WriteLine("Enter your pin");
                int userPin = Convert.ToInt32(Console.ReadLine());
                attempt++;
                if(userPin == pin)
                {
                    LoggedIn = true;
                    Console.WriteLine("Login Successful !");
                }
                else
                {
                    Console.WriteLine("Wrong Pin !");
                }
            }
            if (!LoggedIn)
            {
                Console.WriteLine("Account Locked !");
            }

            //Do While Loop//

            int choice;
            do
            {
                Console.WriteLine("==Menu==");
                Console.WriteLine("1. View Prifile");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Opening Profile...");
                        break;

                    case 2:
                        Console.WriteLine("Balance 5,000");
                        break;

                    case 3:
                        Console.WriteLine("Exiting");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 3);


            //Jump Statement//

            //break //
            for(int i = 1; i <= 50; i++)
            {
                if(i % 10 == 0)
                {
                    Console.WriteLine("First number Divisible by 10 is:");
                    break;
                }
            }

            //Continue//
            for(int i = 1; i <= 50; i++)
            {
                if(i % 10 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //return//
            static int CalculateTotal(int price, int quantity)
            {
                if (quantity <= 0)
                {
                    return 0;
                }
                return price * quantity;
            }
            int total = CalculateTotal(100, 5);
            Console.WriteLine(total);

            // Goto Statement//
            int number = 5;
            if (number == 5)
            {
                goto Five;
            }
            Console.WriteLine("This will skipped if number is 5");
        Five:
            Console.WriteLine("Number is 5");
        }
    }
}