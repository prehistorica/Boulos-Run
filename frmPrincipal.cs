using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_Splash
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            
            InitializeComponent();
            lblData.Text = " Data  " + DateTime.Now.ToShortDateString();
            this.Text = " Horário de Brasília " + DateTime.Now.ToShortTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)  
            {
                MessageBox.Show("Até Breve", "Tchau!", MessageBoxButtons.OK, MessageBoxIcon.Hand); 
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Operação Cancelada", "Abortar!", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmEntrar entrar = new frmEntrar();
            entrar.ShowDialog(); 
        }

        
    }
}
