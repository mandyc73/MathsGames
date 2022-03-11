namespace TimesTables.Problems
{
    public class ProblemService
    {
        public List<Problem> CreateProblems(int numberOfProblems, int lowestNumber, int highestNumber)
        {
            var problems = new List<Problem>();
            List<string> distinctProblems = new List<string>();
            do
            {
                Problem problem = new Problem(lowestNumber, highestNumber);
                if (!distinctProblems.Contains(problem.ToString())){
                    distinctProblems.Add(problem.ToString());
                    problems.Add(problem);
                }
            }
            while (distinctProblems.Count < numberOfProblems);
            return problems;
        }
    }
}
