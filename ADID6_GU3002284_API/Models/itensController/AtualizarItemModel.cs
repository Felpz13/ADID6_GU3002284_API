using ADID6_GU3002284_API.Entidades.Enums;
using Microsoft.AspNetCore.Http;

namespace ADID6_GU3002284_API.Models.itensController
{
    public class AtualizarItemModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double? Valor { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public CategoriaEnum? CategoriaId { get; set; }
        public IFormFile Imagem { get; set; }
    }
}
