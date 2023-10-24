using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstrato
{       //criei a clase funcionario que compoe todas as outras subclasses
    public abstract class Funcionario
    {
        public string Nome;
        public decimal Salario;

        public abstract void Reajustar();
    }
}
