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
    public partial class ProductView: Form
    {
        private SqlConnection DatabaseConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jgadmin\\Documents\\ProNaturBiomarkt.mdf;Integrated Security=True;Connect Timeout=30");
        private int LastSelectedProductKey;

        public ProductView()
        {
            InitializeComponent();

            showProducts();
        }

        private void showProducts()
        {
            DatabaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, DatabaseConnection);

            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);

            dgw_ProductTable.DataSource = dataset.Tables[0];

            dgw_ProductTable.Columns[0].Visible = false;

            DatabaseConnection.Close();
        }

        

        private void btn_ProductSave_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == null || tb_Marke.Text == null || tb_Preis.Text == null ||cb_Kategorie.SelectedItem == null)
            {
                MessageBox.Show("Nicht vollständig ausgefüllt! Alle Fleder müssen ausgefüllt sein zum einfügen eines neuen Proukts");
                return;
            }

            string ProductName = tb_Name.Text;
            string ProductBrand = tb_Marke.Text;
            string ProductKategorie = cb_Kategorie.Text;
            string ProductPrice = tb_Preis.Text;

            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", ProductName, ProductBrand,ProductKategorie,ProductPrice);
            Executequery(query);

            ClearAllFields();
            showProducts();
        }

        private void btn_ProductEdit_Click(object sender, EventArgs e)
        {
            if(LastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus!");
                return;
            }
            else
            {
                string ProductName = tb_Name.Text;
                string ProductBrand = tb_Marke.Text;
                string ProductKategorie = cb_Kategorie.Text;
                string ProductPrice = tb_Preis.Text;

                string query = string.Format("update Products set Name='{0}', Marke='{1}', Kategorie='{2}', Preis='{3}' where ID={4};"
                                             , ProductName, ProductBrand, ProductKategorie, ProductPrice, LastSelectedProductKey);
                Executequery(query);
            }

                showProducts();
        }

        private void btn_ProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {
            if(LastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus!");
                return;
            }
            else
            {
                string query = string.Format("delete from Products where ID ={0};",LastSelectedProductKey);
                Executequery(query);
            }

            ClearAllFields();
            showProducts();
        }
        public void ClearAllFields()
        {
            tb_Name.Text = "";
            tb_Marke.Text = "";
            tb_Preis.Text = "";
            cb_Kategorie.Text = "";
            cb_Kategorie.SelectedItem = null;
        }

        private void dgw_ProductTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Name.Text = dgw_ProductTable.SelectedRows[0].Cells[1].Value.ToString();
            tb_Marke.Text = dgw_ProductTable.SelectedRows[0].Cells[2].Value.ToString();
            cb_Kategorie.Text = dgw_ProductTable.SelectedRows[0].Cells[3].Value.ToString();
            tb_Preis.Text = dgw_ProductTable.SelectedRows[0].Cells[4].Value.ToString();

            LastSelectedProductKey = (int)dgw_ProductTable.SelectedRows[0].Cells[0].Value;
        }

        public void Executequery(string query)
        {
            DatabaseConnection.Open();           
            SqlCommand sqlCommand = new SqlCommand(query, DatabaseConnection);
            sqlCommand.ExecuteNonQuery();
            DatabaseConnection.Close();
        }

        private void btn_BackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuScreen mainMenuScreen = new MainMenuScreen();
            mainMenuScreen.Show();
            this.Hide();
        }
    }
}
