using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class Designer : Funcionario
    {

        public Designer(string cpf) : base(2500, cpf)
        {
            Console.WriteLine("Construindo um Designer");
        }


        public override void RiseSalary()
        {
            Salario *= 1.11;
        }

        public override double GetBonus()
        {
            return Salario * 0.17;
        }


    }
}