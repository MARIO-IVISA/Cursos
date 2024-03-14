using Microsoft.EntityFrameworkCore.Storage;
using TechChallenge.Domain.Interfaces;
using TechChallenge.Infra.Data.SqlServer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Infra.Data.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlServerContext _sqlServerContext;
      
        public UnitOfWork(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        private IDbContextTransaction _dbContextTransaction;

        public ICursoRepository CursoRepository => new CursoRepository(_sqlServerContext);

        public void BeginTransaction()
        {
           _dbContextTransaction = _sqlServerContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _dbContextTransaction.Commit();
        }

        public void Dispose()
        {
            _sqlServerContext.Dispose();
        }

        public void RollbackTransaction()
        {
            _dbContextTransaction.Rollback();
        }
    }
}
