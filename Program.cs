using System;
using System.Collections.Generic;

namespace My_Program
{
     class Program
    {

        public static object BinarySearch(int[]arr, int key)
        {
            int Minimum_Number = 0;
            int Maximum_Number = arr.Length - 1;

            while(Minimum_Number <= Maximum_Number)
            {
                int mid = (Minimum_Number + Maximum_Number) /2;
                Console.WriteLine("Our guess is: " + arr[mid]);
                Console.WriteLine("Is this correct? Please enter 'Yes' or 'No'.");
                string Guess_Validation_Prompt = Console.ReadLine();
                
                if(key == arr[mid] & Guess_Validation_Prompt == "No")
                {
                    Console.WriteLine("Don't give us that crap...");
                    Console.WriteLine("We know that was your number.");
                    Console.WriteLine("WE KNOW ALL...");
                    return null;

                }

                if(Guess_Validation_Prompt == "Yes")
                {
                     Console.WriteLine("Thank you for playing!");
                     return null;
                }
                
                else if (Guess_Validation_Prompt == "No")
                {
                    Console.WriteLine("Crap...");

                    if (key < arr[mid])
                    {
                        int Max = mid - 1;
                        Maximum_Number = Max;
                    }
                    
                    else
                    {
                        int Min = mid + 1;
                        Minimum_Number = Min; 
                    }
                }

  

            }
            return "None";

        }


        static void Main(string[] args)
        {

            int[] Arr = new int[100];
            
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i+1;
            }

            Console.WriteLine("Hello, Randy. I'd like to play a game.");
            Console.WriteLine("Please enter a number between 1-100 and I will guess the number in 10 tries or less");
            String key = Console.ReadLine();
            int New_Key = int.Parse(key);

            BinarySearch(Arr,New_Key);

        }
    }


}