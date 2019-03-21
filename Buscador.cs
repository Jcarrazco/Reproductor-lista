using HtmlAgilityPack;
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
            string[] splito = Txbx_Buscar.Text.Split(' ');//separador de palabras
            string URl = "https://www.youtube.com/results?search_query=";
            foreach(string s in splito)
            {
                URl = URl + s + "+"; //agrego las palabras de busqueda
            }
            URl = URl.Substring(0, URl.Length - 1);//quito el exedente +
            ////////////////////////
            HtmlAgilityPack.HtmlWeb Webscrap = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = Webscrap.Load(URl);
            HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//*[@id='video - title']").ToArray();
            foreach (HtmlNode Item in nodes)
            {
                listView1.Items.Add(Item.Name);
            }
        }

        private void Buscador_Load(object sender, EventArgs e)
        {

            
        }
    }
}
