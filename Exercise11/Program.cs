class Exercise11
{
    static void Main()
    {
        bool errorCatch;
        int num, choice;

        Console.WriteLine("There are three tasks available");
        Console.WriteLine("1.\tTo print out an integer in reverse order");
        Console.WriteLine("\n2.\tTo calculate the average of a sequence of numbers");
        Console.WriteLine("\n3.\tTo solve the linear equation \" ax + b = 0 \"");

        Console.Write("\nPlease make a choice: ");
        errorCatch = int.TryParse(Console.ReadLine(), out choice);

        switch (choice)
        {

            case 1://Task 1
                Console.Write("Please enter a number: ");
                errorCatch = int.TryParse(Console.ReadLine(), out num);
                if (num >= 1 && num <= 50000000)
                {
                    ReverseInt(num);
                }
                else { Console.WriteLine("Invalid value entered. Please try again later"); }
                break;

            case 2://Task 2
                int length;
                Console.Write("\nPlease enter the number of numbers you'll be calculating an average for: ");
                errorCatch = int.TryParse(Console.ReadLine(), out length);
                int[] nums = new int[length];

                if (length > 1)
                {
                    Console.WriteLine("\nPlease enter the numbers you're calculating an average of:");

                    for (int i = 0; i < length; i++)
                    {
                        errorCatch = int.TryParse(Console.ReadLine(), out nums[i]);
                    }
                    Console.WriteLine("\nThe average of the numbers entered is {0}", AverageOf(nums, length));
                }

                else { Console.WriteLine("\nThe number of elements cannot be 0 or 1. Please try again later"); }
                break;

            case 3://Task3
                double a, b;
                Console.WriteLine("\nThis is a program to solve for \'x\' in the equation \" ax + b = 0 \"");
                Console.Write("\nPlease enter the value of \'a\' which is the co-efficient of \'x\': ");
                errorCatch = double.TryParse(Console.ReadLine(), out a);
                Console.Write("\nPlease enter the value of the constant \'b\': ");
                errorCatch = double.TryParse(Console.ReadLine(), out b);

                if (a != 0)
                {
                    Console.WriteLine("\nThe value of \'x\' is {0}", linEqtn(a, b));
                }

                else { Console.WriteLine("The co-efficient of \'a\' can not be 0. Please try again later"); }

                break;

            default:
                Console.WriteLine("Invalid value entered. Please try again later");
                break;
        }
    }

    static void ReverseInt(int num)
    {
        int[] digits = new int[32];
        int i = 0;
        int no = num;

        while (no > 0)
        {
            Math.DivRem(no, 10, out digits[i]);
            i++;
            no /= 10;
        }

        Console.Write("\n\n{0} in reverse is ", num);

        for (int j = 0; j < i; j++)
        {
            Console.Write(digits[j]);
        }
    }

    static double AverageOf(int[] nums, int length)
    {
        double average = 0;
        for (int i = 0; i < length; i++)
        {
            average += nums[i];
        }
        average /= length;

        return average;
    }

    static double linEqtn(double a, double b)
    {
        double x;

        if (b < 0 ^ a < 0)
        {
            x = Math.Abs(b / a);
        }

        else
        {
            x = -1 * (b / a);
        }
        return x;
    }
}