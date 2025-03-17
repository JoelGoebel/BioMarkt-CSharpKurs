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

            if(loadingbarValue >= progressBar1.Maximum)
            {
                LoadingbarTimer.Stop();

                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();
                
                this.Hide();    
                    
            }
            else
            {
                loadingbarValue +=  2 ;
                progressBar1.Value = loadingbarValue ;
                lb_ProgressInPercent.Text = loadingbarValue.ToString() + "%";                   
            }                    
            
            
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingbarTimer.Start();
        }
    }
}
