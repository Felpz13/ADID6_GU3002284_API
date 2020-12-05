using ADID6_GU3002284_API.Models;
using ADID6_GU3002284_API.Models.itensController;
using ADID6_GU3002284_API.Repositorios.Interfaces;
using ADID6_GU3002284_API.Servicos.Interfaces;
using System.Threading.Tasks;
using AutoMapper;
using ADID6_GU3002284_API.Entidades;
using System.Collections.Generic;

namespace ADID6_GU3002284_API.Servicos
{
    public class ItemService : IItemService
    {
        private readonly IMockRepo _itemRepositorio;
        private readonly IMapper _mapper;
        public ItemService(IMockRepo itemRepositorio, IMapper mapper)
        {
            _itemRepositorio = itemRepositorio;
            _mapper = mapper;
        }
        public async Task<BaseResponse> Atualizar(AtualizarItemModel model)
        {
            var item = _itemRepositorio.GetById(model.Id);
            if (item is null)
                return new BaseResponse { Mensagem = "O id inserido não existe na base de dados." };

            _itemRepositorio.Update(_mapper.Map<Item>(model));

            return new BaseResponse { Resultado = true };
        }

        public async Task<BaseResponse> Incluir(IncluirItemModel model)
        {
            _itemRepositorio.Add(_mapper.Map<Item>(model));

            return new BaseResponse { Resultado = true };
        }

        public async Task<BaseResponse> Obter(int? id)
        {
            if(id is null)
                return new BaseResponse { Resultado = _mapper.Map<List<ObterItemModel>>(_itemRepositorio.GetAll()) };

            var item = _itemRepositorio.GetById(id.Value);
            return item is null ?
                new BaseResponse { Mensagem = "O id buscado não existe na base de dados." }:
                new BaseResponse { Resultado = _mapper.Map<ObterItemModel>(item) };                            
        }

        public async Task<BaseResponse> Remover(int id)
        {
            var item = _itemRepositorio.GetById(id);
            if (item is null)
                return new BaseResponse { Mensagem = "O id inserido não existe na base de dados." };

            _itemRepositorio.Delete(id);
            return new BaseResponse { Resultado = true };
        }
    }
}
