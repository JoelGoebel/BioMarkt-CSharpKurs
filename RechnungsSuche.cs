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
            if (tb_Rechnungsnummer_suche.Text != "")
            {
                int rechnungsnummer = int.Parse(tb_Rechnungsnummer_suche.Text);
                Rechnungeinsehen rechnungseinsehen = new Rechnungeinsehen(rechnungsnummer);
                rechnungseinsehen.Show();
                this.Hide();
            }
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

        private void btn_RechnungSuchen_Click(object sender, EventArgs e)
        {
            string KundenID = tb_KundenID_Suche.Text;
            string Rechnungnummer = tb_Rechnungsnummer_suche.Text;
            string Status = cb_Status_Suche.Text;

            string query;

            if (KundenID != "" || Rechnungnummer != "" || Status != "")
            {
                if(Rechnungnummer != "")
                {
                    query = string.Format("select * From Rechnung where Rechnungs_ID='{0}';",Rechnungnummer);
                }
                else if(KundenID != "" && Status !="")
                {
                    query = string.Format("select * From Rechnung where KundenID='{0}' AND Status='{1}';", KundenID, Status);
                }
                else if(KundenID != "")
                {
                    query = string.Format("select * From Rechnung where KundenID='{0}';",KundenID);
                }
                else
                {
                    query = string.Format("select * From Rechnung where Status='{0}';", Status);
                }
                DatabaseConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, DatabaseConnection);
                DataSet dataset = new DataSet();

                sqlDataAdapter.Fill(dataset);
                dgv_Rechnungen.DataSource = dataset.Tables[0];

                DatabaseConnection.Close();
            }
            else
            {
                MessageBox.Show("bitte gebe zuerst einen Suchparameter ein");
                return;
            }
        }
    }
}
