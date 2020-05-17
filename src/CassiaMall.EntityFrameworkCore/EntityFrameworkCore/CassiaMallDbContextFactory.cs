using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CassiaMall.Configuration;
using CassiaMall.Web;

namespace CassiaMall.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CassiaMallDbContextFactory : IDesignTimeDbContextFactory<CassiaMallDbContext>
    {
        public CassiaMallDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CassiaMallDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CassiaMallDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CassiaMallConsts.ConnectionStringName));

            return new CassiaMallDbContext(builder.Options);
        }
    }
}
