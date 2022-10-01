using System;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int lengthOfSide = 0;
            

            Console.Write("Enter a length of adjacent side: ");
            int.TryParse(Console.ReadLine(), out lengthOfSide);

            for (int i = 0; i <= lengthOfSide; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < lengthOfSide; i++)
            {
                for (int j = lengthOfSide; j > i; j--)
                {
                    Console.Write("@");

                }
                Console.WriteLine(); 
            }
            Console.WriteLine();
            Console.WriteLine();
            
            for (int i = 0; i <= lengthOfSide; i++)

            {

                for (int j = lengthOfSide; j > i; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("@");
                }
                
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i <= lengthOfSide; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = lengthOfSide; j > i; j--)
                {
                    Console.Write("@");

                }
                Console.WriteLine();


            }



            }




        }




    }




