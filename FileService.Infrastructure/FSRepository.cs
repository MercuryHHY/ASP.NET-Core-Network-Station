using FileService.Domain;
using FileService.Domain.Entities;

namespace FileService.Infrastructure
{
    /// <summary>
    /// Repository 仓储实现
    /// </summary>
    class FSRepository : IFSRepository
    {
        private readonly FSDbContext dbContext;

        public FSRepository(FSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<UploadedItem?> FindFileAsync(long fileSize, string sha256Hash)
        {
            // 文件大小相同且 哈希值 相同 则可确定是同一个文件
            return dbContext.UploadItems.FirstOrDefaultAsync(u => u.FileSizeInBytes == fileSize
            && u.FileSHA256Hash == sha256Hash);
        }
    }
}
