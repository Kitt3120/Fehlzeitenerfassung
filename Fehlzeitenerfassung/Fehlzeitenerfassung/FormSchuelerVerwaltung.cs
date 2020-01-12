using Fehlzeitenerfassung.IO.CSVHandler;
using Fehlzeitenerfassung.IO.DataProvider;
using Fehlzeitenerfassung.IO.DataWriter;
using Fehlzeitenerfassung.Storage;
using Fehlzeitenerfassung.Structure.Person.Lehrer;
using Fehlzeitenerfassung.Structure.Person.Schueler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fehlzeitenerfassung
{
    public partial class FormSchuelerVerwaltung : Form
    {
        public FormSchuelerVerwaltung()
        {
            InitializeComponent();
        }

        /*
         * Main
         */

        private async void FormSchuelerVerwaltung_Load(object sender, System.EventArgs e)
        {
            /*
             * Initialisierung von Schnittstellenimplementationen
             */
            Storages.Init();
            DataProvider.Init();
            DataWriter.Init();
            CSVHandler.Init();

            /*
             * Daten in den InMemoryStorage einlesen
             */

            //Lehrer
            try
            {
                await LoadData("Lehrer.csv", DataType.Lehrer);
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

            //Schueler (werden manuell eingelesen)
            Storages.InMemoryStorage.Store("Lists.Schueler", new List<Schueler>());

            //Nach Auslesen GUI refreshen
            RefreshGui();
        }

        /*
         * Buttons
         */

        private void buttonSchuelerVerwaltenSchuelerAnlegen_Click(object sender, EventArgs e)
        {
            string name = textBoxSchuelerVerwaltenName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Es muss ein Name angegeben werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vorname = textBoxSchuelerVerwaltenVorname.Text;
            if (string.IsNullOrWhiteSpace(vorname))
            {
                MessageBox.Show("Es muss ein Vorname angegeben werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime geburtstag;
            if (!DateTime.TryParse(textBoxSchuelerVerwaltenGeburtsdatum.Text, out geburtstag))
            {
                MessageBox.Show("Das Geburtsdatum ist ungültig!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double anfahrtsweg;
            if (!double.TryParse(textBoxSchuelerVerwaltenAnfahrt.Text, out anfahrtsweg))
            {
                MessageBox.Show("Der Anfahrtsweg ist ungültig!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool buskarte = checkBoxSchuelerVerwaltenBusfahrkarte.Checked;
            if (buskarte && anfahrtsweg < 5.0D)
            {
                MessageBox.Show("Eine Buskarte kann erst vergeben werden, wenn der Anfahrtsweg einen größeren Wert als 5km beträgt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Storages.InMemoryStorage.Access<List<Schueler>>("Lists.Schueler").Add(new Schueler(name, vorname, geburtstag, anfahrtsweg, buskarte));
            RefreshGui();
            MessageBox.Show("Schüler erfolgreich hinzugefügt!", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonFehlzeitenVerwaltenFehlzeitAnlegen_Click(object sender, EventArgs e)
        {
            Schueler schueler;
            if (comboBoxFehlzeitenVerwaltenSchueler.SelectedItem == null)
            {
                MessageBox.Show("Kein Schüler ausgewählt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                schueler = (Schueler)comboBoxFehlzeitenVerwaltenSchueler.SelectedItem;

            DateTime datum;
            if (!DateTime.TryParse(textBoxFehlzeitenVerwaltenDatum.Text, out datum))
            {
                MessageBox.Show("Das Datum ist ungültig!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int fehlstunden;
            if (!int.TryParse(textBoxFehlzeitenVerwaltenAnzahlFehlstunden.Text, out fehlstunden))
            {
                MessageBox.Show("Die Anzahl an Fehlstunden ist ungültig!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int entschuldigteStunden;
            if (!int.TryParse(textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt.Text, out entschuldigteStunden))
            {
                MessageBox.Show("Die Anzahl an unentschuldigten Fehlstunden ist ungültig!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            schueler.RegistriereFehlstunde(datum, fehlstunden, entschuldigteStunden);
            RefreshGui();
            MessageBox.Show("Fehlzeit erfolgreich hinzugefügt!", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void buttonFehlzeitenAnzeigenDatenLaden_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Schülerdatei auslesen";
            openFileDialog.Filter = "CSV-Dateien (*.csv)|*.csv|Alle Dateien (*.*)|*.*";
            openFileDialog.CheckPathExists = true;
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await LoadData(openFileDialog.FileName, DataType.Schueler);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten!\n" + ex.StackTrace.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshGui();
            }
        }

        private async void buttonFehlzeitenAnzeigenDatenSichern_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Schülerdatei speichern";
            saveFileDialog.Filter = "CSV-Dateien (*.csv)|*.csv|Alle Dateien (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await SaveData(saveFileDialog.FileName, DataType.Schueler);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein unbekannter Fehler aufgetreten!\n" + ex.StackTrace.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*
         * Verhalten
         */

        private void textBoxSchuelerVerwaltenAnfahrt_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (string.IsNullOrWhiteSpace(textBoxSchuelerVerwaltenAnfahrt.Text) || !double.TryParse(textBoxSchuelerVerwaltenAnfahrt.Text, out d) || d < 5.0D)
            {
                checkBoxSchuelerVerwaltenBusfahrkarte.Enabled = false;
                checkBoxSchuelerVerwaltenBusfahrkarte.Checked = false;
            }
            else
            {
                checkBoxSchuelerVerwaltenBusfahrkarte.Enabled = true;
            }
        }

        private void comboBoxFehlzeitenAnzeigenSchueler_SelectedIndexChanged(object sender, EventArgs e) => Statusausgabe();

        private void checkBoxFehlzeitenAnzeigenDetails_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFehlzeitenAnzeigenAusgabe.Clear();
            Statusausgabe();
        }

        private void Statusausgabe()
        {
            if (comboBoxFehlzeitenAnzeigenSchueler.SelectedItem != null)
            {
                Schueler schueler = (Schueler)comboBoxFehlzeitenAnzeigenSchueler.SelectedItem;
                if (checkBoxFehlzeitenAnzeigenDetails.Checked)
                {
                    textBoxFehlzeitenAnzeigenAusgabe.Text = $"{schueler.ToString()}";
                    foreach (Fehlzeit fehlzeit in schueler.Fehlzeiten)
                        textBoxFehlzeitenAnzeigenAusgabe.Text += $"{Environment.NewLine}{fehlzeit.Datum.ToString("dd/MM/yyyy")} - {fehlzeit.Fehlstunden} Fehlstunden ({fehlzeit.EntschuldigteStunden} entschuldigt)";
                    textBoxFehlzeitenAnzeigenAusgabe.Text += $"{Environment.NewLine}Insgesamt {schueler.FehlzeitenSumme()} Fehlstunden, davon sind {schueler.EntschuldigteStundenSumme()} entschuldigt und {schueler.UnentschuldigteStundenSumme()} unentschuldigt.{Environment.NewLine}";
                }
                else
                    textBoxFehlzeitenAnzeigenAusgabe.Text += $"Schüler {schueler.ToString()} hat insgesamt {schueler.FehlzeitenSumme()} Fehlstunden, davon sind {schueler.EntschuldigteStundenSumme()} entschuldigt und {schueler.UnentschuldigteStundenSumme()} unentschuldigt.{Environment.NewLine}";

                //Scrollt automatisch ans Ende des Textes
                textBoxFehlzeitenAnzeigenAusgabe.SelectionStart = textBoxFehlzeitenAnzeigenAusgabe.Text.Length;
                textBoxFehlzeitenAnzeigenAusgabe.ScrollToCaret();
            }
        }

        private void RefreshGui()
        {
            /*
             * Einträge leeren
             */

            comboBoxBereichsleiter.Items.Clear();
            comboBoxFehlzeitenVerwaltenSchueler.Items.Clear();
            comboBoxFehlzeitenAnzeigenSchueler.Items.Clear();
            textBoxFehlzeitenAnzeigenAusgabe.Clear();

            /*
             * Combobox-Einträge hinzufügen
             */

            //Lehrer
            foreach (Lehrer lehrer in Storages.InMemoryStorage.Access<List<Lehrer>>("Lists.Lehrer"))
                comboBoxBereichsleiter.Items.Add(lehrer);

            //Schueler
            foreach (Schueler schueler in Storages.InMemoryStorage.Access<List<Schueler>>("Lists.Schueler"))
            {
                comboBoxFehlzeitenVerwaltenSchueler.Items.Add(schueler);
                comboBoxFehlzeitenAnzeigenSchueler.Items.Add(schueler);
            }

            //Falls Einträge vorhanden, ersten Eintrag automatisch auswählen
            if (comboBoxBereichsleiter.Items.Count > 0)
                comboBoxBereichsleiter.SelectedIndex = 0;

            if (comboBoxFehlzeitenVerwaltenSchueler.Items.Count > 0)
            {
                comboBoxFehlzeitenVerwaltenSchueler.SelectedIndex = 0;
                comboBoxFehlzeitenAnzeigenSchueler.SelectedIndex = 0;
            }
        }

        /*
         * Methoden, um einfach Daten auszulesen / zu speichern
         */

        private enum DataType
        {
            Lehrer, Schueler
        }

        private async Task LoadData(string path, DataType dataType)
        {
            string content = await DataProvider.FileContentDataProvider.ProvideAsync(new string[] { path });
            string[][] parsedLines = CSVHandler.ParseLines(content.Split('\n'), ';');

            switch (dataType)
            {
                case DataType.Lehrer:
                    Storages.InMemoryStorage.Store("Lists.Lehrer", CSVHandler.LehrerHandler.Convert(parsedLines));
                    break;

                case DataType.Schueler:
                    Storages.InMemoryStorage.Store("Lists.Schueler", CSVHandler.SchuelerHandler.Convert(parsedLines));
                    break;

                default:
                    break;
            }
        }

        private async Task SaveData(string path, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Lehrer:
                    await DataWriter.FileContentDataWriter.WriteAsync(string.Join("\n", CSVHandler.ComposeLines(CSVHandler.LehrerHandler.Revert(Storages.InMemoryStorage.Access<List<Lehrer>>("Lists.Lehrer")), ';')), new string[] { path });
                    break;

                case DataType.Schueler:
                    await DataWriter.FileContentDataWriter.WriteAsync(string.Join("\n", CSVHandler.ComposeLines(CSVHandler.SchuelerHandler.Revert(Storages.InMemoryStorage.Access<List<Schueler>>("Lists.Schueler")), ';')), new string[] { path });
                    break;

                default:
                    break;
            }
        }
    }
}