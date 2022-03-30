using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banco
{
    public class Conta
    {
        public int Id { get; private set; }
        private string Senha { get; set; }
        public double Saldo { get; private set; }
        public Usuário User { get; private set; }
        public string Pix { get; private set; }
        
        public List<String> Logs { get; private set; }

        public Conta(int id, string senha, string pix, Usuário user) 
        {
            this.Id = id;
            this.Senha = senha;
            this.Saldo = 0;
            this.User = user;
            this.Pix = pix;
            this.Logs = new List<String>();
        }

        public Conta()
        {

        }

        public bool Deposito(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
                this.Log("Depósito de R$" + valor);
                return true;
            }
            else
            {
                this.Log("Falha no depósito");
                return false;
            }
            
        }

        public bool Saque (double valor)
        {
            if(valor > 0 && valor <= this.Saldo)
            {
                this.Saldo -= valor;
                this.Log("Saque de R$" + valor);
                return true;
            }
            else
            {
                this.Log("Falha no saque");
                return false;
            }
        }

        public void ReceberTransferencia(Conta remetente, double valor)
        {
            this.Saldo += valor;
            remetente.Log("Recebido R$" + valor + " de " + remetente.User.nome);
        }

        public bool Transferencia(Conta destinatário, double valor)
        {
            if(valor > 0 && valor <= this.Saldo)
            {
                destinatário.ReceberTransferencia(this, valor);
                this.Saldo -= valor;
                this.Log("Enviado R$" + valor + " para " + destinatário.User.nome);
                return true;
            }
            else
            {
                this.Log("Falha na transferência");
                return false;
            }
        }

        public void Log (string log)
        {
            Logs.Add(log);
        }

        public bool Login(string senha)
        {
            if (senha == this.Senha)
            {
                return true;
            }
            else
            {
                this.Log("Erro no login");
                return false;
            }
                 
        }
    }
}
