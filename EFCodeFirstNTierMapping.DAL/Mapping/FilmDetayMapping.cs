using EFCodeFirstNTierMapping.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Mapping
{
    public class FilmDetayMapping :EntityTypeConfiguration<FilmDetay>
    {
        public FilmDetayMapping()
        {

            // field 
            // class
            // constructor
            // metot
            // property
            //delege, event

            //Primary Key olduğunu belirtebiliriz.
            HasKey(x => x.ID);

            //HasRequired(x => x.DetayinFilmi).WithRequiredPrincipal(x => x.FilmDetayi);
        }
    }
}
