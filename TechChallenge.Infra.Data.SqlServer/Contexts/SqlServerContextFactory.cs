using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Infra.Data.SqlServer.Contexts
{
    public class SqlServerContextFactory : IDesignTimeDbContextFactory<SqlServerContext>
    {
        public SqlServerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlServerContext>();
            optionsBuilder.UseSqlServer(@"Data Source=127.0.0.1,1433;Initial Catalog=Cursos;User ID= sa;Password=BlindRio#; Integrated Security=false; Encrypt=False;;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
); 

            return new SqlServerContext(optionsBuilder.Options);
        }
    }
}
