namespace Narcissistic_Number
{
    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            int result = 0;
            int additionalValue = value;

            while (additionalValue > 0)
            {
                result += (int)Math.Pow(additionalValue % 10, value.ToString().Length);
                additionalValue /= 10;
            }
            return result == value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(Kata.Narcissistic(153));
        }
    }
}
