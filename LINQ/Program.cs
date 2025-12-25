namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a list of video games
            var videoGames = new List<string> { "Silent Hill", "Call of Duty", "Elden Ring", "Bioshock", "Little Nightmares" };
            
            // Order the list of games by length of the game name
            var sortByNameLength = videoGames.OrderBy(videoGames => videoGames.Length).ToList();
            // use a foreach loop to write results to the console
            sortByNameLength.ForEach(game => Console.WriteLine(game));
        }
    }
}
