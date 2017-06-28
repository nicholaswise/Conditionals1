using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals1
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Thank you for eating at RESTAURANT");
            
            //float in case of decimal total
            Console.WriteLine("What is the total bill?");
            float totalBill = float.Parse(Console.ReadLine());

            double discountTen = (totalBill - (totalBill * .10d));
            double discountFive = (totalBill - (totalBill * .05d));
            double billSplit; //billSplit = GLOBAL VARIABLE

            Console.WriteLine("How many people in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            if (totalBill >= 50)
            {

                Console.WriteLine("You get a 10% discount!");
                Console.WriteLine("Your total bill is: " + discountTen);
                billSplit = discountTen / numberOfPeople;
                Console.WriteLine("Each person in your party will pay $ " + billSplit);

            }


            else
            {
                Console.WriteLine("You get a 5% discount!");
                Console.WriteLine("Your total bill is: " + discountFive);
                billSplit = discountFive / numberOfPeople;
                Console.WriteLine("Each person in your party will pay $ " + billSplit);
            }
            
            

        }



    }
}
