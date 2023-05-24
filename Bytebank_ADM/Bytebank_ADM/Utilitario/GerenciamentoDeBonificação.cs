using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Utilitario
{
    public class GerenciamentoDeBonificação
    {
        public double TotalDeBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario) 
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }
    }
}
