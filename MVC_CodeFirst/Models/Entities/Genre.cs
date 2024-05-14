using MVC_CodeFirst.Models.Abstracts;

namespace MVC_CodeFirst.Models.Entities
{
    public class Genre:BaseClass
    {
        public string Name { get; set; }

        public List<MovieGenre> MovieGenres { get; set; }

    }
}
