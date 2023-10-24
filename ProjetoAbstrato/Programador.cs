using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstrato
{       //etapa de informar qual será o valor do reajuste  para a classe programador
    class Programador : Funcionario
    {
        public override void Reajustar()
        {
            Salario += 1000;
        }
    }
}
