using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesNelio {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentaSal(double porc) {
            porc = porc / 100;
            SalarioBruto = SalarioBruto + (SalarioBruto * porc);
        }

        public override string ToString() {
            return $"{Nome}, R$ {SalLiquido().
                ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
