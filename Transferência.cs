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
    public partial class Transferência : Form
    {
        public double valor { get; set; }
        public int destino { get; set; }
        public Transferência()
        {
            InitializeComponent();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            this.valor = Double.Parse(txtValor.Text);
            this.destino = Int32.Parse(txtDestino.Text);
            this.Close();
        }
    }
}
