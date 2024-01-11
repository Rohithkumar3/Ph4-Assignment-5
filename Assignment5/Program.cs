// See https://aka.ms/new-console-template for more information



public class MovieManager
{
    private List<Movies> movies= new List<Movies>()
        {
           new Movies { Id = 1, Title = "Guntur Karam", Genre = "Action", ReleaseDate = new DateTime(2024, 1, 12) },
           new Movies { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18) },
           new Movies { Id = 3, Title = "Money Heist", Genre = "Thriller", ReleaseDate = new DateTime(2021, 8, 9) },
        };
    
    public List<Movies> GetAllMovies()
    {
        return movies;
    }

    public Movies GetMovieByTitle(string title)
    {
        return movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
}

class Program
{
    static void Main()
    {
        MovieManager movieManager = new MovieManager();

        Console.WriteLine("All Movies:");
        foreach (var movie in movieManager.GetAllMovies())
        {
            Console.WriteLine($"{movie.Title} - {movie.Genre} - {movie.ReleaseDate}");
        }

        Console.Write("\nEnter the title of the movie to retrieve: ");
        string inputTitle = Console.ReadLine();

        Movies foundMovie = movieManager.GetMovieByTitle(inputTitle);

        if (foundMovie != null)
        {
            Console.WriteLine($"\nMovie Found: {foundMovie.Title} - {foundMovie.Genre} - {foundMovie.ReleaseDate}");
        }
        else
        {
            Console.WriteLine("\nMovie not found.");
        }
        Console.ReadKey();
    }
}
