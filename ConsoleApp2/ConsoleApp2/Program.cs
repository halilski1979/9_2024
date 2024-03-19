using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на нов стек
            Stack stack = new Stack();

            // Добавяне на елементи към стека
            stack.Push("Елемент 1");
            stack.Push("Елемент 2");
            stack.Push("Елемент 3");

            // Проверка на размера на стека
            Console.WriteLine("Размер на стека: " + stack.Count);

            // Изваждане на елементи от стека
            while (stack.Count > 0)
            {
                string element = (string)stack.Pop();
                Console.WriteLine("Изваден елемент: " + element);
            };
        }
    }
}