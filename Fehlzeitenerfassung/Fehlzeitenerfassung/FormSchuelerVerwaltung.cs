using Fehlzeitenerfassung.IO.CSVHandler;
using Fehlzeitenerfassung.IO.DataProvider;
using Fehlzeitenerfassung.Storage;
using Fehlzeitenerfassung.Structure.Person.Lehrer;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

        private async void FormSchuelerVerwaltung_Load(object sender, System.EventArgs e)
        {
            //Initialisierung von Schnittstellenimplementationen
            Storages.Init();
            DataProvider.Init();
            CSVHandler.Init();

            //Lehrerdaten in den InMemoryStorage einlesen
            //Storages.InMemoryStorage.Store("Lists.Lehrer", CSVHandler.LehrerHandler.Convert(CSVHandler.ParseLines((await DataProvider.FileContentDataProvider.ProvideAsync<string>(new string[] { "Lehrer.csv" })).Split('\n'), ';')));
            Storages.InMemoryStorage.Store("Lists.Lehrer", new List<Lehrer>());
            //Combobox-Einträge hinzufügen
            foreach (Lehrer lehrer in Storages.InMemoryStorage.Restore<List<Lehrer>>("Lists.Lehrer"))
                comboBoxBereichsleiter.Items.Add(lehrer.Name);
        }
    }
}
