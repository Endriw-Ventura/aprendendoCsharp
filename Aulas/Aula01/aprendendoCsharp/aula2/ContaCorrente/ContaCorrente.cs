namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular{get;set;}
        public int Agencia { get; set;}
        public int NumeroConta { get; set;}
        private double _saldo;
        public static int TotalDeContas {get; private set;}

         
        public ContaCorrente(int agencia, int numeroConta)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;
            TotalDeContas++;

        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}