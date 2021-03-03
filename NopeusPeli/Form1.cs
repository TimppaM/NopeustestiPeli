using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NopeusPeli
{
    public partial class Form1 : Form
    {
        public PeliLuokka peliluokka;
        public LisaaHighscore lisaaHS;
        public HighscoreForm hsform;
        public List<Button> pelinapit = new List<Button>();
        public Button currentButton;
        public int pisteet = 0;
        public bool kerkeskoklikata = true;
        public bool sallipisteenlisays = false;
        public Pelaaja player;
        public int peliaikasekunneissa = 0;
      
        private const string HighscoresFile = "highscores.json";
        private List<Pelaaja> pelaajat = new List<Pelaaja>();

        public Form1()
        {

            InitializeComponent();

            LoadHighScoresFromFile();

            pelinapit.Add(buttonRed);
            pelinapit.Add(buttonYellow);
            pelinapit.Add(buttonGreen);
            pelinapit.Add(buttonOrange);

            peliluokka = new PeliLuokka(this);
            //lisaaHS = new LisaaHighscore();

            this.buttonRed.Click += new System.EventHandler(this.NapinPainallus);
            this.buttonYellow.Click += new System.EventHandler(this.NapinPainallus);
            this.buttonGreen.Click += new System.EventHandler(this.NapinPainallus);
            this.buttonOrange.Click += new System.EventHandler(this.NapinPainallus);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonRed.BackColor = Color.FromArgb(128, 0, 0);
            buttonYellow.BackColor = Color.FromArgb(192, 192, 0);
            buttonGreen.BackColor = Color.FromArgb(0, 128, 0);
            buttonOrange.BackColor = Color.FromArgb(192, 64, 0);
            
            if(peliluokka.peliloppui == false)
            {
                sallipisteenlisays = true;
                peliluokka.RandomButton();

                if (currentButton == buttonRed)
                {
                    currentButton.BackColor = Color.FromArgb(255, 32, 12);
                }
                else if (currentButton == buttonYellow)
                {
                    currentButton.BackColor = Color.FromArgb(255, 255, 128);
                }
                else if (currentButton == buttonGreen)
                {
                    currentButton.BackColor = Color.FromArgb(0, 255, 128);
                }
                else if (currentButton == buttonOrange)
                {
                    currentButton.BackColor = Color.FromArgb(255, 128, 0);
                }

                kerkeskoklikata = false;
            }
        }
        void NapinPainallus(object sender, EventArgs e)
        {
            if (currentButton == sender && sallipisteenlisays == true)
            {
                pisteet += 1;
                labelPisteet.Text = pisteet.ToString();
                kerkeskoklikata = true;
                sallipisteenlisays = false;
            }
            else if (currentButton != sender && peliluokka.pelialkoi == true)
            {
                sallipisteenlisays = false;
                peliluokka.PeliLoppui();
            }
        }

        private void buttonAloitaPeli_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            buttonRed.BackColor = Color.FromArgb(128, 0, 0);
            buttonYellow.BackColor = Color.FromArgb(192, 192, 0);
            buttonGreen.BackColor = Color.FromArgb(0, 128, 0);
            buttonOrange.BackColor = Color.FromArgb(192, 64, 0);

            pisteet = 0;
            labelPisteet.Text = pisteet.ToString();
            peliluokka.pelialkoi = true;
            this.timer1.Enabled = true;
            this.timerPeliAIka.Enabled = true;
            this.kerkeskoklikata = true;
            peliluokka.peliloppui = false;
            buttonAloitaPeli.Visible = false;
            labelPisteet.Visible = true;
            buttonHSOpen.Visible = false;
            peliaikasekunneissa = 0;
            labelAika.Visible = false;
            listViewHighScores.Visible = false;

        }

        private void SaveHighScoresToFile()
        {
            // Tallennetaan pelaajat-lista JSON-muotoiltuna tiedostoon.
            // Muunnetaan pelaajat-lista json merkkijonoksi.
            string pelaajatJson = System.Text.Json.JsonSerializer.Serialize(pelaajat);

            // tallennetaan merkkijono tekstinä tiedostoon.
            System.IO.File.WriteAllText(HighscoresFile, pelaajatJson);
        }

        private void LoadHighScoresFromFile()
        {
            // Luetaan JSON-muotoiltu tiedosto ja viedään sisältö pelaajat-listaan.
            if (System.IO.File.Exists(HighscoresFile))
            {
                string jsonData = System.IO.File.ReadAllText(HighscoresFile);
                // Muunnetaan (deserialize) json muotoinen teksti objekteiksi.
                // Ja sijoitetaan pelaajat-listaan.
                pelaajat = System.Text.Json.JsonSerializer.Deserialize<List<Pelaaja>>(jsonData);

            }
        }

        private void UpdateHighScoreListView()
        {
            // Tyhjennetään lista
            this.listViewHighScores.Items.Clear();

            // Lisätään kaikki pelaajat listaan
            foreach (var item in pelaajat)
            {
                
                this.listViewHighScores.Items.Add(new ListViewItem(new string[] { item.Pisteet.ToString(), item.Nimi }));
            }
        }

        private void buttonLisaaHighScore_Click(object sender, EventArgs e)
        {
            // Jos pisteet on enemmän kun 0, niin silloin lisätään highscore-listaan.
            if(pisteet > 0)
            {
                // Luodaan uusi pelaaja-olio, joka lisätään pelaajat-listaan.
                player = new Pelaaja(pisteet, textBoxNimi.Text);
                pelaajat.Add(player);

                SaveHighScoresToFile();
                labelPeliPaattyi.Visible = false;
                buttonAloitaPeli.Visible = true;
                buttonLisaaHighScore.Visible = false;
                textBoxNimi.Visible = false;
                textBoxNimi.Text = "";
                labelPisteet.Visible = false;
                buttonHSOpen.Visible = true;
                labelAika.Visible = false;
            }
            else
            {
                labelPeliPaattyi.Visible = false;
                buttonAloitaPeli.Visible = true;
                buttonLisaaHighScore.Visible = false;
                textBoxNimi.Visible = false;
                textBoxNimi.Text = "";
                labelPisteet.Visible = false;
                buttonHSOpen.Visible = true;
                labelAika.Visible = false;
            }
        }

        private void buttonHSOpen_Click(object sender, EventArgs e)
        {
            UpdateHighScoreListView();
            if(listViewHighScores.Visible == false)
            {
                listViewHighScores.Visible = true;
            }
            else if (listViewHighScores.Visible == true)
            {
                listViewHighScores.Visible = false;
            }
        }

        private void timerPeliAIka_Tick(object sender, EventArgs e)
        {
            peliaikasekunneissa = peliaikasekunneissa + 1;
            labelAika.Text = "Aikaa kului: " + peliaikasekunneissa.ToString() + " sekuntia.";
        }
    }
}
