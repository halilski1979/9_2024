namespace Opashka
{
    public class Program
    {
        static void Main(string[] args)
        {
            CircleQue<int> queue = new CircleQue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
        }
    }
}