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


        public ProductView()
        {
            InitializeComponent();

            //Start
            DatabaseConnection.Open();
            DatabaseConnection.Close();
        }

        private void btn_ProductSave_Click(object sender, EventArgs e)
        {
            string ProductName = tb_Name.Text;
            string ProductBrand = tb_Marke.Text;
            string ProductKategorie = cb_Kategorie.Text;
            float ProductPrice = float.Parse(tb_Preis.Text);
            Console.WriteLine(ProductName);
        }

        private void btn_ProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btn_ProductClear_Click(object sender, EventArgs e)
        {

        }

        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
