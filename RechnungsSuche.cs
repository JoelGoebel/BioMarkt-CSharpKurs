using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNaturBiomarkt
{
    public partial class RechnungsSuche: Form
    {
        private SqlConnection DatabaseConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgadmin\\Documents\\ProNaturBiomarkt.mdf;Integrated Security=True;Connect Timeout=30");

        public RechnungsSuche()
        {
            InitializeComponent();

            showRechnungen();
        }

        private void btn_RechnungEinsehen_Click(object sender, EventArgs e)
        {
            Rechnungeinsehen rechnungseinsehen = new Rechnungeinsehen();
            rechnungseinsehen.Show();
            this.Hide();
        }
        private void showRechnungen()
        {
            DatabaseConnection.Open();

            string query = "select * from Rechnung";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, DatabaseConnection);

            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);

            dgv_Rechnungen.DataSource = dataset.Tables[0];
            
            DatabaseConnection.Close();
        }

        private void btn_Rechnungerstellen_Click(object sender, EventArgs e)
        {
            Rechnungerstellen rechnungserstellen = new Rechnungerstellen();
            rechnungserstellen.Show();
            this.Hide();
        }

        private void btn_backToMainmenu_Click(object sender, EventArgs e)
        {
            MainMenuScreen mainMenuScreen = new MainMenuScreen();
            mainMenuScreen.Show();
            this.Hide();
        }
    }
}
