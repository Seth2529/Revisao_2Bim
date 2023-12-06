using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {

            CreateMap<CartasViewModel, Cartas>()
               .ConstructUsing(q => new Cartas(q.NomeCrianca, q.Rua, q.Numero, q.Bairro, q.Cidade, q.Estado, q.IdadeCriancaEmAnos, q.TextoCartaCrianca));

            CreateMap<NovaCartaViewModel, Cartas>()
               .ConstructUsing(q => new Cartas(q.NomeCrianca, q.Rua, q.Numero, q.Bairro, q.Cidade, q.Estado, q.IdadeCriancaEmAnos, q.TextoCartaCrianca));

        }
    }
}
