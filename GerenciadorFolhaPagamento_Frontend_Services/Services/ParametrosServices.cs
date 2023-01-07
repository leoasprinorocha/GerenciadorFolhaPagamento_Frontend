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

        public async Task<string> CadastrarNovoParametro(List<NovoParametroViewModel> novoParametro) =>
        await _clientBase.PostAsync<string>(_controller, "CadastrarParametro", novoParametro);

        
        
    }
}
