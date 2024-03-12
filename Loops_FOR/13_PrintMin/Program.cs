namespace _13_PrintMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Min = {min}");
        }
    }
}