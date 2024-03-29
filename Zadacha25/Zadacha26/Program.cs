namespace Zadacha26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listWords = new List<string>();
            var command=Console.ReadLine().Split(' ').ToList();
            while (command[0]!="END")
            {
                if (command[0]=="Add")
                {
                    for (int i = 1; i < command.Count; i++)
                    {
                        listWords.Add(command[i]);
                    }
                }
                if (command[0]== "Update")
                {
                    for (int i = 0; i < listWords.Count; i++)
                    {
                        var word = listWords[i];
                        if (char.IsLetter(word[0]))
                        {
                            listWords[i] = char.ToUpper(word[0]).ToString() + word.Substring(1);
                        }
                    }
                }
                if (command[0]== "Remove")
                {
                    int position = int.Parse(command[1]);
                    listWords.RemoveAt(position);
                }
                if (command[0] == "Search")
                {
                    string word = command[1];
                    if (listWords.Contains(word))
                    {
                        Console.WriteLine(word);
                    }
                    else
                    {
                        Console.WriteLine("Not Contained");
                    }
                }
                if (command[0] == "Length")
                {
                    int n = int.Parse(command[1]);
                    var search = listWords.Where(x => x.Length == n).ToList();
                    if (search.Count>0)
                    {
                        Console.WriteLine(string.Join("-",search));
                    }
                    else
                    {
                        Console.WriteLine("Not conteined");
                    }
                }
                if (command[0]=="Insert")
                {
                    int position = int.Parse(command[1]);
                    string word = command[2];
                    if (position>=0&&position<=listWords.Count-1)
                    {
                        listWords.Insert(position, word);
                    }
                    else
                    {
                        Console.WriteLine("There are not enoth item in list");
                    }
                  
                }
                if (command[0]=="Print")
                {
                    Console.WriteLine(string.Join("; ", listWords));
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}