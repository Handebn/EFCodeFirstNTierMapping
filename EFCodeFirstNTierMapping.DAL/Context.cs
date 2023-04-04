using EFCodeFirstNTierMapping.DAL.Mapping;
using EFCodeFirstNTierMapping.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTierMapping.DAL
{
    public class Context : DbContext
    {
        public Context(): base ("Server=LAPTOP-74G342O0;Database=EFDetayMappingDB;Trusted_Connection=True;")
        {

        }

        public DbSet<Film> FilmlerTablosu { get; set; }
        public DbSet<FilmKategori> FilmKategoriTablosu { get; set; }
        public DbSet<Oyuncu> OyuncuTablosu { get; set; }
        public DbSet<OyuncuFilm> OyuncularınFilmlerTablosu { get; set; }
        public DbSet<FilmDetay>FilmDetaylariTablosu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //s takısını veritabanında engellemek için yazıyoruz.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Fluet Api
            modelBuilder.Configurations.Add(new FilmDetayMapping());
            modelBuilder.Configurations.Add(new FilmMapping());
            modelBuilder.Configurations.Add(new OyuncuFilmMapping());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
