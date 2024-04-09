namespace _15_2_NaStepen_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Osnova: ");
            int osn=int.Parse(Console.ReadLine());
            
            Console.Write("Stepen: ");
            int n=int.Parse(Console.ReadLine());

            int p = osn;
            for (int i = 0; i <= n; i++) 
            { 
              if (i == 0)
                {
                    Console.WriteLine($"{osn}^{i}=1;");
                }
              if (i == 1) 
                {
                    
                    Console.WriteLine($"{osn}^{i}={osn};");
                }
                if (i>1)
                {
                    p = p * osn;
                    Console.WriteLine($"{osn}^{i}={p};");
                }           
                          
               
               
            }
        }
    }
}
