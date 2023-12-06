using AutoMapper;
using Revisao.Application.Interface;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
    {
        private readonly ICartasRepository _cartasRepository;
        private IMapper _mapper;

        public CartaService(ICartasRepository cartaRepository, IMapper mapper)
        {
            _cartasRepository = cartaRepository;
            _mapper = mapper;
        }
        public async Task Adicionar(NovaCartaViewModel CartaViewModel)
        {
            var novaCarta = _mapper.Map<Cartas>(CartaViewModel);


            await _cartasRepository.Adicionar(novaCarta);
        }


        public IEnumerable<CartasViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CartasViewModel>>(_cartasRepository.GetAll());
        }
    }
}

