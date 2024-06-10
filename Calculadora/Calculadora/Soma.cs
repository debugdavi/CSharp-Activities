using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula {
    internal class Soma {
        public static int Sum(int[] numeros) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) {
                soma += numeros[i];
            }
            return soma;
        }

    }
}
