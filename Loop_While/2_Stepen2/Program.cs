namespace _2_Stepen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int i = 1;
           while (n>=i) 
            {
                Console.WriteLine($"{i}^2={i*i}");
                i++;
            }
          
        }
    }
}
