using MovieDatabase2;

List<Movie> movies = new List<Movie>()
{
    new Movie ("The Fountain", "Drama"),
    new Movie ("Office Space", "Comedy"),
    new Movie ("Dune", "SciFi"),
    new Movie ("Star Wars", "SciFi"),
    new Movie ("Star Trek", "SciFi"),
    new Movie ("Superbad", "Comedy"),
    new Movie ("Lord of the Rings", "Fantasy"),
    new Movie ("Harry Potter", "Fantasy"),
    new Movie ("Pulp Fiction", "Thriller"),
    new Movie ("The Big Lebowski", "Comedy"),
};

bool continueGoing = true;
bool output = false;

while (continueGoing == true)
{

    Console.WriteLine("Please enter a category of movie you would like to see.");

    string userCategory = Console.ReadLine().ToLower().Trim();
    output = false;

    while (output == false)
    {

        if (userCategory == "thriller" || userCategory == "comedy" || userCategory == "drama" || userCategory == "scifi" || userCategory == "fantasy")
        {
            output = true;
        }
        else
        {
            Console.WriteLine("That category does not exist. Please select one of the following categories:");
            Console.WriteLine("Thriller - Comedy - Drama - SciFi - Fantasy");
            Console.WriteLine("Please enter a category of movie you would like to see.");
            userCategory = Console.ReadLine().ToLower().Trim();

        }

    }

    List<Movie> selectedCategory = movies.Where(x => x.movieCategory.ToLower().Contains(userCategory)).ToList();

    foreach (Movie movie in selectedCategory)
    {
        Console.WriteLine(movie.movieTitle);
    }

    Console.WriteLine("Would you like to continue? y/n");
    string userResponse = Console.ReadLine();
    if (userResponse.ToLower() == "n")
    {
        continueGoing = false;
        break;
    }

}

Console.WriteLine("Thank you for checking out the Movie Database.");
Console.WriteLine("Press any key to exit");
Console.ReadKey();
