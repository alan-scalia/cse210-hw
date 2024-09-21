using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int actualNumber = 0;
        int sum = 0;
        int largest = 0;
        int smallest = 0;
        float average;
        List<int> inputList = new List<int>();
        List<int> orderedList = new List<int>();

        do{ 
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            actualNumber = int.Parse(input);
            if (actualNumber != 0)
            {
                inputList.Add(actualNumber);
            }
            
            if (sum == 0)
            {   
                largest = actualNumber;
                smallest = actualNumber;
            }
            else if (actualNumber > largest)
            {
                largest = actualNumber;
            }
            else if (actualNumber < smallest)
            {
                if (actualNumber > 0)
                {
                smallest = actualNumber;
                }
            }

            sum = sum + actualNumber;
            

        } while (actualNumber != 0);


        for (int i = 0; i < inputList.Count; i++)
        {
            for (int j = 0; j < inputList.Count; j++)
            {
                int orderNum = 0;
                if (inputList[j] >= inputList[i])
                {
                    orderNum = inputList[i];
                    inputList[i] = inputList[j];
                    inputList[j] = orderNum;
                }
            }
        }

        Console.WriteLine("Ordered list");
        foreach (int num in inputList)
        {
            Console.WriteLine(num);
        }
        
        average = (float)sum / (inputList.Count);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        
    }
}