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
    public partial class Rechnungeinsehen: Form
    {
        public Rechnungeinsehen()
        {
            InitializeComponent();
        }

        private void btn_zurück_Click(object sender, EventArgs e)
        {
            RechnungsSuche rechnungsSuche = new RechnungsSuche();
            rechnungsSuche.Show();
            this.Hide();
        }
    }
}
