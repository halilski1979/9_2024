namespace Zadacha25
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.Write("Вход: ");
				int n=int.Parse(Console.ReadLine());
				n = Math.Abs(n);
				bool logick = true;
				string number=n.ToString();
				for (int i = 0; i < number.Length; i++)
				{
					if (n % int.Parse(number[i].ToString())!=0)
					{
						logick = false;break;
					}
				}
				if (logick)
				{
					Console.WriteLine("Изход: Yes");
				}
				else
				{
					Console.WriteLine("Изход: No");
				}
			}
			catch (Exception)
			{

				Console.WriteLine("Something went wrong!");
			}
        }
    }
}