using Fehlzeitenerfassung.IO.CSVIOHandler;
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
            CSVIO.Init();

            MessageBox.Show("CSVIO Initiated");
        }
    }
}
