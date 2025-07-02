using RecordShop.Common.Dto.Music;
using RecordShop.Common.Models;
using RecordShopFront.Components.Pages;
using RecordShopFront.models.ViewModels;

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
                    Id = genre.Id,
                    AlbumId = genre.AlbumId,
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
        public static (OperationResult,ArtistAlbumJunctionWriteDto) AddArtist( AlbumReadDto readAlbum, int artistId)
        {
            OperationResult operationResult = new OperationResult();
            ArtistAlbumJunctionWriteDto dto = new ArtistAlbumJunctionWriteDto();
            Console.WriteLine("adding artist");
            var albumWriteDto = ConvertFromReadToWrite(readAlbum);
            var artistExists = readAlbum.ArtistJunction.Any(j => j.ArtistId == artistId);
            if (artistExists==false)
            {

               dto.ArtistId = artistId;
               dto.AlbumId = readAlbum.Id;
               operationResult.IsSuccess = true;
            }
            return (operationResult, dto);

        }
        public static GenreModel GenreReadDtoToViewModel(AlbumGenreReadDto dto)
        {
            GenreModel vm = new GenreModel()
            {
                Id = dto.Id,
                AlbumId = dto.AlbumId,
                Genre = dto.Genre,
            };
            return vm;
        }
        public static AlbumGenreReadDto GenreViewModelToReadDto(GenreModel vm)
        {
            AlbumGenreReadDto dto = new()
            {
                Id = vm.Id,
                AlbumId = vm.AlbumId,
                Genre = vm.Genre,
            };
            return dto;
        }
        public static AlbumGenreWriteDto GenreViewModelToWriteDto(GenreModel vm)
        {
            AlbumGenreWriteDto dto = new AlbumGenreWriteDto(){
                Id = vm.Id,
                AlbumId = vm.AlbumId,
                Genre = vm.Genre,
            };
            return dto;
        }
        public static AlbumGenreWriteDto ConvertToWriteDtoFromGenreReadDTO(AlbumGenreReadDto read)
        {
            AlbumGenreWriteDto writeDto = new AlbumGenreWriteDto()
            {
                Id = read.Id,
                AlbumId = read.AlbumId,
                Genre = read.Genre,
            };
            return writeDto;
        }

    }
    
    }
