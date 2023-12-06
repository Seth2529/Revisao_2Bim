using AutoMapper;
using ListaH1.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.AutoMapper
{
    public class DomainToCollection : Profile
    {
        public DomainToCollection()
        {
            CreateMap<Cartas, CartasCollection>();

        }
    }
}
