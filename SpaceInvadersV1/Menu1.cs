using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersV1
{
    public partial class controlsBtn : Form
    {
        SoundPlayer clickSound = new SoundPlayer(@"..\..\..\Sounds\Click.wav");
        SoundPlayer mainMusic = new SoundPlayer(@"..\..\..\Sounds\MainMusic.wav");

        public controlsBtn(int score)
        {
            InitializeComponent();
            mainMusic.Play();
            scoreTxt.Text = "Latest score: " + score;
        }

        private void Menu1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickSound.Play();
            Form1 Livello1 = new Form1();
            Livello1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //clickSound.Play();
            Form4 form4 = new Form4();  
            form4.Show();
        }
    }
}
