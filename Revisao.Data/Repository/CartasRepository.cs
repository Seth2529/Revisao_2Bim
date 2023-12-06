using AutoMapper;
using H1Store.Catalogo.Data.Providers.MongoDb.Interfaces;
using ListaH1.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;
using Revisao.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repository
{
    public class CartasRepository : ICartasRepository
    {
        private readonly IMongoRepository<CartasCollection> _cartaRepository;
        private readonly IMapper _mapper;

        #region - Construtores

        public CartasRepository(IMongoRepository<CartasCollection> cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções
        public async Task Adicionar(Cartas carta)
        {
            await _cartaRepository.InsertOneAsync(_mapper.Map<CartasCollection>(carta));

        }
        public IEnumerable<Cartas> GetAll()
        {
            var categoriaList = _cartaRepository.FilterBy(filter => true);

            return _mapper.Map<IEnumerable<Cartas>>(categoriaList);
        }
        #endregion
    }

}
