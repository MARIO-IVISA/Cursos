using TechChallenge.Application.Commands;
using TechChallenge.Application.Models;
using TechChallenge.Infra.Cache.MongoDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Application.Interfaces
{
    public interface ICursoAppService : IDisposable
    {
        Task<CursoDto> Create(CursoCreateCommand command);
        Task<CursoDto> Update(CursoUpdateCommand command);
        Task<CursoDto> Delete(CursoDeleteCommand command);

        Task<List<CursoModel>> GetAll();
        Task<CursoModel> GetById(Guid id);
        Task<List<CursoModel>> GetByIdProdessor(Guid id);
    }
}
