using System.Numerics;
class Exercise10
{
    static void Main()
    {
        bool errorCatch = false;
        bool valueCheck;
        int num=0;
        BigInteger factorial;

        while (errorCatch == false)
        {
            Console.Write("Please enter a value between 1 and 100: ");
            valueCheck = int.TryParse(Console.ReadLine(), out num);
            if ((num >= 1) && (num <= 100))
            {
                Console.WriteLine("\nThe factorial of {0} is {1}", num, GetFactorial(num));
                errorCatch = true;
            }

            else { errorCatch = false; }
        }
        
    }

    static BigInteger GetFactorial(int num)
    {
        BigInteger factorial = 1;
        
        while(num > 0)
        {
            factorial *= num;
            num--;
        }

        return factorial;
    }
}