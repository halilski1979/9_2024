namespace _09_SborChetni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сбор на четни числа от 1 до n
            int s = 0;
            int n=int.Parse(Console.ReadLine());    
            
            for (int i = 1; i < n; i++)
            {
                if (i%2==0)
                {
                    s += i;
                    Console.WriteLine(i);                  
                }
            }

            Console.WriteLine($"sum={s}");
        }
    }
}