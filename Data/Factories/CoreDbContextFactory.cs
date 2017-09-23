//using Core.Data.Abstractions;
//using Core.Data.Services;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using System.IO;

//namespace Core.Data.Factories
//{
//    public class CoreDbContextFactory : IDbContextFactory<ICoreDbContext>
//	{
//		public CoreDbContext Create(DbContextFactoryOptions options)
//		{
//			var builder = new ConfigurationBuilder()
//				.SetBasePath(Directory.GetCurrentDirectory())
//				.AddJsonFile("appsettings.json");

//			var configuration = builder.Build();

//			var optionsBuilder = new DbContextOptionsBuilder<CoreDbContext>();

//			optionsBuilder.UseSqlServer(configuration.GetSection("AppSettings:ConnectionString").Value);

//			return new CoreDbContext(optionsBuilder.Options);
//		}
//	}
//}