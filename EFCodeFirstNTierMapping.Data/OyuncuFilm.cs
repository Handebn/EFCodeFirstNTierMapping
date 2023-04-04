using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.Data
{
    public class OyuncuFilm : BaseEntity
    {
        public int CalismaGunu { get; set; }
        public int OyuncuID { get; set; }
        public int FilmID { get; set; }

        // Navigation Properties

        public virtual Film OyuncununFilmi { get; set; } //Hangi Film

        public virtual Oyuncu FilminOyuncusu { get; set; } // Hangi Oyuncu
    }
}
