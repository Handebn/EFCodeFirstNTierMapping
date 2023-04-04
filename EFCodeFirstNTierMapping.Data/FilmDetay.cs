using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.Data
{
    public class FilmDetay: BaseEntity
    {
        public string FilmDetayi { get; set; }
        //public int FilmID { get; set; }

        public string Resim { get; set; }

        public string Yapimcisi { get; set; }

        //Navigation Property
        public virtual Film DetayinFilmi { get; set; }
    }
}
