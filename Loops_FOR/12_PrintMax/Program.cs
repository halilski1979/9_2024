namespace _12_PrintMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Да се напише програма, която чете n-на брой цели числа, и отпечатва най-голямото

            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (max<num)
                {
                    max = num;
                }
            }

            Console.WriteLine($"Max={max}");


        }
    }
}