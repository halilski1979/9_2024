namespace P02_Umnojenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Umnojenie();
           
            
            double p=Umnojenie1();
            Console.WriteLine(p);
        }

        public static void Umnojenie()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}*{b}={a * b}");
        }

        public static double Umnojenie1()
        {

            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            return a * b;
        }
    }
}
