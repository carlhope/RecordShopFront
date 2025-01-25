using RecordShop.Common.Dto.Music;
using RecordShopFront.Components.Pages;

namespace RecordShopFront.Services
{
    public class AlbumService
    {

        public static AlbumWriteDto ConvertFromReadToWrite(AlbumReadDto readAlbum)
        {
            AlbumWriteDto WriteAlbum = new AlbumWriteDto()
            {
                Id = readAlbum.Id,
                Title = readAlbum.Title,
                Description = readAlbum.Description,
                Genres = new List<AlbumGenreWriteDto>(),
                ArtistJunction = new List<ArtistAlbumJunctionWriteDto>()
            };
            //populate genres
            foreach (var genre in readAlbum.Genres)
            {
                WriteAlbum.Genres.Add(new AlbumGenreWriteDto()
                {
                    AlbumId = genre.Id,
                    Genre = genre.Genre
                });
            }
            //populate artists
            foreach (var junction in readAlbum.ArtistJunction)
            {
                WriteAlbum.ArtistJunction.Add(new ArtistAlbumJunctionWriteDto()
                {
                    AlbumId = junction.Id,
                    ArtistId = junction.ArtistId
                });
            }
            return WriteAlbum;
        }
        public static AlbumWriteDto AddArtist( AlbumReadDto readAlbum, int artistId)
        {
            Console.WriteLine("adding artist");
            int artId = artistId;
            var albumWriteDto = ConvertFromReadToWrite(readAlbum);
            if (!readAlbum.ArtistJunction.Any(j => j.ArtistId == artId))
            {
                
                albumWriteDto.ArtistJunction.Add(new ArtistAlbumJunctionWriteDto()
                {
                    AlbumId = readAlbum.Id,
                    ArtistId = artId
                });
            }
            return albumWriteDto;

        }
        
    }
    
    }
