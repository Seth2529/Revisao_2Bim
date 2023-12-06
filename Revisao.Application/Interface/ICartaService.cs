using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Application.ViewModels;

namespace Revisao.Application.Interface
{
    public interface ICartaService
    {
        Task Adicionar(NovaCartaViewModel novaCartaViewModel);

        public IEnumerable<CartasViewModel> GetAll();
    }
}
