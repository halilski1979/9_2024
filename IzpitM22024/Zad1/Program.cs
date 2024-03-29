namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double surface = 1300;
            double net = 3200;
            double ball = 10;
            double sum = 0;
            for (int i = 0; i < numbers; i++)
            {
                string articul = Console.ReadLine();
                if (articul== "surface")
                {
                    sum += surface;
                }
                else if (articul=="net")
                {
                    sum += net;
                }
                else if (articul=="ball")
                {
                    sum += ball;
                }
            }
            Console.WriteLine($"sum:f2");
        }
    }
}