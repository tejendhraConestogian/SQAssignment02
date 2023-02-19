using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Rectangle cal = new Rectangle();
            double l = 1;
            double w = 1;
        label1:
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Choose one of the following");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle width");
            Console.WriteLine("5. Get Rectangle perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");

            int opt1 = 9;
            try
            {
                opt1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("please enter a valid numeric value");
                goto label1;
            }
            
            Console.WriteLine("your choice is: "+opt1);
            
            switch (opt1)
            {
                case 1:
                    Console.WriteLine("The rectangle length is: "+l);
                    Console.WriteLine();
                    goto label1;
                    break;

                case 2:
                    Console.WriteLine("please enter the lenght: ");
                    labelL:
                    try
                    {
                        l = Convert.ToDouble(Console.ReadLine());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("please enter a valid numeric value");
                        goto labelL;
                    }
                    Console.WriteLine("the new width is: " + l);
                    goto label1;
                    break;
                case 3:
                    Console.WriteLine("The rectangle width is: "+w);
                    goto label1;

                    break;
                case 4:
                    Console.WriteLine("PLease enter the width: ");
                   labelW:
                    try { 
                        w = Convert.ToDouble(Console.ReadLine()); 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("please enter a valid numeric value");
                        goto labelW;
                    }
                    Console.WriteLine("the new width is: " + w);
                    goto label1;
                    break;
                case 5:
                    Console.WriteLine("The perimeter of the rectangle is: "+cal.Perimeter(l,w));
                    goto label1;
                    break;
                case 6:
                    Console.WriteLine("The Area of the rectangle is: "+cal.Area(l,w));
                    goto label1;
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("please enter a valid option in the range 1 to 7");
                    goto label1;

            }
        }

    }
}
