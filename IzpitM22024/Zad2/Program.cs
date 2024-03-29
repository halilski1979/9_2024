namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list =Console.ReadLine().Split(new string[] {","," " },StringSplitOptions.RemoveEmptyEntries).ToList();
            string command=Console.ReadLine();
            while (command!="END")
            {
                if (command== "Add visitor")
                {
                    string name = Console.ReadLine();
                    list.Add(name);
                }
                if (command== "Add visitor on position")
                {
                    string name = Console.ReadLine();
                    int position=int.Parse(Console.ReadLine());
                    list.Insert(position, name);
                }
                if (command== "Remove visitor on position")
                {
                    int position = int.Parse(Console.ReadLine());
                    list.RemoveAt(position);
                }
                if (command== "Remove last visitor")
                {
                    list.Remove(list.Last());
                }
                if (command== "Remove first visitor")
                {
                    list.RemoveAt(0);
                }
                command = Console.ReadLine();
            }//end while
            Console.WriteLine(string.Join(" ",list));
        }
    }
}