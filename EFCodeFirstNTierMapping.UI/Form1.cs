using EFCodeFirstNTierMapping.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirstNTierMapping.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Services.FilmService filmService = new BLL.Services.FilmService();
            Film film = new Film();
            film.FilmAdi = textBox1.Text;
            film.KategoriID = 1;
            film.FilmDetayi = new FilmDetay()
            {
                FilmDetayi = "aaaaadsdssa"
            };

            filmService.FilmEkle(film);
        }
    }
}
