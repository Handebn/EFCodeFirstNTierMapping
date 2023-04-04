using EFCodeFirstNTierMapping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL.Manager
{
    public class FilmManager
    {
        //CRUD Insert,Update,Delete,Select

        public void FilmEkle(Film film)
        {
            using(Context ctx = new Context())
            {
                ctx.FilmlerTablosu.Add(film);
                ctx.SaveChanges();
            }

        }

        void FilmGuncelle(Film film)
        {
            using (Context ctx = new Context())
            {
                Film gelenFilm =ctx.FilmlerTablosu.FirstOrDefault(x => x.ID == film.ID);

                gelenFilm.FilmAdi = film.FilmAdi;
                gelenFilm.VizyonTarihi = film.VizyonTarihi;
                gelenFilm.KategoriID = film.KategoriID;
                gelenFilm.ModifiedDate = DateTime.Now;

                ctx.SaveChanges();

            }
        }

    }
}
