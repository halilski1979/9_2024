namespace _5w_2_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User: ");
            string user=Console.ReadLine();
            Console.Write("Password: ");
            string password=Console.ReadLine();
            int counter = 0;

            Console.Write("Please, insert your password: ");
            string password2 = Console.ReadLine();
            while (true)
            {
                if (password == password2)
                {
                    Console.WriteLine($"Welcome, {user}");
                    break;
                }
                else
                {
                    Console.Write($"Wrong password! Insert new: ");
                    password2 = Console.ReadLine();
                    counter++;
                }
                if (counter==3)
                {
                    Console.WriteLine($"Your profile is stoped!");
                    break;
                }
            }
            
            
            
           
        }
    }
}