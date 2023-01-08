using GerenciadorFolhaPagamento_Frontend_Client.Interfaces;
using GerenciadorFolhaPagamento_Frontend_Domain.Interfaces.Services;
using GerenciadorFolhaPagamento_Frontend_Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend_Services.Services
{
    public class ParametrosServices : IParametrosServices
    {
        private readonly IClientBase _clientBase;
        private readonly string _controller = "Parametros";

        public ParametrosServices(IClientBase clientBase)
        {
            _clientBase = clientBase;
        }

        public async Task<RespostaGenericaViewModel> CadastrarNovoParametro(List<NovoParametroViewModel> novoParametro) =>
        await _clientBase.PostAsync<RespostaGenericaViewModel>(_controller, "CadastrarParametro", novoParametro);

        public async Task<List<NovoParametroViewModel>> RetornaTodosOsParametros() =>
        await _clientBase.GetAsync<List<NovoParametroViewModel>>(_controller, "RetornaTodosOsParametros");



    }
}
