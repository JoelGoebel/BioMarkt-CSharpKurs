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

            InitializeComponent();
            Rechnung rechnung = GetDataForInvoice(rechnungsID);

            InsertDataInGUI(rechnung);

        }


        public void InsertDataInGUI(Rechnung rechnung)
        {
            lbl_KundenName.Text = rechnung.Ku_Name + " " + rechnung.Ku_LastName;
            lbl_KundenAdress.Text = rechnung.Ku_Adress;
            lbl_RECHNUNG.Text = lbl_RECHNUNG.Text + " " + rechnung.Re_Invoice_ID.ToString();
            lbl_Rechnungsnummer.Text = rechnung.Re_Invoice_ID.ToString();
            lbl_Rechnungsdatum.Text = rechnung.Re_Date.ToString("dd.MM.yyyy");
            lbl_Faelligkeitsdatum.Text = rechnung.Re_DueDate.ToString("dd.MM.yyyy");             

            Decimal GesammtSumme = 0;
            //Get Total Price of Invoice
            for (int i = 0; i < rechnung.RePo_TotalPrice.Count; i++)
            {
                GesammtSumme += rechnung.RePo_TotalPrice[i];
            }
            Decimal NettoBetrag = Math.Round((GesammtSumme / 119) * 100,2);
            Decimal UsT = Math.Round(GesammtSumme - NettoBetrag,2);

            lbl_GesamtSumme.Text = GesammtSumme.ToString() + "€";
            lbl_Nettobetrag.Text = NettoBetrag.ToString() + "€";
            lbl_UmsatzSteuer.Text = UsT.ToString() + "€";

            UpdateTotalPriceInvoice(rechnung.Re_Invoice_ID, GesammtSumme);
            
            DataSet ds = new DataSet();

            DataTable dt = new DataTable("Produkte");
            dt.Columns.Add("ProduktID", typeof(int));
            dt.Columns.Add("Bezeichnung", typeof(string));
            dt.Columns.Add("Marke", typeof(string));
            dt.Columns.Add("Einzelpreis", typeof(decimal));
            dt.Columns.Add("Menge", typeof(int));
            dt.Columns.Add("Gesamtpreis", typeof(decimal));

            for (int i = 0; i <rechnung.RePo_ProductID.Count; i++)
            {
                dt.Rows.Add( rechnung.RePo_ProductID[i], rechnung.Pro_Name[i], rechnung.Pro_Brand[i], rechnung.RePo_Price[i], rechnung.RePo_Amount[i], rechnung.RePo_TotalPrice[i]);
            }

            ds.Tables.Add(dt);

            dgv_RechnungsPositionen.DataSource = ds.Tables[0];


        }
        public void UpdateTotalPriceInvoice(int InvoiceID, Decimal TotalSum)
        {
            DatabaseConnection.Open();
            string query = "UPDATE Rechnung SET GesamtBetrag = @TotalSum WHERE Rechnungs_ID = @InvoiceID";
            SqlCommand sqlCommand = new SqlCommand(query, DatabaseConnection);
            sqlCommand.Parameters.AddWithValue("@TotalSum", TotalSum);
            sqlCommand.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            sqlCommand.ExecuteNonQuery();
            DatabaseConnection.Close();
        }

        public Rechnung GetDataForInvoice(int RechnungsID)
        {            
            //Aus Rechnungtabelle
            int re_Invoice_ID = RechnungsID;
            int re_CustomerID = 0;
            DateTime re_date = new DateTime(2025,1,1) ;
            DateTime re_DueDate = new DateTime(2025,1,1);
            //Aus Producttabelle
            List<string> pro_Name = new List<string>();
            List<string> pro_Brand = new List<string>();
            //Aus Rechnungspositionentabelle
            List<int> repo_ProductID = new List<int>();
            List<int> repo_Amount = new List<int>();
            List<Decimal> repo_Price = new List<decimal>();
            List<Decimal> repo_TotalPrice = new List<decimal>();
            //Aus Kundetabelle
            string ku_Name = "";
            string ku_LastName = "";
            string ku_Adress = "";

            
            DatabaseConnection.Open();

            //Daten aus Rechnungstabelle
            string query = string.Format("select * From Rechnung where Rechnungs_ID='{0}'", re_Invoice_ID);
            SqlCommand sqlCommand = new SqlCommand(query, DatabaseConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                re_CustomerID = reader.GetInt32(1);
                re_date = DateTime.Parse(reader.GetString(2));
                re_DueDate = re_date.AddDays(30);
            }
            else
            {
                MessageBox.Show($"Die Rechnung mit der ID:{re_Invoice_ID} konnte nicht gefunden werden! Bitte überprüfe die Eingabe.");
                ;
            }
            reader.Close();

            //Daten aus Kundentabelle
            query = string.Format("select * From Kunden where kunde_id='{0}'", re_CustomerID);
            sqlCommand = new SqlCommand(query, DatabaseConnection);
            reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                ku_Name = reader.GetString(1);
                ku_LastName = reader.GetString(2);
                ku_Adress = reader.GetString(4);
            }
            else
            {
                MessageBox.Show($"Es konnte kein Kunde mit der ID:{re_CustomerID} gefunden werden.");
                //return;
            }
            reader.Close();

            //Daten aus Rechnungspositionentabelle
            query = string.Format("select * From Rechnungspositionen where rechnung_id='{0}'", re_Invoice_ID);
            sqlCommand = new SqlCommand(query, DatabaseConnection);
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                repo_ProductID.Add(reader.GetInt32(1));
                repo_Amount.Add(reader.GetInt32(2));
                repo_Price.Add(reader.GetDecimal(3));
                repo_TotalPrice.Add(reader.GetDecimal(4));
            }
            reader.Close();

            //Daten aus Productstabelle
            for (int i = 0; i < repo_ProductID.Count; i++)
            {
                query = string.Format("select * From Products where ID='{0}'", repo_ProductID[i]);
                sqlCommand = new SqlCommand(query, DatabaseConnection);
                reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    
                    pro_Name.Add(reader.GetString(1));
                    pro_Brand.Add(reader.GetString(2));
                }
                else
                {
                    MessageBox.Show($"Das Product mit der ID:{repo_ProductID[i]} konnte nicht gefunden werden.");
                   // return;
                }
                reader.Close();
            }
            DatabaseConnection.Close();

            //Rechnungsobject anlegen
            Rechnung rechnung = new Rechnung(re_Invoice_ID,re_CustomerID,re_date,re_DueDate,pro_Name,pro_Brand,repo_ProductID,repo_Amount,repo_Price,repo_TotalPrice,ku_Name,ku_LastName,ku_Adress);
            return rechnung;
        }


        private void btn_zurück_Click(object sender, EventArgs e)
        {
            RechnungsSuche rechnungsSuche = new RechnungsSuche();
            rechnungsSuche.Show();
            this.Hide();
        }
    }
}
