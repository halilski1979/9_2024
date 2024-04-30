namespace P01_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum();
            Console.WriteLine(NewSum());
        }

        public static void Sum()
        {
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}+{b}={a+b}");
        }

        public static int NewSum()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            return a + b;

        }
    }
}
