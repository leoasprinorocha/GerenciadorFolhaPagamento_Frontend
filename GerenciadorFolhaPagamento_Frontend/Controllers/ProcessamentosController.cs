using GerenciadorFolhaPagamento_Frontend_Domain.Interfaces.Services;
using GerenciadorFolhaPagamento_Frontend_Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend.Controllers
{
    public class ProcessamentosController : Controller
    {
        private readonly IProcessamentosServices _processamentosServices;


        public ProcessamentosController(IProcessamentosServices processamentosServices)
        {
            _processamentosServices = processamentosServices;

        }


        [HttpGet]
        public IActionResult Processamentos()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> RecuperaArquivosQueEstaoNaPastaDeProcessamento()
        {
            var modelList = await _processamentosServices.RetornaArquivosQueEstaoNaPastaDeProcessamento();
            return PartialView("Grids\\_gridArquivosASeremProcessados", modelList);
        }

        [HttpPost]
        public IActionResult ProcessarArquivos()
        {
            var respostaGenerica = _processamentosServices.ProcessarArquivos();
            return Ok(respostaGenerica.Resposta);
        }

        [HttpPost]
        public async Task<IActionResult> LimparDadosProcessados()
        {
            var respostaGenerica = await _processamentosServices.LimparDadosProcessados();
            return Ok(respostaGenerica.Resposta);
        }

        [HttpGet]
        public async Task<IActionResult> RetornaProcessados()
        {
            try
            {
                var conteudoJson = await _processamentosServices.RetornaDepartamentosProcessados();
                return Ok(JsonConvert.SerializeObject(conteudoJson, Formatting.Indented).ToString());
            }
            catch (JsonReaderException)
            {
                List<PesquisaDepartamentosProcessadosViewModel> listaNula = new List<PesquisaDepartamentosProcessadosViewModel>();
                return Ok(JsonConvert.SerializeObject(listaNula));
            }
        }


    }
}
