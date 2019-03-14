using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Data.SqlClient;

namespace ListaReproduccion
{
    public partial class Reproductor : Form
    {
        public Reproductor()
        {
            InitializeComponent();
        }
        string Ruta ;//variable ruta para uso como condicion en botones
        List<string> Rutacompleta = new List<string>();//lista de rutas para las canciones
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();//se creo una instancia para reproductor windows
        double time = 0;//variable para poner pausa y reproducir en el segundo donde quedo

        private void Reproductor_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Ubicacion_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();//se instancio un cuadro de busqueda
            if (FBD.ShowDialog() == DialogResult.OK)//si se presiona ok en el dialogo
            {
                Ruta = FBD.SelectedPath;//carga la ruta a "Ruta"
            }
            DirectoryInfo Dinfo = new DirectoryInfo(@Ruta);//se creo una intancia de un directoryinfo con esta ruta @ para avitar que los \ funcionen
           
            foreach (var Values in Dinfo.GetFiles())//por cada valor en la instancia directorio
            {
                Rutacompleta.Add(Ruta + "\\" + Values.Name);//agrega a una lista las direcciones indexadas
                TagLib.File tagFile = TagLib.File.Create(Ruta + "\\" + Values.Name);//se uso la libreria tag para los datos como artista y duracion
                Lst_Rep.Items.Add(Values.Name +"   "+ tagFile.Properties.Duration);//agrega los valores de nombre y duracion
            }
            Lst_Rep.Focus();
            Lst_Rep.SelectedIndex = 0;//coloca el focus a index 0
            
        }

        private void Lst_Rep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ruta != "") {//validar que exista una ruta
                //cargar datos de taglib
                TagLib.File tagFile = TagLib.File.Create(Rutacompleta[Lst_Rep.SelectedIndex]);
                string artist = tagFile.Tag.AlbumArtists.FirstOrDefault();
                string albumTitle = tagFile.Tag.Album;
                uint year = tagFile.Tag.Year;
                string genero = tagFile.Tag.Genres.FirstOrDefault();
                if (artist == null) artist = " ";
                if (albumTitle == null) albumTitle = " ";
                if (genero == null) genero = " ";
                //agregarlos a la lista validando que no sean null
                Lbx_Res.Items.Add("Artista");
                Lbx_Res.Items.Add(artist);
                Lbx_Res.Items.Add("Album");
                Lbx_Res.Items.Add(albumTitle);
                Lbx_Res.Items.Add("Año");
                Lbx_Res.Items.Add(Convert.ToString(year));
                Lbx_Res.Items.Add("Genero");
                Lbx_Res.Items.Add(genero);
            }
        }

        private void Btn_Upp_Click(object sender, EventArgs e)
        {
            //limpiar la lista y poner el focus hasta el tope superior
            Lbx_Res.Items.Clear();
            Lst_Rep.Focus();
            Lst_Rep.SelectedIndex = 0;
        }

        private void Btn_up_Click(object sender, EventArgs e)
        {
            Lbx_Res.Items.Clear();
            if (Lst_Rep.SelectedIndex > 0)
            Lst_Rep.SelectedIndex = Lst_Rep.SelectedIndex - 1;
        }

        private void Btn_down_Click(object sender, EventArgs e)
        {
            Lbx_Res.Items.Clear();
            if (Lst_Rep.SelectedIndex < (Lst_Rep.Items.Count - 1))
            Lst_Rep.SelectedIndex = Lst_Rep.SelectedIndex + 1;
        }

        private void Btn_DDown_Click(object sender, EventArgs e)
        {
            Lbx_Res.Items.Clear();
            Lst_Rep.SelectedIndex = Lst_Rep.Items.Count - 1;
        }

        private void Btn_play_Click(object sender, EventArgs e)
        {   //condiciona el play a que no se haya pausado previamente
            Btn_Pause.Enabled = true;
            if (Lst_Rep.SelectedIndex >= 0)
            {
                wplayer.URL = Rutacompleta[Lst_Rep.SelectedIndex];
                if (time > 0)
                {
                    wplayer.controls.currentPosition = time;
                    wplayer.controls.play();
                }
                else
                wplayer.controls.play();
            }
        }

        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            //sin pausa carga el tiempo donde quedo y lo envia a una variable global
            if (Lst_Rep.SelectedIndex >= 0 )
            {
                time = wplayer.controls.currentPosition;
                wplayer.controls.pause();
                Btn_Pause.Enabled = false;
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if (Lst_Rep.SelectedIndex >= 0)
            {
                wplayer.controls.stop();
                time = 0;
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            Buscador Search = new Buscador();
            Search.Show();
            this.Hide();
        }
    }
}
