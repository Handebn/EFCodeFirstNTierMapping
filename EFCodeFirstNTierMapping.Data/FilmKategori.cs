using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.Data
{
    public class FilmKategori : BaseEntity
    {
        public string KategoriAdi { get; set; }

        //Navigation Property

        public virtual List<Film> KategorininFilmleri { get; set; }
    }
}
