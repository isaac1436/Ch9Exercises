class Exercise10
{
    static void Main()
    {
        ////Task 1
        bool errorCatch;
        //int num;
        //Console.Write("Please enter a number: ");
        //errorCatch = int.TryParse(Console.ReadLine(), out num);
        //ReverseInt(num);

        ////Task 2
        //int length;
        //Console.Write("\nPlease enter the number of numbers you'll be calculating an average for: ");
        //errorCatch = int.TryParse(Console.ReadLine(), out length);
        //int[] nums = new int[length];

        //Console.WriteLine("\nPlease enter the numbers you're calculating an average of:");

        //for (int i = 0; i < length; i++)
        //{
        //    errorCatch = int.TryParse(Console.ReadLine(), out nums[i]);
        //}
        //Console.WriteLine("\nThe average of the numbers entered is {0}", AverageOf(nums, length));

        //Task3
        double a, b;
        Console.WriteLine("\nThis is a program to solve for \'x\' in the equation \" ax + b = 0 \"");
        Console.Write("Please enter the value of \'a\' which is the co-efficient of \'x\': ");
        errorCatch = double.TryParse(Console.ReadLine(), out a);
        Console.Write("\nPlease enter the value of the constant \'b\': ");
        errorCatch = double.TryParse(Console.ReadLine(), out b);

        Console.WriteLine("\nThe value of \'x\' is {0}", linEqtn(a, b));

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
        x = (-b) / a;
        return x;
    }
}