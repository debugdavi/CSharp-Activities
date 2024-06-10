using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AtividadesStatic {
    internal class ConversorDeMoeda {
        public static double ValorDol(double CotDol, double QntDol) {
            return CotDol * QntDol + (CotDol * QntDol * 0.06);
        }
    }
}
