namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<string> stack = new Stack<string>();
            stack.Push("Smilyan");
            stack.Push("Krasi");
            stack.Push("Koceto");
            var index= stack.Count();
            while (index>0)
            {
                Console.WriteLine(stack.Peek());
                index--;
            }

            
        }
    }
}