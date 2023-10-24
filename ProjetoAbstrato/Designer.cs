using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstrato
{       //etapa de informar qual será o valor do reajuste  para a classe designer
    class Designer : Funcionario
    {
        public override void Reajustar()
        {
            Salario += 500;
        }
    }
}
