using MediatR;
using TechChallenge.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.Commands
{
    public class CursoCreateCommand : IRequest<CursoDto>
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Guid? IdProfessor { get; set; }
        public double? Media { get; set; }
        public DateTime DataCurso { get; set; }
    }
}
