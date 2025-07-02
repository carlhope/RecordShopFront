namespace RecordShopFront.models.ViewModels
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<JunctionModel> Artists { get; set; } = new();
        public List<GenreModel> Genres { get; set; } = new();
    }
}
