namespace Miniory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name=="stop")
                {
                    break;
                }
                double quantity = double.Parse(Console.ReadLine());
                if (dict.ContainsKey(name))
                {
                    dict[name] += quantity;
                }
                else
                {
                    dict.Add(name, quantity);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}