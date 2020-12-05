using ADID6_GU3002284_API.Entidades.Enums;

namespace ADID6_GU3002284_API.Models.itensController
{
    public class ObterItemModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public CategoriaEnum CategoriaId { get; set; }
        public string Imagem { get; set; }
    }
}
