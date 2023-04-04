using EFCodeFirstNTierMapping.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Mapping
{
    public class OyuncuFilmMapping : EntityTypeConfiguration<OyuncuFilm>
    {
        public OyuncuFilmMapping()
        {
            HasRequired(x => x.OyuncununFilmi).WithMany(x => x.FilminOyunculari).HasForeignKey(x => x.OyuncuID);

            HasRequired(x => x.FilminOyuncusu).WithMany(x => x.OyuncununFilmleri).HasForeignKey(x => x.FilmID);

            Property(x => x.CalismaGunu).IsRequired();
        }
    }
}
