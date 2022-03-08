class Exercise4
{
    static void Main()
    {
        bool errorCatch;
        Console.Write("Please enter the length of your array: ");
        errorCatch = int.TryParse(Console.ReadLine(),out int length);

        Console.WriteLine("\n\nPlease enter an array of integers: ");
        int[] ints = new int[length];

        for (int i = 0; i < length;)
        {
            errorCatch = int.TryParse(Console.ReadLine(),out ints[i]);

            if (errorCatch) { i++; }

            else
            {
                Console.WriteLine("\n\nInvalid Value entered, Please try Again!!!\n\n");
            }
        }

        Console.WriteLine("The modal value in the array is " + modalValue(length, ints));

    }

    static int modalValue(int length, int[] nums)
    {
        int mode=0;
        int count = 0;
        int[] ints2 = nums;

        for (int i = 0; i < length - 1; i++)
        {
            int tempVal = 0;
            for (int j = i; j < length; j++)
            {
                if (nums[i] == ints2[j])
                {
                    tempVal++;
                }
            }

            if (count < tempVal)
            {
                count=tempVal;
                mode=nums[i];
            }
        }

        return mode;
    }
}