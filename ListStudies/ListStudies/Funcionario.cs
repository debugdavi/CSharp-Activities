using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStudies {
    internal class Funcionario {
        public string Id { get; private set; }
        public string Name { get; set; }    
        public double Salary { get; set; }

        public Funcionario(string id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AumentaSal(double val) {
            Salary = Salary + Salary * (val / 100);  
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary}";
        }
    }
}
