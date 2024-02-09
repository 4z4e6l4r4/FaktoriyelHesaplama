namespace FaktoriyelHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            Console.WriteLine("Sonuc1: " +faktoriyeFunction(n));
            Console.WriteLine("Sonuc2: " +faktoriyeFunction2(n));
        }

        static long faktoriyeFunction(int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static long faktoriyeFunction2(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * faktoriyeFunction2(number - 1);
            }
        }
    }
}