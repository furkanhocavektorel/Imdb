using imdbAPP.model;


namespace imdbAPP.db
{
    internal class Class1
    {
        // adminin kendisine veya adminin index'ine
        public static List<Admin> Admins;
        public static List<Customer> Customers;
        public static List<Movie> Movies;
        public static List<Comment> Comments;


        public Class1()
        {
            Admins = new List<Admin>();
            Customers = new List<Customer>();
            Movies = new List<Movie>();
            Movie movie = new Movie();
            movie.Id = 1;
            movie.RatingList = new List<int>();
            movie.Description = "mafya filmi";
            movie.Name = "GodFather";
            Movies.Add(movie);
            Comments = new List<Comment>();
        }

    }
}
