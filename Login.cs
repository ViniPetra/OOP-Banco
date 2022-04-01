using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Banco
{
    public partial class Login : Form
    {
        public int Id { get; private set; }
        public string Senha { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.Id = Int32.Parse(txtConta.Text);
            this.Senha = txtSenha.Text;
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                btnLogar.Enabled = false;
            }
            else
            {
                btnLogar.Enabled = true;
            }
        }
    }
}
