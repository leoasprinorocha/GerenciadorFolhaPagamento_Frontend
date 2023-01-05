using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFolhaPagamento_Frontend_Client.Interfaces
{
    public interface IClientBase
    {
        Task<T> GetAsync<T>(string controller, string action);

        Task<T> PostAsync<T>(string controller, string action, object objParameter);
    }
}
