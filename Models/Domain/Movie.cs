using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imdb.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public Uri UrlImage { get; set; }
        public Uri Trailer { get; set; }

        [Column(TypeName = "decimal(2,1)")]
        public decimal Rating { get; set; }

        public string UrlSlug { get; set; }

        public Genre Genre { get; set; }

    }
}
