using TechChallenge.Domain.Core.Interfaces;
using TechChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Domain.Interfaces
{
    /// <summary>
    /// Interface de serviços de domínio para contato
    /// </summary>
    public interface ICursoDomainService : IDomainService<Curso, Guid>
    {
    }
}
