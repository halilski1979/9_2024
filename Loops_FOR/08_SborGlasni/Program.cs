namespace _08_SborGlasni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете текст(стринг), въведен от потребителя, и изчислява и отпечатва сумата от
            //стойностите на гласните букви според таблицата по - долу:


            string word=Console.ReadLine();
            int s = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a')
                {
                    s += 1;
                }
                if (word[i] == 'e')
                {
                    s += 2;
                }
                if (word[i] == 'i')
                {
                    s += 3;
                }
                if (word[i] == 'o')
                {
                    s += 4;
                }

                if (word[i] == 'u')
                {
                    s += 5;
                }
            }
            Console.WriteLine(s);



        }



    }
}