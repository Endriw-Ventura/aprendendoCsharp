using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
    {
        public string Senha { get; set; }


        public FuncionarioAutenticavel(double salario, string cpf):base (salario, cpf)
        {

        }

        
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
