class Exercise3
{
    static void Main()
    {
        bool errorCatch;
        int num;
        Console.Write("Please enter a number: ");
        errorCatch = int.TryParse(Console.ReadLine(), out num);

        if (errorCatch)
        {
            Console.WriteLine("\n\nThe last digit in {0} is {1} ", num, PrintLastDigit(num));
        }

        else
        {
            Console.WriteLine("\n\nThe number entered is invalid");
        }
    }

    static string PrintLastDigit(int num)
    {
        int lastDigit;
        string lastDigitw;
        Math.DivRem(num,10,out lastDigit);

        switch (lastDigit)
        {
            case 0:
                lastDigitw = "Zero";
                break;

            case 1:
                lastDigitw = "One";
                break;

            case 2:
                lastDigitw = "Two";
                break;

            case 3:
                lastDigitw = "Three";
                break;

            case 4:
                lastDigitw = "Four";
                break;

            case 5:
                lastDigitw = "Five";
                break;

            case 6:
                lastDigitw = "Six";
                break;

            case 7:
                lastDigitw = "Seven";
                break;

            case 8:
                lastDigitw = "Eight";
                break;

            case 9:
                lastDigitw = "Nine";
                break;

            default:
                lastDigitw = " ";
                break;
        }

        return lastDigitw;
    }
}