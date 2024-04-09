namespace _1_Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int p = 1;
            while (n>1) 
            { 
              p*=n;
                n--;
            }
            Console.WriteLine(p);
        }
    }
}
