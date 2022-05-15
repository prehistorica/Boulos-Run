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
    public partial class frmEntrar : Form
    {
        public frmEntrar()
        {
            InitializeComponent();
            this.Text = " Seja Bem Vindo " + "  " +  DateTime.Now.ToShortTimeString();
        }

        private void btnSairBV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Até Breve", "Tchau!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Operação Cancelada", "Abortar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foto.Visible = true; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foto.Visible = false; 
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal voltar = new frmPrincipal();
            voltar.ShowDialog(); 
        }

        private void frmEntrar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
