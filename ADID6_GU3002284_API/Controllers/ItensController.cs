using ADID6_GU3002284_API.Models.itensController;
using ADID6_GU3002284_API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ADID6_GU3002284_API.Controllers
{
    [Route("api/[controller]")]
    public class ItensController : BaseController
    {
        private readonly IItemService _itemService;
        public ItensController(IItemService itemService)
        {
            _itemService = itemService;
        }

        /// <summary>
        /// buscar item no cardápio
        /// </summary>
        /// <param name="itemId"> caso vazio busca todos</param>
        /// <returns> Item buscado.</returns>
        [HttpGet]
        public async Task<IActionResult> Obter(int? itemId)
            => await TratarResultadoAsync(async () =>
            {
                var resposta = await _itemService.Obter(itemId);

                if (resposta.Resultado is null)
                    return BadRequest(resposta.Mensagem);
                else
                    return Ok(resposta.Resultado);
            });

        /// <summary>
        /// Adicionar item no cardápio
        /// </summary>
        /// <param name="model"><seealso cref="IncluirItemModel"/></param>
        /// <returns> Id do item criado.</returns>
        [HttpPost]
        public async Task<IActionResult> Incluir([FromForm] IncluirItemModel model)
            => await TratarResultadoAsync(async () =>
            {
                var resposta = await _itemService.Incluir(model);

                if (resposta.Resultado is null)
                    return BadRequest(resposta.Mensagem);
                else
                    return Ok(resposta.Resultado);
            });

        /// <summary>
        /// Altera item no cardápio
        /// </summary>
        /// <param name="model"><seealso cref="AtualizarItemModel"/></param>
        /// <returns> Item atualizado com sucesso.</returns>
        [HttpPut]
        public async Task<IActionResult> Atualizar([FromForm] AtualizarItemModel model)
            => await TratarResultadoAsync(async () =>
            {
                var resposta = await _itemService.Atualizar(model);

                if (resposta.Resultado is null)
                    return BadRequest(resposta.Mensagem);
                else
                    return Ok(resposta.Resultado);
            });

        /// <summary>
        /// Remove item no cardápio
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns> Item removido com sucesso.</returns>
        [HttpDelete]
        public async Task<IActionResult> Remover(int itemId)
            => await TratarResultadoAsync(async () =>
            {
                var resposta = await _itemService.Remover(itemId);

                if (resposta.Resultado is null)
                    return BadRequest(resposta.Mensagem);
                else
                    return Ok(resposta.Resultado);
            });
    }
}
