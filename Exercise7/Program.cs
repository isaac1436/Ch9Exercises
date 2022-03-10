class Exercise7
{
    static void Main()
    {
        bool errorCatch;
        int num;
        Console.Write("\nPlease enter a number: ");
        errorCatch = int.TryParse(Console.ReadLine(), out num);
        ReverseInt(num);
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
}