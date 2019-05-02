using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    public class ListMusic
    {

        public void DataInit()
        {

            using (DataContext context = new DataContext())
            {
                context.Bands.RemoveRange(context.Bands);
                context.Musics.RemoveRange(context.Musics);
                context.SaveChanges();

                Musicband Musicband1 = new Musicband
                {
                    Name = "Halo"
                };
                Musicband Musicband2 = new Musicband
                {
                    Name = "Star"
                };
                Musicband Musicband3 = new Musicband
                {
                    Name = "Trio"
                };
                context.Bands.AddRange(new List<Musicband> { Musicband1, Musicband2, Musicband3 });
                Music Music1 = new Music
                {
                    Name = "The best",
                    Min = 4,
                    Sec = 10,
                    Rating = 1,
                    Musicband = Musicband1,
                };
                Music Music2 = new Music
                {
                    Name = "Time",
                    Min = 4,
                    Sec = 10,
                    Rating = 2,
                    Musicband = Musicband1,
                };
                Music Music3 = new Music
                {
                    Name = "Life",
                    Min = 4,
                    Sec = 0,
                    Rating = 3,
                    Musicband = Musicband1,
                };

                context.Musics.AddRange(new List<Music> { Music1, Music2, Music3});

                context.SaveChanges();
            }
        }


    }
}
