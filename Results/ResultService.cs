namespace TimesTables.Results
{
    public class ResultService
    {
        public List<Result> Results { get; set; } = new List<Result>();

        

        public void AddResult(Result result)
        {
            Results.Add(result);
        }

        public List<Result> GetGameResults(string Game)
        {
            return Results.Where(x => x.Game == Game).ToList();
        }

       
    }
}
