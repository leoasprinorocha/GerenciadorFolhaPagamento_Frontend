using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend_Domain.ViewModels
{
    public class FuncionarioPesquisaProcessamentoViewModel
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public decimal TotalReceber { get; set; }
        public double HorasExtras { get; set; }
        public double HorasDebito { get; set; }
        public int DiasFalta { get; set; }
        public int DiasExtras { get; set; }
        public int DiasTrabalhados { get; set; }

        
    }
}
