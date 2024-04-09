using System.Reflection;

namespace Klasove
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < number; i++)
            {
                var input=Console.ReadLine().Split(' ').ToList();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person=new Person();
                person.Name=name; 
                person.Age=age;
                family.persons.Add(person);
            }
           var list=  family.persons.OrderBy(x => x.Name).ToList();
           var listTwo=family.persons.Where(x => x.Age>30).ToList();
            foreach (Person person in listTwo.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
