namespace P03_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = NewMax();
            int y = NewMax();

            Console.WriteLine(x+y);
        }

        public static void Max()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        public static int NewMax()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());     
            
            return Math.Max(a, b);           
        }
    }
}
