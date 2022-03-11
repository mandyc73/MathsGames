using TimesTables.Problems;

namespace TimesTables.Results
{
    public class Result
    {
        public int NumberOfQuestions { get; set; }
        public int NumberCorrect { get; set; }
        public TimeSpan TimeTaken { get; set; } = new TimeSpan(0);
        public List<Problem> Problems { get; set; } = new List<Problem>();
        public string Game { get; set; }

        

        public string TimeTakenString { get
            {
                if(TimeTaken.Ticks >0)
                {
                    int Minutes = TimeTaken.Minutes;
                    int Seconds = TimeTaken.Seconds;
                    string minuteString = (Minutes > 1 || Minutes == 0) ? "minutes" : "minute";
                    string secondString = Seconds > 1 || Seconds == 0 ? "seconds" : "second";

                    return $"{Minutes} {minuteString} {Seconds} {secondString}";
                }
                return "";
            } }

        public Result() { }
        public Result(string game, int numberOfQuestions, List<Problem> problems, TimeSpan timeTaken)
        {
            Game = game;
            NumberOfQuestions = numberOfQuestions;
            Problems = problems;
            TimeTaken = timeTaken;
        }
    }
}
