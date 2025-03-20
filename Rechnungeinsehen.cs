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
    public partial class Rechnungeinsehen: Form
    {
        private SqlConnection DatabaseConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgadmin\\Documents\\ProNaturBiomarkt.mdf;Integrated Security=True;Connect Timeout=30");

        public int RechnungsID { get; private set; }
        public Rechnungeinsehen(int rechnungsID)
        {
            RechnungsID = rechnungsID;

            InitializeComponent();
            
        }

        public void DatenAuslesen(int RechnungsID)
        {
            string query = string.Format("select KundenID, Datum From Rechnung where Rechnungs_ID='{0}'",RechnungsID);
            int KundenID;


            DatabaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, DatabaseConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                
            }


        }


        private void btn_zurück_Click(object sender, EventArgs e)
        {
            RechnungsSuche rechnungsSuche = new RechnungsSuche();
            rechnungsSuche.Show();
            this.Hide();
        }
    }
}
