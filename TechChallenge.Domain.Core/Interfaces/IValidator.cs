using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Domain.Core.Interfaces
{
    /// <summary>
    /// Modelo de interface para aplicar regras de validação
    /// </summary>
    public interface IValidator
    {
        ValidationResult Validate { get; }
    }
}
