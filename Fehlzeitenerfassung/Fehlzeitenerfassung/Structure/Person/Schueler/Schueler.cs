using Fehlzeitenerfassung.Structure.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeitenerfassung.Structure.Person.Schueler
{
    class Schueler : Person
    {
        public double Anfahrtsweg { get; set; }
        public bool Buskarte { get; set; }
        public List<Fehlstunde> Fehlstunden { get; set; }

        public Schueler(string name, string vorname, DateTime geburtstag, double anfahrtsweg, bool buskarte) : base(name, vorname, geburtstag)
        {
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag.Date; //Entfernt Zeit
            Anfahrtsweg = anfahrtsweg;
            Buskarte = buskarte;
            Fehlstunden = new List<Fehlstunde>();
        }

        public Schueler(string name, string vorname, DateTime geburtstag, double anfahrtsweg, bool buskarte, List<Fehlstunde> fehlstunden) : base(name, vorname, geburtstag)
        {
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag;
            Anfahrtsweg = anfahrtsweg;
            Buskarte = buskarte;
            Fehlstunden = fehlstunden;
            Fehlstunden = new List<Fehlstunde>();
        }

        public override string ToString() => $"Name: {Name}\nVorname: {Vorname}\nAlter: {(DateTime.Now.Date - Geburtstag).Days / 365}\nAnfahrtsweg: {Anfahrtsweg}\nBuskarte: {Buskarte}\nFehlstunden: {FehlstundenSumme(false)}\nDavon unentschuldigt: {FehlstundenSumme(false)}";

        public bool HatGefehltAm(DateTime date) => Fehlstunden.Any(fehlstunde => fehlstunde.Datum == date.Date); //date.Date, um Zeit zu ignorieren, falls ausversehen angegeben
        public int FehlstundenSumme() => Fehlstunden.Select(fehlstunde => fehlstunde.Fehlstunden).Sum();
        public int FehlstundenSumme(bool berücksichtigeEntschuldigte)
        {
            int summe = FehlstundenSumme();
            if (berücksichtigeEntschuldigte)
                summe -= EntschuldigteStundenSumme();
            return summe;
        }
        public int EntschuldigteStundenSumme() => Fehlstunden.Select(fehlstunde => fehlstunde.EntschuldigteStunden).Sum();
        public void RegistriereFehlstunde(DateTime date, int fehlstunden, int entschuldigteStunden) => Fehlstunden.Add(new Fehlstunde(date, fehlstunden, entschuldigteStunden));
        public void RegistriereFehlstunde(DateTime date, int fehlstunden, bool entschuldigt) => Fehlstunden.Add(new Fehlstunde(date, fehlstunden, entschuldigt));
        public void RegistriereFehlstunde(DateTime date, int fehlstunden) => Fehlstunden.Add(new Fehlstunde(date, fehlstunden, false));
        public void RegistriereFehlstunde(int fehlstunden) => Fehlstunden.Add(new Fehlstunde(DateTime.Now, fehlstunden, false));
        public void UnregistriereFehlstunde(Fehlstunde fehlstunde) => Fehlstunden.Remove(fehlstunde);
        public void UnregistriereFehlstunde(DateTime date) => Fehlstunden.Remove(Fehlstunden.Where(fehlstunde => fehlstunde.Datum == date.Date).FirstOrDefault());
    }
}
