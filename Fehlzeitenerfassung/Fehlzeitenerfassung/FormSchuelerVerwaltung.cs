using Fehlzeitenerfassung.IO.CSVIO;
using Fehlzeitenerfassung.Storage;
using System.Windows.Forms;

namespace Fehlzeitenerfassung
{
    public partial class FormSchuelerVerwaltung : Form
    {
        public FormSchuelerVerwaltung()
        {
            InitializeComponent();
        }

        private void FormSchuelerVerwaltung_Load(object sender, System.EventArgs e)
        {
            Storages.Init();
            CSVIO.Init();

            MessageBox.Show("Initiated");
        }
    }
}
