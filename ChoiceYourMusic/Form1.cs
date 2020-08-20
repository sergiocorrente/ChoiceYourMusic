using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoiceYourMusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Music> musics = new List<Music>(); 
       
        private void Form1_Load(object sender, EventArgs e)
        {


            Music Jasmin = new Music( "Jasmin", "Piano",new List<string>() { "Drum", "Vocals", "coma" });
            Music Persian = new Music("Persian Flower", "World Music", new List<string>() { "Quanun", "def", "riq" });
            
            
            cbMusic.Items.Add("All");

         musics.Add(Jasmin);
            musics.Add(Persian);

        }

        
        private void cbMusic_SelectedIndexChanged(object sender, EventArgs e)
        { 
         
            lbMusic.DataSource = null;
            lbMusic.DataSource = musics;
           

        }
        
        private void lbMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Music selected = (Music)lbMusic.SelectedItem;


            if (lbMusic.DataSource != null)
            {
                labelMusic.Text = selected.Description();
            }
            else
            {
                labelMusic.Text = "";
            }

        }

 
    }
}
