namespace _05_PrintAlphabet_ASSCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <='Z'; i++)
            {
                Console.WriteLine($"{i} => {(int)i}");
            }
        }
    }
}