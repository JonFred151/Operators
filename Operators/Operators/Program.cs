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
                int Total = Sum(a, b);
                Console.WriteLine(Total);
                //calls the method to subtract a-b
                int Sub = Subtract(a, b); 
                Console.WriteLine(Sub);
                //calls the method to multiple a*b
                int Product = Multi(a, b);
                Console.WriteLine(Product);
                //callsw the method to divide 
                int Divisor = Divide(a, b); 
                Console.WriteLine(Divisor);
               //method to call the remainder a%b
               int Remain = Remainder(a, b);
              Console.WriteLine(Remain);

            Console.WriteLine("Enter a radius");
             radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);

            Console.WriteLine(area);
             
            
        }

           public static int Sum(int a, int b)
        {
            return a + b;
        } 
            public static int Subtract(int a, int b)
        {
            return a - b;
        }
            public static int Multi(int a, int b)
        {
            return a * b;
        }
            public static int Divide(int a, int b)
        {
            return a/b;
        }
            public static int Remainder(int a, int b)
        {
            return (a % b);
        }




           public static double AreaOfCircle(double radius)
        {

            return Math.PI* Math.Pow(radius, 2);

            
        } 







    }







}



