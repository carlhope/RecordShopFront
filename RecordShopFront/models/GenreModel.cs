using RecordShop.Common.Enums;

namespace RecordShopFront.models
{
    public class GenreModel
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string? Genre { get; set; }
    }
}
