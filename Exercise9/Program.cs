class Exercise9
{
    static void Main()
    {
        bool errorCatch;
        int length;
        Console.Write("Please enter the length of your array: ");
        errorCatch=int.TryParse(Console.ReadLine(), out length);
        int[] nums=new int[length];

        Console.WriteLine("\nPlease enter the elements to be stored in your array:");

        for(int i=0; i<length; i++)
        {
            errorCatch=int.TryParse(Console.ReadLine(), out nums[i]);
        }

        SortArray(nums,length);

    }

    static void SortArray(int[] nums,int length)
    {
        int temp, index=0;

        for(int i = length-1; i >=0; i--)
        {
            int max = 0;
            for (int j = 0; j < i; j++)
            {
                if (nums[j] > max)
                {
                    index = j;
                    max = nums[j];
                }
            }

            temp = nums[i];
            nums[i]=nums[index]; 
            nums[index]=temp;
        }

        Console.Write("\n\nThe sorted array in descending order is: [ {0}",nums[length-1]);

        for(int i = length-2; i >=0; i--)
        {
            Console.Write(", "+nums[i]);
        }
        Console.Write(" ]");
    }
}