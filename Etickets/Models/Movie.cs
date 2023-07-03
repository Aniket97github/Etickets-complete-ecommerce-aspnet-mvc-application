using Etickets.DATA.Enum;

namespace Etickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double price { get; set; }
        public string Imageurl { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie>Actors_Movies { get; set; }
    }
}
