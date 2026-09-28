using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace C_Notes.Operators
{
    //Basic Initilization of Operator//
    class Basic_Operator
    {
        static void Main()
        {
            // Types Operator basic operation we can perform with operator//
            //Arithmetic//
            int a = 20;
            int b = 6;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // Operator Concatination//
            string FirstName = "Rajat";
            string LastName = "Chauhan";

            string FullName = FirstName +" " + LastName;

            Console.WriteLine(FullName);

            // Assingment Operator// 
            int x = 23;

            x += x;
            x -= x;
            x *= x;
            x /= x;

            Console.WriteLine(x);

            // Comperision Operator//

            int A = 10;
            int B = 5;

            Console.WriteLine(A == B);
            Console.WriteLine(A <= B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A != B);
            Console.WriteLine(A < B);
            Console.WriteLine(A > B);

            // Increment prefix operator //
            int X = ++A;
            
            Console.WriteLine(X);

            // Increment Postfix operator//
            int Y = A++;
            Console.WriteLine(Y);

            //Ternary operator//
            int age = 20;
            string result = age >= 18 ? "Adult" : "Minor";

            Console.WriteLine(result);

            //Logical Operator//
            //And&&//
            int Age = 25;
            bool hasLicense = true;

            if (Age >= 18 && hasLicense) 
            {
                Console.WriteLine("Allowed");
            }
            //OR||//
            bool hasEmail = false;
            bool hasPhone = true;
            
            if(hasEmail || hasPhone)
            {
                Console.WriteLine("Contact information is Avaliable");
            }

            //Not!//
            bool isLoggedIn = false;

            if (!isLoggedIn)
            {
                Console.WriteLine("Please Login");
            }


            // is & as operator with different operation //
            //is operator check whether an object is compitable with any type//

            //operation1//
            object value = "Hello";

            if(value is string)
            {
                Console.WriteLine("It is a string");
            }

            //operation2//
            object Value = 100;

            Console.WriteLine(Value is int);
            Console.WriteLine(Value is string);
            Console.WriteLine(Value is double);

            //operation3//

            object obj = "Hello";
            
            if(obj is string text)
            {
                Console.WriteLine(text.Length);
            }

            //as operator //
            /*as Operator attempts to convert the object to an specified reference type, nullable,
            value type or type parameter*/

            object obj2 = "Hello";
            string text2 = obj2 as string;
            Console.WriteLine(text2);


        }

    }
}
