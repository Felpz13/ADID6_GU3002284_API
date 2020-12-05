using ADID6_GU3002284_API.Entidades.Enums;

namespace ADID6_GU3002284_API.Entidades
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public CategoriaEnum CategoriaId { get; set; }
        public byte[] Imagem { get; set; }
    }
}
