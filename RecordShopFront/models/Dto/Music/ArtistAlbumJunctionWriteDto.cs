namespace RecordShop.Common.Dto.Music
{
    public class ArtistAlbumJunctionWriteDto
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int AlbumId { get; set; }
        public ArtistWriteDto Artist { get; set; }
        public AlbumWriteDto Album { get; set; }

    }
}