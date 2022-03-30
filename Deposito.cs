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
    public partial class Deposito : Form
    {
        public double valor { get; set; }
        public Deposito()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            this.valor = Double.Parse(txtValor.Text);
            this.Close();
        }
    }
}
