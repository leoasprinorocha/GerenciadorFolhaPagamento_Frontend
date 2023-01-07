using GerenciadorFolhaPagamento_Frontend_Domain.Interfaces.Services;
using GerenciadorFolhaPagamento_Frontend_Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend.Controllers
{
    public class ParametrosController : Controller
    {
        private readonly IParametrosServices _parametrosServices;

        public ParametrosController(IParametrosServices parametrosServices)
        {
            _parametrosServices = parametrosServices;
        }

        [HttpGet]
        public IActionResult Parametros()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GravarParametros([FromForm] List<NovoParametroViewModel> listaparametros)
        {
            try
            {
                return Ok(await _parametrosServices.CadastrarNovoParametro(listaparametros));
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao salvar os parâmetros: " + ex.Message);
            }
        }
    }
}
