using System;
using System.Collections.Generic;
using System.Text;

namespace NopeusPeli
{
    public class Pelaaja
    {
        public string Nimi { get; set; }
        public int Pisteet { get; set; }


        public Pelaaja()
        {
            // Oletusmuodostin, jotta tätä luokkaa voidaan käyttää myös deserialisoinnissa.
        }

        public Pelaaja(int pisteet, string nimi)
        {
            Nimi = nimi;
            Pisteet = pisteet;
           
        }
    }
}
