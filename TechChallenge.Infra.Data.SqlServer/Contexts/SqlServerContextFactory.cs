using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Infra.Data.SqlServer.Contexts
{
    /// <summary>
    /// Classe par aexecultar os comandos MIGRATIONS DO EntityFramework
    /// </summary>
    public class SqlServerContextFactory : IDesignTimeDbContextFactory<SqlServerContext>
    {
        public SqlServerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlServerContext>();
            optionsBuilder.UseSqlServer(@"Data Source=sqldata_cursos;Initial Catalog=cursos;User ID= sa;Password=BlindRio#; Integrated Security=false; Encrypt=False;;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
); 

            return new SqlServerContext(optionsBuilder.Options);
        }
    }
}
