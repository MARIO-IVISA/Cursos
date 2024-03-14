using TechChallenge.Domain.Entities;
using TechChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Domain.Services
{
    public class CursoDomainService : ICursoDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CursoDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Curso entity)
        {
            await _unitOfWork.CursoRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(Curso entity)
        {
            #region O curso deve existir no no banco de dados
            if (await _unitOfWork.CursoRepository.GetByIdAsync(entity.Id) == null)
                throw new ArgumentException("Curso não encontrado, verifique o ID informado.");
            #endregion

            await _unitOfWork.CursoRepository.DeleteAsync(entity);
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public async Task<List<Curso>> GetAllAsync(int page, int limit)
        {
            #region O limite de paginação de cursos é de 250 registros
            if (limit > 250)
                throw new ArgumentException("Informe um limite de no máximo 250 registros.");
            #endregion

            return await _unitOfWork.CursoRepository.GetAllAsync(page, limit);
        }

        public async Task<Curso> GetByIdAsync(Guid id)
            => await _unitOfWork.CursoRepository.GetByIdAsync(id);
        

        public async Task UpdateAsync(Curso entity)
        {
            #region O contado deve existir no no banco de dados
            if (await _unitOfWork.CursoRepository.GetByIdAsync(entity.Id) == null)
                throw new ArgumentException("Contato não encontrado, verifique o ID informado.");
            #endregion

            await _unitOfWork.CursoRepository.UpdateAsync(entity);
        }
    }
}
