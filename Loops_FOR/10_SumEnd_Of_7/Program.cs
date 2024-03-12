namespace _10_SumEnd_Of_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сума на числа, завършващи на 7
            int s = 0;
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                    s += i;
                }
            }

            Console.WriteLine($"s={s}");
        }
    }
}