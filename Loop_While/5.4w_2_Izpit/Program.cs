namespace _5._4w_2_Izpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GradeLimit = int.Parse(Console.ReadLine());
            int GradesCount = 0;
            double totalScore = 0;
            int solvedProblems = 0;
            string lastProblem = string.Empty;
            while (true)
            {
                string problem = Console.ReadLine();
                if (problem == "Enough")
                {
                    Console.WriteLine($"Average score: {totalScore/solvedProblems}");
                    Console.WriteLine($"Number of problems: {solvedProblems}");
                    Console.WriteLine($"Last problem {lastProblem}");

                }
                int grade = int.Parse( Console.ReadLine());
                totalScore+= grade;
                solvedProblems++;
                lastProblem = problem;

                if (grade <= 4)
                {
                    GradesCount++;
                    if (GradesCount==GradeLimit)
                    {
                        Console.WriteLine($"You need a break, {GradesCount} poor grades");
                        break;
                    }

                }
            }
        }
    }
}