using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitProblem.Fruit;
using FruitProblem.Basket;
using FruitProblem.Interfaces;
using FruitProblem.Utilities;

namespace FruitProblem
{
    class Program
    {
        private const int _maxInBasket = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Thank you for shopping Mark's console-app fruit store!");
            Console.WriteLine(String.Format("Our not-so-online basket will hold {0} items; let's get started!", _maxInBasket));

            Console.WriteLine(String.Empty);

            bool userIsDone = false;
            FruitBasket basket = new FruitBasket();

            while (userIsDone != true)
            {
                try
                {
                    Console.WriteLine("Please indicate how many of each item you'd like to purchase and press enter to continue:");
                    Console.WriteLine(String.Empty);

                    IFruit fruit = Apple.Create();
                    ReadRespond(basket, fruit, "Apples");

                    if (basket.Count < _maxInBasket)
                    {
                        fruit = Banana.Create();
                        ReadRespond(basket, fruit, "Bananas");
                    }

                    if (basket.Count < _maxInBasket)
                    {
                        fruit = Grape.Create();
                        ReadRespond(basket, fruit, "Grapes");
                    }

                    if (basket.Count < _maxInBasket)
                    {
                        fruit = Orange.Create();
                        ReadRespond(basket, fruit, "Oranges");
                    }

                    if (basket.Count < _maxInBasket)
                    {
                        fruit = Pear.Create();
                        ReadRespond(basket, fruit, "Pears");
                    }

                    if (basket.Count < _maxInBasket)
                    {
                        bool responseIsUnderstood = false;

                        while (responseIsUnderstood != true)
                        {
                            Console.WriteLine("There's still room in your basket, would you like to add more fruit?");
                            Console.WriteLine("Enter Yes (Y) or No (N) and press by enter to respond.");

                            string response = Console.ReadLine();

                            if (response.Length <= 1)
                            {
                                switch (response.ToLower())
                                {
                                    case "y":
                                        userIsDone = false;
                                        responseIsUnderstood = true;
                                        break;

                                    case "n":
                                        userIsDone = true;
                                        responseIsUnderstood = true;
                                        break;

                                    default:
                                        Console.WriteLine(String.Empty);
                                        Console.WriteLine("I'm sorry, I didn't understand your response; let's try again.");
                                        Console.WriteLine(String.Empty);

                                        userIsDone = false;
                                        responseIsUnderstood = false;
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        userIsDone = true;

                        Console.WriteLine(String.Format("The total cost of your order is ${0}", basket.TotalCost));
                        Console.WriteLine(String.Format("The total weight of your order is {0}lbs", basket.TotalWeight));

                        Console.WriteLine(String.Empty);
                        Console.WriteLine("Thank you for your purchase, press any key to exit.");
                        Console.ReadLine();
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Sorry, something unexpected happened. Let's start this over again!");
                    Console.WriteLine(String.Empty);

                    basket = new FruitBasket();
                }
            }
        }

        private static void ReadRespond(FruitBasket basket, IFruit fruitToAdd, string fruitName)
        {
            bool valueReceived = false;

            while(valueReceived != true)
            {
                Console.Write(String.Format("{0}:  ", fruitName));
                string value = Console.ReadLine();

                if (value.IsNumeric() == true)
                {
                    int processedValue = value.ToInt();

                    int spaceLeft = _maxInBasket - basket.Count;
                    int updatedBasket = basket.Count + processedValue;

                    if (updatedBasket > _maxInBasket)
                    {
                        Console.WriteLine(String.Empty);
                        Console.WriteLine(String.Format("I'm sorry, our basket will only hold {0} items; please try again. You can select up to {1} more items.", _maxInBasket, spaceLeft));
                        Console.WriteLine(String.Empty);
                    }
                    else
                    {
                        valueReceived = true;

                        if (processedValue > 0)
                        {
                            basket.Add(fruitToAdd, processedValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(String.Empty);
                    Console.WriteLine("I'm sorry, I didn't understand your response; please try again using only numbers.");
                    Console.WriteLine(String.Empty);
                }
            }
        }
    }
}
