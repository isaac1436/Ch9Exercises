class Exercise5
{
    static void Main()
    {
        bool errorCatch = false, idxErrorCatch;
        Random r = new Random();
        int[] nums = new int[30];
        int index;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = r.Next(-1000, 1000);
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
}