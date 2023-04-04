using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.Data
{
    public class Oyuncu : BaseEntity
    {
        public string OyuncuAdi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string  Hayati{ get; set; }

        // Navigation Property
        //Bir Oyuncunun Birden fazla filmi vardır.

        public virtual List<OyuncuFilm>  OyuncununFilmleri{ get; set; }
    }
}
