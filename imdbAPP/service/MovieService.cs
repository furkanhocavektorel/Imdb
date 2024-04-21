using imdbAPP.db;
using imdbAPP.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imdbAPP.service
{
    internal class MovieService : IMovieService
    {
        public void addStar(int movieId, int star)
        {
            Movie movie=findById(movieId);
           movie.RatingList.Add(star);
            // listenin ortalamsı
            // liste elemanlarını topla , liste uzunluğuna böl
            int listCount=movie.RatingList.Count;
            int toplam = 0;

            foreach(int s in movie.RatingList)
            {
                toplam=toplam+s;
            }
            
            double rating= (double)toplam/listCount;

            movie.Rating=rating;
            
        }

        public Movie findById(int id)
        {
            Movie movie = new Movie();
            foreach (Movie m in Class1.Movies)
            {
                if (m.Id == id)
                {
                    movie = m;
                }
            }
            return movie;
        }
    }
}
