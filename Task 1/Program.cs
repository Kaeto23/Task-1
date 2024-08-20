using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_and_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinueProgram = true;

            while (ContinueProgram)
            {

                Console.WriteLine("Select an option: ");
                Console.WriteLine("Option 1:BlueTagTask1 ");
                Console.WriteLine("Option 2:AreaofCircle ");
                Console.WriteLine("Option 3:QuadraticEquationSolver ");
                Console.WriteLine("Option 4:PythagoreanTheorySolver ");
                Console.WriteLine("Option 5:Quit ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BlueTagTask1();
                        break;
                    case 2:
                        AreaofCircle();
                        break;
                    case 3:
                        QuadraticEquationSolver();
                        break;
                    case 4:
                        PythagoreanTheorySolver();
                        break;
                    case 5:
                        ContinueProgram = false;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Please choose option either 1, 2, 3, 4 or 5");
                        break;

                }


            }
        }

        private static void PythagoreanTheorySolver()
        {
            //C# Program to Solve a Pythagoream Theory 

            Console.WriteLine("Enter side A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double C = Math.Sqrt((A * A) + (B * B));
            Console.WriteLine("The hypotenuse is: " + C);
            Console.ReadKey();
        }

        private static void QuadraticEquationSolver()
        {
            //C# Program to Find Roots of a Quadratic Equation

            double a, b, c;
            Console.Write("\n Enter the value for a : ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("\n Enter the value for b : ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("\n Enter the value for c : ");
            c = Double.Parse(Console.ReadLine());

            // Calculate the discriminant

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The solutions are:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The solution is:");
                Console.WriteLine("x = " + x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The equation has no real solutions.");
                Console.ReadLine();
            }
        }

        private static void AreaofCircle()
        {
            //C# Program to Find Area of a Circle
            const double pi = 3.14;
            Console.Write("\n Enter the value for Radius : ");
            double Radius = Double.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle={0}", pi * Radius * Radius);
            Console.ReadLine();
        }

        private static void BlueTagTask1()
        {
            //C# Program to Solve the first BlueTag task

            double A, b, C, D, T;
            Console.Write("\n Enter the value for A : ");
            A = Double.Parse(Console.ReadLine());
            Console.Write("\n Enter the value for B : ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("\n Enter the value for C : ");
            C = Double.Parse(Console.ReadLine());
            Console.Write("\n Enter the value for D : ");
            D = Double.Parse(Console.ReadLine());
            Console.Write("\n Enter the value for T: ");
            T = Double.Parse(Console.ReadLine());
            double resultValue = ((Math.Sqrt(A * b) / (2 * D)) * 3 - (Math.Sqrt(Math.Sqrt((T * C))) / (2 * D) * (Math.Sqrt((T * C))) / (2 * D))) / (4 * A * C);
            Console.WriteLine("Your Answer is : " + resultValue);

            Console.ReadLine();
        }
    }
}

    