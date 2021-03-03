using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace NopeusPeli
{
    public class PeliLuokka
    {
        public Form1 MainForm;
        public Random rndButton = new Random();
        public int seuraavanappi;
        public bool pelialkoi = false;
        public bool peliloppui = false;
        
        public PeliLuokka(Form1 mainform)
        {
            MainForm = mainform;

        }

        public void RandomButton()
        {
            MainForm.sallipisteenlisays = true;

            if (MainForm.kerkeskoklikata == false)
            {
                peliloppui = true;

            }
            else if (MainForm.kerkeskoklikata == true)
            {
                // Miten paljon nopeutetaan peliä, kun käyttäjä saa pisteen.
                MainForm.timer1.Interval = MainForm.timer1.Interval - 5;

                seuraavanappi = rndButton.Next(MainForm.pelinapit.Count);


                if (MainForm.currentButton == MainForm.pelinapit[seuraavanappi])
                {
                    RandomButton();
                }
                else
                {
                    MainForm.currentButton = MainForm.pelinapit[seuraavanappi];
                }
            }

            if (peliloppui == true)
            {

                PeliLoppui();

            }

        }

        public void PeliLoppui()
        {
            MainForm.sallipisteenlisays = false;
            pelialkoi = false;
            MainForm.timer1.Enabled = false;
            MainForm.timerPeliAIka.Enabled = false;
            MainForm.textBoxNimi.Visible = true;
            MainForm.buttonLisaaHighScore.Visible = true;
            MainForm.labelPeliPaattyi.Visible = true;
            MainForm.labelAika.Visible = true;


        }

    }
}
