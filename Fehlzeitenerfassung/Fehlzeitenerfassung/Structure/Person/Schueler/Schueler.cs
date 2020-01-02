using System;
using System.Collections.Generic;
using System.Linq;

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

        public void RegistriereFehlstunde(DateTime datum, int fehlstunden, int entschuldigteStunden)
        {
            datum = datum.Date; //Entfernt Zeit
            if (HatGefehltAm(datum))
            {
                Fehlzeit(datum).Fehlstunden += fehlstunden;
                Fehlzeit(datum).EntschuldigteStunden += entschuldigteStunden;
            }
            else
                Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, entschuldigteStunden));
        }

        public void RegistriereFehlstunde(DateTime datum, int fehlstunden, bool entschuldigt)
        {
            datum = datum.Date; //Entfernt Zeit
            if (HatGefehltAm(datum))
            {
                Fehlzeit(datum).Fehlstunden += fehlstunden;
                if (entschuldigt)
                    Fehlzeit(datum).EntschuldigteStunden += fehlstunden;
            }
            else
                Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, entschuldigt));
        }

        public void RegistriereFehlstunde(DateTime datum, int fehlstunden)
        {
            datum = datum.Date; //Entfernt Zeit
            if (HatGefehltAm(datum))
            {
                Fehlzeit(datum).Fehlstunden += fehlstunden;
            }
            else
                Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, 0));
        }

        public void RegistriereFehlstunde(int fehlstunden, int entschuldigteStunden)
        {
            DateTime datum = DateTime.Now.Date; //Entfernt Zeit
            if (HatGefehltAm(datum))
            {
                Fehlzeit(datum).Fehlstunden += fehlstunden;
                Fehlzeit(datum).EntschuldigteStunden += entschuldigteStunden;
            }
            else
                Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, entschuldigteStunden));
        }

        public void RegistriereFehlstunde(int fehlstunden)
        {
            DateTime datum = DateTime.Now.Date; //Entfernt Zeit
            if (HatGefehltAm(datum))
            {
                Fehlzeit(datum).Fehlstunden += fehlstunden;
            }
            else
                Fehlzeiten.Add(new Fehlzeit(datum, fehlstunden, 0));
        }

        public bool HatGefehltAm(DateTime datum) => Fehlzeiten.Any(fehlzeit => fehlzeit.Datum == datum.Date); //datum.Date, um Zeit zu ignorieren, falls angegeben
        public Fehlzeit Fehlzeit(DateTime datum) => Fehlzeiten.Where(fehlzeit => fehlzeit.Datum == datum.Date).FirstOrDefault();
        public int FehlzeitenSumme() => Fehlzeiten.Select(fehlzeit => fehlzeit.Fehlstunden).Sum();
        public int EntschuldigteStundenSumme() => Fehlzeiten.Select(fehlzeit => fehlzeit.EntschuldigteStunden).Sum();
        public int UnentschuldigteStundenSumme() => Fehlzeiten.Select(fehlzeit => fehlzeit.UnentschuldigteStunden).Sum();
        public void UnregistriereFehlstunde(Fehlzeit fehlzeit) => Fehlzeiten.Remove(fehlzeit);
        public void UnregistriereFehlstunde(DateTime datum) => Fehlzeiten.Remove(Fehlzeiten.Where(fehlstunde => fehlstunde.Datum == datum.Date).FirstOrDefault());
    }
}
