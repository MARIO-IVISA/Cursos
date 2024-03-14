using MediatR;
using TechChallenge.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.Commands
{
    public class CursoDeleteCommand : IRequest<CursoDto>
    {
        public Guid Id { get; set; }
    }
}
