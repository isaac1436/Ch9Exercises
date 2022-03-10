class Exercise5_6
{
    static void Main()
    {
        bool errorCatch = false, idxErrorCatch;
        Random r = new Random();
        int[] nums = new int[30];
        int index, element;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = r.Next(0, 25);
        }

        Console.WriteLine("This is a test to show wether an element of an array is greater than the two beside it");

        while (errorCatch == false)
        {
            Console.Write("\n\nPlease enter a number between 1 and 29: ");
            idxErrorCatch = int.TryParse(Console.ReadLine(), out index);

            if (index >= 1 && index <= 29)
            {
                bool result = IsGreater(index, nums);
                if (result) { errorCatch = true; }
            }

            else
            {
                Console.WriteLine("Invalid value entered");
            }
        }

        errorCatch = false;

        while (errorCatch == false)
        {
            Console.Write("\n\nPlease enter a number between 0 and 25: ");
            idxErrorCatch = int.TryParse(Console.ReadLine(), out element);

            if (element >= 0 && element <= 25)
            {
                bool result = firstGreaterOccurence(element, nums);
                if (result) { errorCatch = true; }
                else { Console.WriteLine("\n\nThere were no occurences that met the criteria hence the result is: -1"); }
            }

            else
            {
                Console.WriteLine("Invalid value entered");
            }
        }
    }
    static bool IsGreater(int index, int[] nums)
    {
        bool isGreater = false;

        if ((nums[index] > nums[index + 1]) && (nums[index] > nums[index - 1]))
        {
            Console.WriteLine("\n\nThe element stored in index {0} ({1}), is greater than both {2} and {3} which " +
                "are stored in index {4} , {5} respectively", index, nums[index], nums[index - 1], nums[index + 1], index - 1, index + 1);
            isGreater = true;
        }

        else
        {
            Console.WriteLine("\n\nThe element stored in index {0} ({1}), is not greater than {2} and {3} which " +
                "are stored in index {4} , {5} respectively", index, nums[index], nums[index - 1], nums[index + 1], index - 1, index + 1);
            isGreater = false;
        }

        return isGreater;
    }

    static bool firstGreaterOccurence(int element, int[] nums)
    {
        bool firstGreaterOccurence = false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == element)
            {
                if ((element > nums[i + 1]) && (element > nums[i - 1]))
                {
                    Console.WriteLine("\n\nThe first occurence of {0} that is greater than both elements at its sides, has an index position of {1}", element, i);
                    firstGreaterOccurence = true;
                }
            }
        }
        return firstGreaterOccurence;
    }
}