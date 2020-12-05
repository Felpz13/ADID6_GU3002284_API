using ADID6_GU3002284_API.Models;
using ADID6_GU3002284_API.Models.itensController;
using System.Threading.Tasks;

namespace ADID6_GU3002284_API.Servicos.Interfaces
{
    public interface IItemService
    {
        Task<BaseResponse> Incluir(IncluirItemModel model);
        Task<BaseResponse> Atualizar(AtualizarItemModel model);
        Task<BaseResponse> Remover(int id);
        Task<BaseResponse> Obter(int? id);
    }
}
