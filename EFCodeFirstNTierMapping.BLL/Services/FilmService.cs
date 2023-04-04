using EFCodeFirstNTierMapping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.BLL.Services
{
    public class FilmService
    {
        public void FilmEkle(Film film)
        {
            DAL.Manager.FilmManager filmManager = new DAL.Manager.FilmManager();
            film.AddedTime = DateTime.Now;
            film.ModifiedDate = DateTime.Now;
            film.IsActive = true;
            film.VizyonTarihi = new DateTime(2022, 02, 25);
            film.FilmDetayi.AddedTime = DateTime.Now;
            film.FilmDetayi.IsActive = true;
            film.FilmDetayi.ModifiedDate = DateTime.Now;

            filmManager.FilmEkle(film);

        }
    }
}
