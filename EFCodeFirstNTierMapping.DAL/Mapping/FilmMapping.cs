using EFCodeFirstNTierMapping.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Mapping
{
    public class FilmMapping : EntityTypeConfiguration<Film>
    {
        public FilmMapping()
            {
                Property(x => x.FilmAdi).IsRequired();
                ToTable("Filmler");

            //FilmKategori ile Film arasında 1'e çok ilişki kurup,Film.cs'deki KategoeriID'nin ForeignKey olduğunu Belirttik.
                HasRequired(x => x.FilminKategorisi).WithMany(x => x.KategorininFilmleri).HasForeignKey(x => x.KategoriID);

            // 1-1 İlişki olduğunu bildirmek için yapıyoruz.
            HasRequired(x => x.FilmDetayi).WithRequiredPrincipal(x => x.DetayinFilmi);
            }
    }
}