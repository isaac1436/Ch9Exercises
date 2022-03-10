class Exercise4
{

    //A program to find the modal value in an array
    static void Main()
    {
        bool errorCatch;
        Console.Write("Please enter the length of your array: ");
        errorCatch = int.TryParse(Console.ReadLine(),out int length);

        Console.WriteLine("\n\nPlease enter an array of integers: ");
        int[] ints = new int[length];

        //A for loop to collect user input, with an inbuilt condition that will make sure that all values that enter the array are integers
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

        //by using a double for loop and two arrays, we can run a single value against the rest of the array and ensure better results
        for (int i = 0; i < length - 1; i++)
        {
            int tempVal = 0;

            //By initializing j to the value of i, we've eliminated the probability of repititive counting 
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