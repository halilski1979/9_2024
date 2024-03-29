namespace _5w_5_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
           
            int max = int.MinValue;

            while (n>0)
            {
                int num=int.Parse(Console.ReadLine());
                n--;
                if (max<num)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);

        }
    }
}