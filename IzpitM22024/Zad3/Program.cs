namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word=Console.ReadLine();
            string buf = string.Empty;
            Dictionary<string,string> dic = new Dictionary<string,string>();
            while (word!= "end")
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    buf += word[i];
                }
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, buf);
                }
                buf=string.Empty;
                word = Console.ReadLine();
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}