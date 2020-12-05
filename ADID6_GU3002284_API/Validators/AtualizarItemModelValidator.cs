using ADID6_GU3002284_API.Entidades.Enums;
using ADID6_GU3002284_API.Models.itensController;
using FluentValidation;
using System.Linq;

namespace ADID6_GU3002284_API.Validators
{
    public class AtualizarItemModelValidator : AbstractValidator<AtualizarItemModel>
    {
        public AtualizarItemModelValidator()
        {
            RuleFor(x => x.Imagem)
                .Must(imagem => imagem != null ? imagem.ContentType.Split('/').Last() == "png" : true)
                .WithMessage($"O {nameof(AtualizarItemModel.Imagem)} deve ser PNG.");
        }
    }
}
