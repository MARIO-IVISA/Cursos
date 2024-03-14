using MediatR;
using TechChallenge.Application.Commands;
using TechChallenge.Application.Interfaces;
using TechChallenge.Application.Models;
using TechChallenge.Domain.Interfaces;
using TechChallenge.Infra.Cache.MongoDb.Interfaces;
using TechChallenge.Infra.Cache.MongoDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.Services
{
    public class CursoAppService : ICursoAppService
    {
        private readonly IMediator _mediator;
        private readonly ICursoPersistence _cursoersistence;

        public CursoAppService(IMediator mediator, ICursoPersistence cursoPersistence)
        {
            _mediator = mediator;
            _cursoersistence = cursoPersistence;
        }

        public async Task<CursoDto> Create(CursoCreateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<CursoDto> Delete(CursoDeleteCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<List<CursoModel>> GetAll()
        {
            return await _cursoersistence.GetAll();
        }

        public async Task<CursoModel> GetById(Guid id)
        {
            return await _cursoersistence.GetById(id);
        }

        public async Task<CursoDto> Update(CursoUpdateCommand command)
        {
            return await _mediator.Send(command);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<List<CursoModel>> GetByIdProdessor(Guid id)
        {
           return await _cursoersistence.GetByIdProfessor(id);
        }
    }
}
