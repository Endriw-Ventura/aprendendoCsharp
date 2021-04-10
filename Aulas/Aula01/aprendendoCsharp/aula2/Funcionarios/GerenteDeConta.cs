using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class GerenteDeConta : FuncionarioAutenticavel
    {
        
        public GerenteDeConta(string cpf) : base(2100, cpf)
        {
            Console.WriteLine("Construindo um Gerente de Conta");
        }


        public override void RiseSalary()
        {
            Salario *= 1.05;
        }

        public override double GetBonus()
        {
            return Salario *0.25;
        }

    }
}
