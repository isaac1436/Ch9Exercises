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
            Console.WriteLine("\n\nThe last digit in {0} is {1} ", num, PrintLastDigit(num));//a typical example of calling a method within another method
        }

        else
        {
            Console.WriteLine("\n\nThe number entered is invalid");
        }
    }

    //A method to print out the last digit in a number in words
    static string PrintLastDigit(int num)
    {
        int lastDigit;//an integer to hold the last digit
        string lastDigitw;//a string to hold the last digit in words
        Math.DivRem(num,10,out lastDigit);//using the DIvRem Function we can easily get the last digit

        //Using the switch statement we can also translate the lat digit to a word
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