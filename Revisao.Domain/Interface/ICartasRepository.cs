using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interface
{
    public interface ICartasRepository
    {
        IEnumerable<Cartas> GetAll();

        Task Adicionar(Cartas cartas);
    }
}
