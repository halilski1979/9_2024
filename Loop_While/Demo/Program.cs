namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
            
            while (true)
            {
               var comand = Console.ReadLine();
               Console.WriteLine($"Komandata e =>: {comand}");
                if (comand=="end")
                {
                    break;
                }
            }


        }
    }
}