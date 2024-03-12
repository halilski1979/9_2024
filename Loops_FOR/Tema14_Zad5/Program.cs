namespace Tema14_Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());

            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
           

            
            for (int i = 0; i < n; i++)         
            {
                int num = int.Parse(Console.ReadLine());

                if (num%2==0)
                {
                    count1++;
                }
                if (num%3==0)
                {
                    count2++;
                }
                 if (num%4==0)
                {
                    count3++;
                }
                
            }

            Console.WriteLine($"{((count1/n)*100):f2}%");
            Console.WriteLine($"{((count2 / n) * 100):f2}%");
            Console.WriteLine($"{(count3 / n) * 100:f2}%");
            


        }
    }
}