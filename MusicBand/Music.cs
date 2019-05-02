using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    public class Music
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
        public int Rating { get; set; }
        public Musicband Musicband { get; set; }
    }
}
