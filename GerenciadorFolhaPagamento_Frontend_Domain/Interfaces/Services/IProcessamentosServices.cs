using GerenciadorFolhaPagamento_Frontend_Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend_Domain.Interfaces.Services
{
    public interface IProcessamentosServices
    {
        Task<List<string>> RetornaArquivosQueEstaoNaPastaDeProcessamento();
        RespostaGenericaViewModel ProcessarArquivos();
        Task<List<PesquisaDepartamentosProcessadosViewModel>> RetornaDepartamentosProcessados();
    }
}
