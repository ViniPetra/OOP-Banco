using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banco
{
    public class Usuário
    {
        public string nome { get; private set; }
        public string cpf { get; private set; }

        public Usuário(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
