using RecordShop.Common.Enums;

namespace RecordShopFront.models
{
    public class GenreViewModel
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public Genre Genre { get; set; }
    }
}
