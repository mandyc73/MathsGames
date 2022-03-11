namespace TimesTables.Problems
{
    public class Problem
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public int CorrectAnswer {
            get
            {
                return NumberOne * NumberTwo;
            }
        }
        public string? AnswerString { get; set; }
        public int? Answer
        {
            get
            {
                if (!String.IsNullOrEmpty(AnswerString))
                {
                    return Convert.ToInt32(AnswerString);
                }

                return null;
            }
        }

        public Problem() { }
        public Problem(int lowestNumber, int highestNumber)
        {
            Random random = new Random();
            NumberOne = random.Next(lowestNumber, highestNumber + 1);
            NumberTwo = random.Next(lowestNumber, highestNumber + 1);

        }

        public override string ToString()
        {
            return $"{NumberOne.ToString()} x {NumberTwo.ToString()}";
        }
    }
}
