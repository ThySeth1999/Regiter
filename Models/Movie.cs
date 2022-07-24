

namespace MovieApp.Models
{


    public class Movie
    {
        public int Id { get; set; }
        public string MovieTittle { get; set; }
        public int Duration { get; set; }
        public System.DateTime RealeaseDate { get; set; }
        public SubTittle Subtitle  { get; set; }
        public MovieLanguage MovieLanguage { get; set; }
        public MovieType MovieType { get; set; }
        public string Description { get; set; }

    }
}
