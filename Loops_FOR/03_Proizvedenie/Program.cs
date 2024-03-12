namespace _03_Proizvedenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            for (int i = 1; i <= 5; i++)
            {
                p = p * i;
            }
            Console.WriteLine(p);
        }
    }
}