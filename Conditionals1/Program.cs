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
            /*
            Console.WriteLine("please type out any number: ");
            string wordnumber = (Console.ReadLine());

            switch (wordnumber)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("nope");
                    break;
                    */

            //Fizz Buzz Problem

            Console.WriteLine("When prompted, please enter a test number followed by two numbers between 1 and 9");

            Console.Write("Test Number: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.Write("First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (number % firstNumber == 0 && number % secondNumber == 0)
            {
                Console.WriteLine("FizzBuzz!");
            }
            else if (number % firstNumber == 0 && number % secondNumber != 0)
            {
                Console.WriteLine("Fizz!");
            }
            else if (number % firstNumber != 0 && number % secondNumber == 0)
            {
                Console.WriteLine("Buzz!");
            }
            else 
            {
                Console.WriteLine(number);
            }
            

            }
        }



    }
