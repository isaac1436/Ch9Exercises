﻿class Exercise2
{
    static void Main()
    {
        bool errorCatch;
        Random r=new Random();
        int num1=r.Next(0,100), num2=r.Next(0,100),num3;
        Console.WriteLine("The maximum value between {0} and {1} is {2} ",num1,num2,GetMax(num1, num2));


        Console.Write("Today we'll be finding the maximum value of a list of 3 numbers you will be prompted to enter");
        Console.Write("\n\nEnter the 1st number: ");
        errorCatch=int.TryParse(Console.ReadLine(), out num1);

        Console.Write("\n\nEnter the 2nd number: ");
        errorCatch = int.TryParse(Console.ReadLine(), out num2);

        Console.Write("\n\nEnter the 3rd number: ");
        errorCatch = int.TryParse(Console.ReadLine(), out num3);

        if (errorCatch)
        {
            int maxNum = GetMax(num1, num2, num3);
            Console.WriteLine("\n\nThe maximum number in the list is {0}", maxNum);
        }

        else
        {
            Console.WriteLine("\n\nOne of the values entered does not meet the requirements" +
                "\nPlease try Again Later");
        }
        
    }

    static int GetMax(int num1, int num2, int num3 = int.MinValue)
    {
        int max = int.MinValue;
        if (num1 > max)
        {
            max = num1;
        }

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }


        return max;
    }
}