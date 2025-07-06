using RecordShop.Common.Enums;
using RecordShopFront.models;

namespace RecordShopFront.Services
{
    public class GenreService
    {
        public static List<GenreModel> GetAllGenres()
        {
            List<GenreModel> genres = new List<GenreModel>();
            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
               genres.Add(new GenreModel
                {
                    Id = (int)genre,
                    Genre = genre.ToString()
                });
            }
            return genres;
        }
    }
}
