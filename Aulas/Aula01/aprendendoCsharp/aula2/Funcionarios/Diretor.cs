using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank

{
    class Diretor : FuncionarioAutenticavel
    {
       
        public Diretor(string cpf) : base (5000, cpf)
        {
            Console.WriteLine("Construindo um Diretor!");
        }


        public override void RiseSalary()
        {
            Salario *= 1.15;
        }

        public override double GetBonus()
        {
            return Salario * 0.5;
        }

        
        
    }
}
