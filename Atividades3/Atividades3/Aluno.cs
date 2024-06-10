using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades3 {
    internal class Aluno {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        public double NFinal;

        public string Nfim() {
            NFinal = N1 + N2 + N3;
            if (NFinal < 60) {
                double Fpont = 60 - NFinal;
                return $"Reprovado\nFaltam {Fpont.
                    ToString("F2", CultureInfo.InvariantCulture)} pontos";
            }
            else{
                return "Aprovado";
            }

        }

    }
}
