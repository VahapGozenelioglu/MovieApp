namespace MovieApp.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string shortDescription { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}