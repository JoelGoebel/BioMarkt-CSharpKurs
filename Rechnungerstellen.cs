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
    public partial class Rechnungerstellen: Form
    {
        private SqlConnection DatabaseConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgadmin\\Documents\\ProNaturBiomarkt.mdf;Integrated Security=True;Connect Timeout=30");

        public Rechnungerstellen()
        {
            InitializeComponent();
        }

        private void btn_CreateInvoice_Click(object sender, EventArgs e)
        {
            string KundenID = tb_KundenID_Rechnungerstellen.Text;
            if (KundenID == "")
            {
                MessageBox.Show("Bitte trage zu erst eine KundenID ein");
                return;
            }

            int RechnungsID = RechnungAnlegen(KundenID);

            Dictionary<string, int> Produkte_Menge = TextBoxenAuslesen();

            foreach (KeyValuePair<string,int> Product in Produkte_Menge)
            {
                ConnectInvoiceWithProducts(RechnungsID, Product.Key, Product.Value);
            }
                                    
            Rechnungeinsehen rechnungseinsehen = new Rechnungeinsehen();
            rechnungseinsehen.Show();
            this.Hide();
        }

        public void ConnectInvoiceWithProducts(int RechnungID,string ProduktName, int ProduktMenge)
        {
            string query = string.Format("select * From Products where Name='{0}';",ProduktName);

            int ProduktID;
            decimal price;

            DatabaseConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, DatabaseConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                ProduktID = reader.GetInt32(0);
                price = decimal.Parse(reader.GetString(4));
            }
            else
            {
                MessageBox.Show($"Das Produkt {ProduktName} wurde nicht gefunden");
                return;
            }
            reader.Close();
            //TODO Überprüfen warum nicht in DB eingetragen wurde
            string query2 = string.Format("insert into Rechnungspositionen values('{0}','{1}','{2}','{3}','{4}')",RechnungID,ProduktID,ProduktMenge,price,price*ProduktMenge);

            SqlCommand sqlCommand2 = new SqlCommand(query, DatabaseConnection);
            sqlCommand2.ExecuteNonQuery();

            DatabaseConnection.Close();
        }

        public int RechnungAnlegen(string KundenID)
        {
            DateTime Today = DateTime.Now;
            string Datum = Today.ToString("dd.MM.yyyy");
            string query = string.Format("insert into Rechnung values('{0}','{1}','{2}','{3}')",KundenID,Datum,0,"Offen")+"SELECT SCOPE_IDENTITY();";
            DatabaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, DatabaseConnection);
            sqlCommand.ExecuteNonQuery();
            int rechnungsID = Convert.ToInt32(sqlCommand.ExecuteScalar());
            DatabaseConnection.Close();
            return rechnungsID;
        }

        private Dictionary<string,int> TextBoxenAuslesen()
        {
            Dictionary<string, int> Produkte_Menge = new Dictionary<string, int>();

            if (tb_Produkt1_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt1_erstellen.Text, int.Parse(tb_Produkt1Menge_erstellen.Text)); }
            if (tb_Produkt2_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt2_erstellen.Text, int.Parse(tb_Produkt2Menge_erstellen.Text)); }
            if (tb_Produkt3_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt3_erstellen.Text, int.Parse(tb_Produkt3Menge_erstellen.Text)); }
            if (tb_Produkt4_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt4_erstellen.Text, int.Parse(tb_Produkt4Menge_erstellen.Text)); }
            if (tb_Produkt5_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt5_erstellen.Text, int.Parse(tb_Produkt5Menge_erstellen.Text)); }
            if (tb_Produkt6_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt6_erstellen.Text, int.Parse(tb_Produkt6Menge_erstellen.Text)); }
            if (tb_Produkt7_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt7_erstellen.Text, int.Parse(tb_Produkt7Menge_erstellen.Text)); }
            if (tb_Produkt8_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt8_erstellen.Text, int.Parse(tb_Produkt8Menge_erstellen.Text)); }
            if (tb_Produkt9_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt9_erstellen.Text, int.Parse(tb_Produkt9Menge_erstellen.Text)); }
            if (tb_Produkt10_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt10_erstellen.Text, int.Parse(tb_Produkt10Menge_erstellen.Text)); }
            if (tb_Produkt11_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt11_erstellen.Text, int.Parse(tb_Produkt11Menge_erstellen.Text)); }
            if (tb_Produkt12_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt12_erstellen.Text, int.Parse(tb_Produkt12Menge_erstellen.Text)); }
            if (tb_Produkt13_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt13_erstellen.Text, int.Parse(tb_Produkt13Menge_erstellen.Text)); }
            if (tb_Produkt14_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt14_erstellen.Text, int.Parse(tb_Produkt14Menge_erstellen.Text)); }
            if (tb_Produkt15_erstellen.Text != "") { Produkte_Menge.Add(tb_Produkt15_erstellen.Text, int.Parse(tb_Produkt15Menge_erstellen.Text)); }
            return Produkte_Menge;
        }
    }
}
