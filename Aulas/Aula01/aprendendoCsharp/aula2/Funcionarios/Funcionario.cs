using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public abstract class Funcionario
    {         
        public string Nome{get; set;}
        public string Cpf {get; private set;}
        public double Salario {get; protected set;}
        public static int TotalWorkers {get; private set;}
        


        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            TotalWorkers++;
            Cpf = cpf;
        }

        public abstract void RiseSalary();

        public abstract double GetBonus();

     
    }
}
