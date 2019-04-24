using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wave = 1;

            while (Wave == 1)
            {
                Console.WriteLine("Enter Length: ");
                String input = Console.ReadLine();
                Double theLength = double.Parse(input);
                Console.WriteLine("Enter Width: ");
                String inputW = Console.ReadLine();
                Double theWidth = double.Parse(inputW);
                double area = theLength * theWidth;
                Console.WriteLine("Area: " + area);
                double perimeter = (theLength * 2) + (theWidth * 2);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Continue? Yes or No");
                Wave++;
                string yes = null;
                yes = Console.ReadLine();
                if (yes == "Yes")
                {
                    Wave--;
                }
                if (yes == "No")
                {
                    Console.WriteLine("Hope You Have A Good Day!");
                }
            }



        }
    }

}
 
