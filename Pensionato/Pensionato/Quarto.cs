using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato {
    internal class Quarto {
        public string Aluno { get; set; }
        public string Email { get; set; }

        public Quarto(string aluno, string email) {
            Aluno = aluno;  
            Email = email;
        }
    }
}
