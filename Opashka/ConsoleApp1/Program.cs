namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world from chatGPT";

            // Разделяме входния низ по интервали, за да получим масив от думи
            string[] words = input.Split(' ');

            // Използваме LINQ, за да преобразуваме всяка дума
            var result = words.Select(word =>
            {
                // Преобразуваме първата буква на думата в главна
                string firstCharUpper = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                return firstCharUpper;
            });

            // Съединяваме резултата отново в един низ с интервали между думите
            string output = string.Join(" ", result);

            Console.WriteLine(output); // Извеждаме преобразувания низ
        }
    }
}