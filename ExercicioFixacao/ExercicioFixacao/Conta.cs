namespace ExercicioFixacao {
    internal class Conta {
        private int NumeroConta { get; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int num, string nome, double deposito) {
            this.NumeroConta = num;
            this.Nome = nome;
            this.Saldo = deposito;
        }
                        
        public void setNome(string nome2) {
            if(nome2 != this.Nome) {
                this.Nome = nome2;
            }
        }

        public void Deposita(double deposito) {
            this.Saldo += deposito;
        }

        public void Saca(double saque) {
            this.Saldo -= saque + 5.00;
        }

        public override string ToString() {            
            return ("Conta " + this.NumeroConta +
                ", Titular: " + this.Nome +
                ", Saldo: R$" + this.Saldo.ToString("F2"));
        }

    }
}
