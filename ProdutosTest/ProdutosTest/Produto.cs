using System.Dynamic;
using System.Globalization;

namespace ProdutosTest {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quant { get; private set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quant = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotal() {
            return Quant * Preco;
        }
        public void AdicionarUnid(int qntd) {
            Quant = Quant + qntd;
        }

        public void RemoverUnid(int qntd) {
            Quant = Quant - qntd;
        }

        public override string ToString() {
            return $"{_nome}, R$ {Preco.
                ToString("F2", CultureInfo.InvariantCulture)}, {Quant} unidades, no total de R$ {ValorTotal()}";

            /*
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quant + " unidades, total de $" + ValorTotal(); 
            */
        }
    }
}
