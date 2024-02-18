using FileService.Domain;
using FileService.Infrastructure.Services;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Zack.Commons;

namespace FileService.Infrastructure
{

    /// <summary>
    /// 区域模块注册
    /// </summary>
    class ModuleInitializer : IModuleInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<IStorageClient, SMBStorageClient>();
            //services.AddScoped<IStorageClient, UpYunStorageClient>();
            services.AddScoped<IStorageClient, MockCloudStorageClient>();
            services.AddScoped<IFSRepository, FSRepository>();
            services.AddScoped<IMediator>();
            services.AddScoped<IDesignTimeDbContextFactory<FSDbContext>, MyDesignTimeDbContextFactory>();
            
            services.AddScoped<FSDomainService>();
            services.AddHttpClient();
        }
    }
}
