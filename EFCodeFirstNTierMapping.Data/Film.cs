using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.Data
{
    public class Film : BaseEntity
    {

        public string FilmAdi { get; set; }
        public DateTime VizyonTarihi { get; set; }
        public int KategoriID { get; set; }
        //public int FilmDetayID { get; set; }
        
        //Navigation Properties

        public virtual FilmKategori FilminKategorisi { get; set; }

        public virtual FilmDetay FilmDetayi { get; set; }

        //Bir Fİlmin birden fazla oyuncusu olabilir.
        public virtual List<OyuncuFilm> FilminOyunculari { get; set; }

    }
}
