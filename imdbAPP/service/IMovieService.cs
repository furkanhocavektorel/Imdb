

using imdbAPP.model;

namespace imdbAPP.service
{
    internal interface IMovieService
    {
        public void addStar(int movieId, int star);

        public Movie findById(int id);
    }
}
