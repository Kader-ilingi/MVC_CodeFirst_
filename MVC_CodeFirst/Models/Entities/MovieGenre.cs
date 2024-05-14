using MVC_CodeFirst.Models.Abstracts;

namespace MVC_CodeFirst.Models.Entities
{
    public class MovieGenre:BaseClass
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }

        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
