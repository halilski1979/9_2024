namespace Tema14_Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (max<num)
                {
                    max= num;
                }
            }
            
            if (sum-max==max)
            {
                Console.WriteLine("Yes!");
                Console.WriteLine($"Sum={max}");
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine($"Diff={Math.Abs(max-(sum-max))}");
            }
           
            
        }
    }
}