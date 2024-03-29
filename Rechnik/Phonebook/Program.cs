namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            var command=Console.ReadLine().Split(' ').ToList();
            while (command[0]!="END")
            {
                if (command[0]=="A")
                {
                    string name = command[1];
                    string phone = command[2];
                    if (dic.ContainsKey(name))
                    {
                        dic[name] = phone;
                    }
                    else
                    {
                        dic.Add(name, phone);
                    }
                }
                if (command[0]=="S")
                {
                    string name = command[1];
                   
                    if (dic.ContainsKey(name))
                    {
                        Console.WriteLine($"{name}->{dic[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}