using System;

namespace Homework
{
    class SimpleCalc
    {
        static void Main(string[] args)
        {
            double firstNum = 0d;
            double secondNum = 0d;
            string input;
            double result = 0d;
            bool breaker = true;

            Console.Write("Enter a first number: ");
            input = Console.ReadLine();
            double.TryParse(input, out firstNum);
            Console.Write("Enter a second number: ");
            input = Console.ReadLine();
            double.TryParse(input, out secondNum);
            Console.Write("Choose the option(+,-,*,/): ");
            input = Console.ReadLine();

            switch (input)
            {
                case "+":
                    result = firstNum + secondNum;
                    Console.WriteLine($"The sum of the numbers is: {result}");
                    break;
                case "-":
                    result = firstNum - secondNum;
                    Console.WriteLine($"The difference of the numbers is: {result}");
                    break;
                case "*":
                    result = firstNum * secondNum;
                    Console.WriteLine($"The product of the numbers is: {result}");
                    break;
                case "/":
                    result = firstNum / secondNum;
                    Console.WriteLine($"The quotient of the numbers is: {result}");
                    break;
                default:
                    Console.WriteLine("Unknown operation, try again");
                    break;
            }
            while (breaker)
            {
                Console.WriteLine("Continue operations with the result? (Enter \"y\" to continue and \"n\" to stop)");
                input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        {

                            Console.WriteLine("Enter a second number: ");
                            input = Console.ReadLine();
                            double.TryParse(input, out secondNum);
                            Console.Write("Choose the option(+,-,*,/): ");
                            input = Console.ReadLine();
                            switch (input)
                            {
                                case "+":
                                    result += secondNum;
                                    Console.WriteLine($"The sum of the numbers is: {result}");
                                    break;
                                case "-":
                                    result -= secondNum;
                                    Console.WriteLine($"The difference of the numbers is: {result}");
                                    break;
                                case "*":
                                    result *= secondNum;
                                    Console.WriteLine($"The product of the numbers is: {result}");
                                    break;
                                case "/":
                                    result /= secondNum;
                                    Console.WriteLine($"The quotient of the numbers is: {result}");
                                    break;
                                default:
                                    Console.WriteLine("Unknown operation, try again");
                                    break;
                            }
                            break;
                        }
                    case "n":
                        breaker = false;
                        break;


                }
                
            }
        }



    }

}





