
using RecordShop.Common.Models;
using RecordShopFront.Components.Pages;
using RecordShopFront.models;

namespace RecordShopFront.Services
{
    public class AlbumService
    {

        public static (OperationResult, AlbumModel) AddArtist(AlbumModel _album, int artistId)
        {
            OperationResult operationResult = new OperationResult();
            AlbumModel album = _album;
            var artistExists = album.ArtistJunction.Any(j => j.ArtistId == artistId);
            if (artistExists==false)
            {

               //add artist
                JunctionModel junction = new JunctionModel
                {
                    ArtistId = artistId,
                    AlbumId = album.Id
                };
                album.ArtistJunction.Add(junction);
                operationResult.IsSuccess = true;
                operationResult.Message = "Artist added successfully.";
            }
            return (operationResult, album);

        }

    }
    
    }
