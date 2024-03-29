namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Queue<string> queue = new Queue<string>();
            queue.Enqueue("ibrahim");
            queue.Enqueue("ivan");
            queue.Enqueue("Mitko");
            queue.Enqueue("lili");
           
            while (queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

    }
}