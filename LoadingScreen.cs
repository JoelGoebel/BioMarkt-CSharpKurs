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
    public partial class LoadingScreen: Form
    {
        private int loadingbarValue;
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingbarTimer_Tick(object sender, EventArgs e)
        {
            float Tick = 0;
            Tick += 0.2f;

            if (Tick <= 1)
            {
                if(progressBar1.Value == progressBar1.Maximum)
                {
                    LoadingbarTimer.Stop();
                }else
                {
                    progressBar1.Value += 1;
                    lb_ProgressInPercent.Text = progressBar1.Value.ToString() + "%";
                    Tick = 0;
                }                    
            }
            
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingbarTimer.Start();
        }
    }
}
