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
        public List<Fehlzeit> Fehlzeiten { get; set; }

        public Schueler(string name, string vorname, DateTime geburtstag, double anfahrtsweg, bool buskarte) : base(name, vorname, geburtstag)
        {
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag.Date; //Entfernt Zeit
            Anfahrtsweg = anfahrtsweg;
            Buskarte = buskarte;
            Fehlzeiten = new List<Fehlzeit>();
        }

        public Schueler(string name, string vorname, DateTime geburtstag, double anfahrtsweg, bool buskarte, List<Fehlzeit> fehlzeiten) : base(name, vorname, geburtstag)
        {
            Name = name;
            Vorname = vorname;
            Geburtstag = geburtstag;
            Anfahrtsweg = anfahrtsweg;
            Buskarte = buskarte;
            Fehlzeiten = fehlzeiten;
        }

        public override string ToString() => $"Name: {Name}\nVorname: {Vorname}\nAlter: {(DateTime.Now.Date - Geburtstag).Days / 365}\nAnfahrtsweg: {Anfahrtsweg}\nBuskarte: {Buskarte}\nFehlstunden: {FehlzeitenSumme()} (E:{EntschuldigteStundenSumme()}/{UnentschuldigteStundenSumme()}:U)";

        public bool HatGefehltAm(DateTime datum) => Fehlzeiten.Any(fehlzeit => fehlzeit.Datum == datum.Date); //datum.Date, um Zeit zu ignorieren, falls ausversehen angegeben
        public int FehlzeitenSumme() => Fehlzeiten.Select(fehlzeit => fehlzeit.Fehlstunden).Sum();
        public int EntschuldigteStundenSumme() => Fehlzeiten.Select(fehlzeit => fehlzeit.EntschuldigteStunden).Sum();
        public int UnentschuldigteStundenSumme() => Fehlzeiten.Select(fehlzeit => fehlzeit.UnentschuldigteStunden).Sum();
        public void RegistriereFehlstunde(DateTime datum, int fehlstunden, int entschuldigteStunden) => Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, entschuldigteStunden));
        public void RegistriereFehlstunde(DateTime datum, int fehlstunden, bool entschuldigt) => Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, entschuldigt));
        public void RegistriereFehlstunde(DateTime datum, int fehlstunden) => Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, false));
        public void RegistriereFehlstunde(int fehlstunden) => Fehlzeiten.Add(new Fehlzeit(DateTime.Now, fehlstunden, false));
        public void UnregistriereFehlstunde(Fehlzeit fehlzeit) => Fehlzeiten.Remove(fehlzeit);
        public void UnregistriereFehlstunde(DateTime datum) => Fehlzeiten.Remove(Fehlzeiten.Where(fehlstunde => fehlstunde.Datum == datum.Date).FirstOrDefault());
    }
}
