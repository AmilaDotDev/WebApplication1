
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }

        public int ArtistId { get; set; }

        public int GenreId { get; set; }
    }
}