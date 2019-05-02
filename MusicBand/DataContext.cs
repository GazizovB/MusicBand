namespace MusicBand
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public DbSet<Musicband> Bands { get; set; }
        public DbSet<Music> Musics { get; set; }

    }
}