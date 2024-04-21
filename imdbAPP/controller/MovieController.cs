using imdbAPP.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imdbAPP.controller
{
    internal class MovieController
    {
        IMovieService movieService;
        public MovieController()
        {
            movieService = new MovieService();
        }
        public void addStar(int id, int star)
        {
            movieService.addStar(id, star);
        }
    }
}
