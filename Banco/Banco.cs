namespace Program {
    class Banco {        
        public int NumConta {get; private set;}
        public string Nome;
        public double Dinheiro {get; private set;}

        public Banco(int numConta, string nome, double dinheiro) {
            NumConta = numConta;
            Nome = nome;
            Dinheiro = dinheiro;
        }

        public void Depositar(double valorDeposito) {
            Dinheiro += valorDeposito;
        }

        public void Sacar(double valorSaque) {
            Dinheiro -= valorSaque + 5;
        }
    }
}