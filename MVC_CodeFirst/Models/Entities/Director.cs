using MVC_CodeFirst.Models.Abstracts;

namespace MVC_CodeFirst.Models.Entities
{
    public class Director:BaseClass
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //Mapping
        //bir yonetmenin birden fazla filmi olur.

        public List<Movie> Movies { get; set; }
    }
}
