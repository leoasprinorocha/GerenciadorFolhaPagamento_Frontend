using GerenciadorFolhaPagamento_Frontend_Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend_Domain.Interfaces.Services
{
    public interface IParametrosServices
    {
        Task<RespostaGenericaViewModel> CadastrarNovoParametro(List<NovoParametroViewModel> novoParametro);
        Task<List<NovoParametroViewModel>> RetornaTodosOsParametros();
    }
}
