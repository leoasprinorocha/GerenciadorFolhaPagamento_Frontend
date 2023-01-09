

using GerenciadorFolhaPagamento_Frontend_Client.Interfaces;
using GerenciadorFolhaPagamento_Frontend_Domain.Interfaces.Services;
using GerenciadorFolhaPagamento_Frontend_Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend_Services.Services
{
    public class ProcessamentosServices : IProcessamentosServices
    {
        private readonly IClientBase _clientBase;
        private readonly string _controller = "Processamentos";

        public ProcessamentosServices(IClientBase clientBase)
        {
            _clientBase = clientBase;
        }
        public RespostaGenericaViewModel ProcessarArquivos() =>
        _clientBase.PostAsync<RespostaGenericaViewModel>(_controller, "ExecutaProcessamento", null).Result;


        public async Task<List<string>> RetornaArquivosQueEstaoNaPastaDeProcessamento() =>
        await _clientBase.GetAsync<List<string>>(_controller, "RetornaArquivosQueEstaoNaPastaDeProcessamento");

        public async Task<List<PesquisaDepartamentosProcessadosViewModel>> RetornaDepartamentosProcessados() =>
            await _clientBase.GetAsync<List<PesquisaDepartamentosProcessadosViewModel>>(_controller, "RetornaDepartamentosProcessados");

    }
}
