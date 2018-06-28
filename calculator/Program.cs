using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {


                string option;
                decimal a, b, sum, difference, division, multiplication, modulus;
                double cosine, sin, tan;

                WriteLine("What operation do you want to carry out?");
                WriteLine("");

                WriteLine("Addition");
                WriteLine("Subtraction");
                WriteLine("Division");
                WriteLine("Multiplication");
                WriteLine("Modulus");
                WriteLine("Cosine");
                WriteLine("Sine");
                WriteLine("Tangent");

                option = ReadLine();
                Clear();

                switch (option)
                {
                    case "Addition":
                        WriteLine("enter value a");
                        a = Convert.ToDecimal(ReadLine());
                        WriteLine("enter value b");
                        b = Convert.ToDecimal(ReadLine());

                        sum = a + b;

                        WriteLine($"the sum is {sum} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;



                    case "Subtraction":
                        WriteLine("enter value a");
                        a = Convert.ToDecimal(ReadLine());
                        WriteLine("enter value b");
                        b = Convert.ToDecimal(ReadLine());

                        difference = a - b;
                        WriteLine($"the difference is {difference} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;

                    case "Division":
                        WriteLine("enter value a");
                        a = Convert.ToDecimal(ReadLine());
                        WriteLine("enter value b");
                        b = Convert.ToDecimal(ReadLine());

                        division = a / b;
                        WriteLine($"the difference is {division} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;

                    case "Multiplication":
                        WriteLine("enter value a");
                        a = Convert.ToDecimal(ReadLine());
                        WriteLine("enter value b");
                        b = Convert.ToDecimal(ReadLine());

                        multiplication = a + b;
                        WriteLine($"the product is {multiplication} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;

                    case "Modulus":
                        WriteLine("enter value a");
                        a = Convert.ToDecimal(ReadLine());
                        WriteLine("enter value b");
                        b = Convert.ToDecimal(ReadLine());

                        modulus = a % b;
                        WriteLine($"the remainder is {modulus} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;

                    case "cosine":
                        WriteLine("enter value ");
                        cosine = Convert.ToDouble(ReadLine());

                        cosine = Cos(cosine);
                        WriteLine($"the cosine is {cosine} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;

                    case "Sine":
                        WriteLine("enter value ");
                        sin = Convert.ToDouble(ReadLine());

                        sin = Sin(sin);
                        WriteLine($"the sin is {sin} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;

                    case "tan":
                        WriteLine("enter value ");
                        tan = Convert.ToDouble(ReadLine());

                        tan = Tan(tan);
                        WriteLine($"the cosine is {tan} ");
                        WriteLine("");
                        WriteLine("Press any key to do another calculation");
                        ReadKey();
                        Clear();
                        break;


                }
            }

            Console.ReadKey();

        }
    }
}
