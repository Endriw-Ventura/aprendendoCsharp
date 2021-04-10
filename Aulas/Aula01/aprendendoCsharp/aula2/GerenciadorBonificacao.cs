using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    class GerenciadorBonificacao
    {
        private double _totalBonus;
        public void Record(Funcionario funcionario)
        {
           _totalBonus += funcionario.GetBonus();
        }
        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}
