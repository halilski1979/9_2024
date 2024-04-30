namespace P04_SumParametar
{
    internal class Program
    {    

        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Sum(a,b);

            Console.WriteLine(NewSum(a,b));
        }


        //Метод с параметър
        public static void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }

        public static int NewSum(int a,int b)
        {
            return a + b;   
        }
    }
}
