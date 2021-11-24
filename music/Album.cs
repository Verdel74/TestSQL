using System;
using System.Collections.Generic;

#nullable disable

namespace TestSQL.music
{
    public partial class Album
    {
        public Album()
        {
            Ratings = new HashSet<Rating>();
        }

        public int IdAlbums { get; set; }
        public string Titre { get; set; }
        public int ArtistIdArtist { get; set; }

        public virtual Artist ArtistIdArtistNavigation { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
