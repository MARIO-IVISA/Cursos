using FluentValidation;
using TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Domain.Validators
{/// <summary>
/// Classe de validação para a entidade Contato
/// </summary>
    public class CursoValidator : AbstractValidator<Curso>
    {
        public CursoValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("Id do curso é obrigatório.");
           
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome do curso é obrigatório.")
                .Length(6, 150).WithMessage("O nome do curso deve ter de 6 a 150 caracteres.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Descrição do curso é obrigatório.");

            RuleFor(c => c.Media)
            .NotEmpty().WithMessage("Média é obrigatório.");

            RuleFor(c => c.DataCurso)
            .NotEmpty().WithMessage("Data é obrigatório.");
        }
    }
}
