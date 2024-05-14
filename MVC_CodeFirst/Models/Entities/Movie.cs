using MVC_CodeFirst.Models.Abstracts;

namespace MVC_CodeFirst.Models.Entities
{
    public class Movie:BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }

        //Mapping
        //Bir filmin bir yonetmeni olur.
        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public List<MovieGenre> MovieGenres { get; set; }
    }
}
