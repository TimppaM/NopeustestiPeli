using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NopeusPeli
{
    public partial class HighscoreForm : Form
    {
        public List<Pelaaja> HighScores = new List<Pelaaja>();
        private const string HighScoresFile = "highscores.json";
        public HighscoreForm()
        {
            InitializeComponent();

            LoadHighScoresFromFile();
            updateHighScoreList();

        }

        private void updateHighScoreList()
        {
            // Tyhjennetään lista
            this.listViewHighScores.Items.Clear();


            // Lisätään kaikki autot listaan
            foreach (var item in HighScores)
            {
                // Lisätään listalla uusi ListViewItem
                // Alustetaan uusi LisViewItem käyttäen muodostinta, joka ottaa vastaan string-taulukon.
                // Alustetaan uusi string-taulukko ja asetetaan samalla arvot taulukolle: jokainen car-luokan instanssin
                // ominaisuus omana alkiona.
                this.listViewHighScores.Items.Add(new ListViewItem(new string[] { item.Nimi, item.Pisteet.ToString() }));
            }

        }

        public void SaveHighScoresToFile()
        {
            // Tallennetaan cars-lista JSON-muotoiltuna tiedostoon.
            // Muunnetaan cars-lista json merkkijonoksi.
            string carsJson = System.Text.Json.JsonSerializer.Serialize(HighScores);

            // tallennetaan merkkijono tekstinä tiedostoon.
            System.IO.File.WriteAllText(HighScoresFile, carsJson);
        }

        public void LoadHighScoresFromFile()
        {
            // Luetaan JSON-muotoiltu tiedosto ja viedään sisältö cars-listaan.
            if (System.IO.File.Exists(HighScoresFile))
            {
                string jsonData = System.IO.File.ReadAllText(HighScoresFile);
                // Muunnetaan (deserialize) json muotoinen teksti objekteiksi.
                // Ja sijoitetaan cars-listaan.
                HighScores = System.Text.Json.JsonSerializer.Deserialize<List<Pelaaja>>(jsonData);
            }


        }
    }
}
