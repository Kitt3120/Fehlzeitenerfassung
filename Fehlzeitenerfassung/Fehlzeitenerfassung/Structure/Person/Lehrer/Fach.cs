﻿namespace Fehlzeitenerfassung.Structure.Person.Lehrer
{
    internal class Fach
    {
        public string Bezeichnung { get; set; }
        public string Kürzel { get; set; }

        public Fach(string bezeichnung, string kürzel)
        {
            Bezeichnung = bezeichnung;
            Kürzel = kürzel;
        }
    }
}