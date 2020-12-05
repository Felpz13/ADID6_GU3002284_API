using ADID6_GU3002284_API.Entidades.Enums;
using ADID6_GU3002284_API.Models.itensController;
using FluentValidation;
using System.Linq;

namespace ADID6_GU3002284_API.Validators
{
    public class IncluirItemModelValidator : AbstractValidator<IncluirItemModel>
    {
        public IncluirItemModelValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage($"O {nameof(IncluirItemModel.Nome)} é obrigatório.");
            RuleFor(x => x.Valor)
                .NotEmpty().WithMessage($"O {nameof(IncluirItemModel.Valor)} é obrigatório.")
                .ExclusiveBetween(0.01, double.MaxValue).WithMessage($"{nameof(IncluirItemModel.Valor)} inválido.");
            RuleFor(x => x.CategoriaId)
                .IsInEnum().WithMessage($"Favor utilizar uma categoria do tipo {nameof(CategoriaEnum)}");
            RuleFor(x => x.Imagem)
                .Must(imagem => imagem != null ? imagem.ContentType.Split('/').Last() == "png" : true)
                .WithMessage($"O {nameof(IncluirItemModel.Imagem)} deve ser PNG.");
        }
    }
}
