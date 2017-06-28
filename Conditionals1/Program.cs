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


            /*
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
            */

            //Console.WriteLine("Welcome to the Age Distribution Center. This program will determine how useful you are to society.");
            //Console.WriteLine("Please enter your age:");

            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 2)
            //{
            //    Console.WriteLine("You are Still in Mama's Arms and therefore useless");
            //}
            //else if (age >= 3 && age <= 4)
            //{
            //    Console.WriteLine("You are a Preschool Maniac");
            //}
            //else if (age >= 5 && age <= 11)
            //{
            //    Console.WriteLine("You are in Elementary School and are a nuisance to others");
            //}
            //else if (age >= 12 && age <= 14)
            //{
            //    Console.WriteLine("You are in Middle School and are a mischevious miscreant");
            //}
            //else if (age >= 15 && age <= 18)
            //{
            //    Console.WriteLine("You are in High School and no one wants to deal with you.");
            //}
            //else if (age >= 19 && age <= 22)
            //{
            //    Console.WriteLine("You are in College. Good luck!");
            //}
            //else if (age >= 23 && age <= 65)
            //{
            //    Console.WriteLine("You are Working for the Man... FOREVER! Maybe consider going to We Can Code IT");
            //}
            //else if (age >= 66 && age <= 100)
            //{
            //    Console.WriteLine("You are in the 'Golden Years'");
            //}
            //else
            //{
            //    Console.WriteLine("You are either extremely old or an extraterrestrial, this program is for humans.");
            //}

            //Switch Case Exercise

            Console.WriteLine("Please type out any number: ");
            string wordNumber = (Console.ReadLine());

            switch (wordNumber)
            {
                case "Zero":
                    Console.WriteLine("0");
                    break;
                case "One":
                    Console.WriteLine("1");
                    break;
                case "Two":
                    Console.WriteLine("2");
                    break;
                case "Three":
                    Console.WriteLine("3");
                    break;
                case "Four":
                    Console.WriteLine("4");
                    break;
                case "Five":
                    Console.WriteLine("5");
                    break;
                case "Six":
                    Console.WriteLine("6");
                    break;
                case "Seven":
                    Console.WriteLine("7");
                    break;
                case "Eight":
                    Console.WriteLine("8");
                    break;
                case "Nine":
                    Console.WriteLine("9");
                    break;
                case "Ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Nope");
                    break;
            }
        }



    }
}
