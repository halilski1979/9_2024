namespace _5w_4_Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
           double total = 0;

            while (n>0)
            {
                Console.Write("Increase: ");
                double money = double.Parse(Console.ReadLine());
                n--;
                total+= money;
            }
            Console.WriteLine($"Total money: {total}");
        }
    }
}