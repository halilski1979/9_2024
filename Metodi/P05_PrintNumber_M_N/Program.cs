namespace P05_PrintNumber_M_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
            Console.WriteLine(SumMN());
            Even();
        }

        public static void Print()
        {
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++) 
            {
                Console.WriteLine(i);
            }
        }
        public static int SumMN()
        {
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = m; i <= n; i++)
            {
                s += i;
            }
            return s;
        }
        public static void Even()
        {
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = m; i <= n; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }               
            }
        }
    }
}
