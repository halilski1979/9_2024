namespace _11_SumN_Chilsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //1. Да се напише програма, която чете n-на брой цели числа, въведени от потребителя и ги сумира.
           //2. От първия ред на входа се въвежда броят числа n.
           //3. От следващите n реда се въвежда по едно цяло число.
           //4. Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им.

            int n=int.Parse(Console.ReadLine());
            int s = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());  
                s += num;
            }
            Console.WriteLine($"s={s}");
        }
    }
}