using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaReproduccion
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        private void Btn_repro_Click(object sender, EventArgs e)
        {
            Form Orig = new Form();
            Orig.Show();
            this.Close();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            string Busque = Txbx_Buscar.Text;
            /////////////////////////
        }

        private void Buscador_Load(object sender, EventArgs e)
        {

            HtmlAgilityPack.HtmlWeb Webscrap = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = Webscrap.Load("https://www.youtube.com/");
            //var headernames = doc.DocumentNode.SelectNodes().ToList();
        }
    }
}
