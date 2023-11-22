using System;


namespace Operators
{
        internal class program
    {

            public static void Main(string[] args)
        {
            // initinalize and assign variables
                int a = 1;
                int b = 2;
            double radius;
                // calls the method to add a+b
                int total = sum(a, b);
                Console.WriteLine(total);
                //calls the method to subtract a-b
                int sub = subtract(a, b); 
                Console.WriteLine(sub);
                //calls the method to multiple a*b
                int product = multi(a, b);
                Console.WriteLine(product);
                //callsw the method to divide 
                int divisor = divide(a, b); 
                Console.WriteLine(divisor);
               //method to call the remainder a%b
               int remain = remainder(a, b);
              Console.WriteLine(remain);

            Console.WriteLine("Enter a radius");
             radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);

            Console.WriteLine(area);
             
            
        }

           public static int sum(int a, int b)
        {
            return a + b;
        } 
            public static int subtract(int a, int b)
        {
            return a - b;
        }
            public static int multi(int a, int b)
        {
            return a * b;
        }
            public static int divide(int a, int b)
        {
            return a/b;
        }
            public static int remainder(int a, int b)
        {
            return (a % b);
        }




           public static double AreaOfCircle(double radius)
        {

            return Math.PI* Math.Pow(radius, 2);

            
        } 







    }







}



