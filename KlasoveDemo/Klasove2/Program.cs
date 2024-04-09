namespace Klasove2
{
    public class Program
    {
        static void Main(string[] args)
        {
          Dictionary<int,BankAccount> banka = new Dictionary<int,BankAccount>();
          var command=Console.ReadLine().Split(' ').ToList();
            while (command[0]!="End")
            {
                if (command[0]=="Create")
                {
                    int id = int.Parse(command[1]);
                    if (banka.ContainsKey(id))
                    {
                        Console.WriteLine("Account already exists");
                    }else
                    {
                        BankAccount account = new BankAccount();
                        account.Id = id;
                        banka.Add(id,account);
                    }
                }
                if (command[0]== "Deposit")
                {
                    int id = int.Parse(command[1]);
                    double amount = double.Parse(command[2]);
                    if (!banka.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }else
                    {
                        banka[id].Deposit(amount);
                    }
                    
                }
                if (command[0]== "Withdraw")
                {
                    int id = int.Parse(command[1]);
                    double amount = double.Parse(command[2]);
                    if (!banka.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        if (banka[id].Balance<amount)
                        {
                            Console.WriteLine("Insufficient balance");
                        }else
                        {
                            banka[id].Withdraw(amount);
                        }
                        
                    }
                }
                if (command[0]=="Print")
                {
                    int id = int.Parse(command[1]);
                    if (!banka.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }else
                    {
                        Console.WriteLine(banka[id].ToString()); 
                    }
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
               
            
        }
    }
}
