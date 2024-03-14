using TechChallenge.Infra.Cache.MongoDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Infra.Cache.MongoDb.Interfaces
{
    public interface ICursoPersistence
    {
        void Create(CursoModel model);
        void Update(CursoModel model);
        void Delete(CursoModel model);
        Task<List<CursoModel>> GetAll();
        Task<CursoModel> GetById(Guid idContato);
        Task<List<CursoModel>> GetByIdProfessor(Guid idProfessor);
    }
}
