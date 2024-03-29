namespace Odd_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list =Console.ReadLine().ToLower().Split(' ').ToList();
           Dictionary<string,int> dict = new Dictionary<string,int>();
            foreach (string word in list)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }//end foreach
            var oddWord=dict.Where(x=>x.Value%2!=0).ToDictionary(x=>x.Key,x=>x.Value);
            Console.WriteLine(string.Join(", ",oddWord.Keys)); 
        }
    }
}