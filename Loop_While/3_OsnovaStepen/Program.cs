namespace _3_OsnovaStepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Osnova: ");
            int osn = int.Parse(Console.ReadLine());

            Console.Write("Stepen: ");
            int n = int.Parse(Console.ReadLine());
            int p = osn;
            int st = 2;

            Console.WriteLine($"{osn}^0=1;");
            Console.WriteLine($"{osn}^{1}={osn};");
            while (st<=n) 
            {
                p = p * osn;
                Console.WriteLine($"{osn}^{st}={p};");
                st++;
            }
        }
    }
}
