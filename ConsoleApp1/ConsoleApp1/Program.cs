namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Ibrashim");
            names.Enqueue("Kaloian");
            names.Enqueue("Kostadin");
            names.Enqueue("Niki");
            while (names.Count > 0)
            {
                Console.WriteLine(names.Dequeue());
            }
        }
    }
}