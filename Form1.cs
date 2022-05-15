using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 

namespace Tela_de_Splash
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            if (progressBar1.Value < 100)
                
            {
                progressBar1.Value = progressBar1.Value + 2; 
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false; 
                
                this.pictureBox1.Visible = false;

               

                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();

                
            }

            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;

            for (double i = 0; i <= 1; i += 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
        }
    }
}
