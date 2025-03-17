using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNaturBiomarkt
{
    public partial class MainMenuScreen: Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ProductView pw = new ProductView();
            pw.Show();
            this.Hide();
        }

        private void btn_Rechnung_Click(object sender, EventArgs e)
        {
            Rechnungserstellung rechnungserstellung = new Rechnungserstellung();
            rechnungserstellung.Show();
            this.Hide();
        }
    }
}
