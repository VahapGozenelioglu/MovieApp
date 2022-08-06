using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1, Name = "The Godfather", 
                    shortDescription = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                    ImageUrl = "1.jpg"
                },
                new Movie(){ 
                    Id = 2, Name = "The Shawshank Redemption",
                    shortDescription = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    ImageUrl = "2.jpg"},
                new Movie(){ 
                    Id = 3, Name = "The Godfather Part II",
                    shortDescription = "The Godfather Part II",
                    Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    ImageUrl = "3.jpg"},
                new Movie(){ 
                    Id = 4, Name = "Inception",
                    shortDescription = "Inception",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                    ImageUrl = "4.jpg"},
                new Movie(){ 
                    Id = 5, Name = "Fight Club",
                    shortDescription = "Fight Club",
                    Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                    ImageUrl = "5.jpg"},
                new Movie(){ 
                    Id = 6, Name = "The Dark Knight",
                    shortDescription = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    ImageUrl = "6.jpg"},
                new Movie(){ 
                    Id = 7, Name = "12 Angry Men",
                    shortDescription = "12 Angry Men",
                    Description = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.",
                    ImageUrl = "7.jpg"},
                new Movie(){ 
                    Id = 8, Name = "The Lord of the Rings: The Fellowship of the Ring",
                    shortDescription = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    ImageUrl = "8.jpg"},
                new Movie(){ 
                    Id = 9, Name = "The Matrix",
                    shortDescription = "The Matrix",
                    Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                    ImageUrl = "9.jpg"},
                new Movie(){ 
                    Id = 10, Name = "Se7en",
                    shortDescription = "Se7en",
                    Description = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.",
                    ImageUrl = "10.jpg"}
            };
        }

        public static List<Movie> GetMovies()
        {
            return _movies;
        }

        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetMovieById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}