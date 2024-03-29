namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words=Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string,int> map = new Dictionary<string,int>();
            foreach (var word in words)
            {
                if (map.ContainsKey(word))
                {
                    map[word]++;
                }
                else
                {
                     map.Add(word, 1);
                }
            }//end 
            var result=map.Where(x=>x.Value%2!=0).ToDictionary(x=>x.Key,y=>y.Value);
            foreach (var item in result)
            {
                Console.Write($"{item.Key} ");
            }
        }
    }
}