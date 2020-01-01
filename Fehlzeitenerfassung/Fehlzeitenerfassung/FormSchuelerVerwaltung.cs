using Fehlzeitenerfassung.IO.CSVHandler;
using Fehlzeitenerfassung.IO.DataProvider;
using Fehlzeitenerfassung.IO.DataWriter;
using Fehlzeitenerfassung.Storage;
using Fehlzeitenerfassung.Structure.Person.Lehrer;
using Fehlzeitenerfassung.Structure.Person.Schueler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Fehlzeitenerfassung
{
    public partial class FormSchuelerVerwaltung : Form
    {
        public FormSchuelerVerwaltung()
        {
            InitializeComponent();
        }

        private async void FormSchuelerVerwaltung_Load(object sender, System.EventArgs e)
        {
            //Initialisierung von Schnittstellenimplementationen
            Storages.Init();
            DataProvider.Init();
            DataWriter.Init();
            CSVHandler.Init();

            //Daten in den InMemoryStorage einlesen

            //Lehrer

            List<Lehrer> lehrerListe;
            try
            {
                lehrerListe = CSVHandler.LehrerHandler.Convert(CSVHandler.ParseLines((await DataProvider.FileContentDataProvider.ProvideAsync(new string[] { "Lehrer.csv" })).Split('\n'), ';'));
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Es wurde keine Lehrer.csv gefunden!\nBitte legen Sie diese im Programmverzeichnis manuell an!\nEine Vorlage liegt dem Projekt im Vorlagen-Ordner bei oder ist auf der GitHub-Seite zu finden.", "Lehrer.csv fehlt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten!\n" + ex.StackTrace.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }
            Storages.InMemoryStorage.Store("Lists.Lehrer", lehrerListe);

            //Schueler
            List<Schueler> schuelerListe;
            try
            {
                schuelerListe = CSVHandler.SchuelerHandler.Convert(CSVHandler.ParseLines((await DataProvider.FileContentDataProvider.ProvideAsync(new string[] { "Schueler.csv" })).Split('\n'), ';'));
            }
            catch (FileNotFoundException)
            {
                schuelerListe = new List<Schueler>();
                MessageBox.Show("Es wurde keine Schueler.csv gefunden!\nSollte es der erste Start des Programms sein, ist dies normal.", "Schueler.csv fehlt!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten!\n" + ex.StackTrace.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }
            Storages.InMemoryStorage.Store("Lists.Schueler", schuelerListe);

            //Combobox-Einträge hinzufügen

            //Lehrer
            foreach (Lehrer lehrer in Storages.InMemoryStorage.Restore<List<Lehrer>>("Lists.Lehrer"))
                comboBoxBereichsleiter.Items.Add($"{lehrer.Name} {lehrer.Vorname}");

            //Schueler
            foreach (Schueler schueler in Storages.InMemoryStorage.Restore<List<Schueler>>("Lists.Schueler"))
                comboBoxFehlzeitenAnzeigenSchueler.Items.Add($"{schueler.Name} {schueler.Vorname}");

            //Falls Einträge vorhanden, ersten Eintrag automatisch auswählen
            if (comboBoxBereichsleiter.Items.Count > 0)
                comboBoxBereichsleiter.SelectedIndex = 0;

            if (comboBoxFehlzeitenAnzeigenSchueler.Items.Count > 0)
                comboBoxFehlzeitenAnzeigenSchueler.SelectedIndex = 0;
        }
    }
}
