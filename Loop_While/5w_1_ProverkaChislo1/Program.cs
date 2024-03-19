namespace _5w_1_ProverkaChislo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която въвежда цяло положително число n в диапазона[1…100].При въвеждане на число извън посочения диапазон, да се отпечата съобщение за грешка и да се въведе ново число.

            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n>0 && n<100)
                {
                    Console.WriteLine($"The number is {n}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number");
                    n = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}