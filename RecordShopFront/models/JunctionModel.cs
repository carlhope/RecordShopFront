

namespace RecordShopFront.models
{
    public class JunctionModel
    {
        public int Id { get; set; }
     
        public int ArtistId { get; set; }
      
        public int AlbumId { get; set; }
        //navigation properties
        public ArtistModel? Artist { get; set; }
        public AlbumModel? Album { get; set; }
    }
}
