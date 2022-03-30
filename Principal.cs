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
    public partial class Principal : Form
    {
        Conta ContaAtual { get; set; }
        List<Conta> listaDeContas = new List<Conta>();

        public Principal()
        {
            InitializeComponent();
            listaDeContas.Add(new Conta(0, "0", "0", new Usuário("Pedro", "0")));
            listaDeContas.Add(new Conta(1, "1", "1", new Usuário("Lucas", "1")));
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (ContaAtual == null)
            {
                Login login = new Login();
                login.ShowDialog();
                while (ContaAtual == null)
                {
                    foreach (Conta conta in listaDeContas)
                    {
                        if (conta.Id == login.Id && conta.Login(login.Senha))
                        {
                            ContaAtual = conta;
                            this.AtualizarTela();
                            break;
                        }
                    }
                }
            }
        }
        
        public void AtualizarTela()
        {
            lblNome.Text = ContaAtual.User.nome;
            lblPix.Text = ContaAtual.Pix;
            lblSaldo.Text = "R$"+ContaAtual.Saldo;

            lsxLog.Items.Clear();
            foreach(string log in ContaAtual.Logs)
            {
                lsxLog.Items.Add(log);
            }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            Saque saque = new Saque();
            saque.ShowDialog();
            ContaAtual.Saque(saque.valor);
            this.AtualizarTela();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            deposito.ShowDialog();
            ContaAtual.Deposito(deposito.valor);
            this.AtualizarTela();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Conta destino; ;
            Transferência transferencia = new Transferência();
            transferencia.ShowDialog();
            foreach (Conta conta in listaDeContas)
            {
                if (conta.Id == transferencia.destino)
                {
                    destino = conta;
                    ContaAtual.Transferencia(destino, transferencia.valor);
                    break;
                }
            }
            this.AtualizarTela();
        }
    }
}
