using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf) : base(1500, cpf)
        {
            Console.WriteLine("Construindo um Auxiliar de escritório");
        }


        public override void RiseSalary()
        {
            Salario *= 1.1;
        }

        public override double GetBonus()
        {
            return Salario * 0.2;
        }


    }
}