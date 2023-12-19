using FileService.Domain.Entities;
using System.Threading.Tasks;

namespace FileService.Domain
{

    /// <summary>
    /// 仓储服务接口（体现仓储功能的 接口）
    /// </summary>
    public interface IFSRepository
    {
        /// <summary>
        /// 查找已经上传的相同大小以及散列值的文件记录
        /// </summary>
        /// <param name="fileSize">要查找的文件大小</param>
        /// <param name="sha256Hash">文件哈希值</param>
        /// <returns></returns>
        Task<UploadedItem?> FindFileAsync(long fileSize, string sha256Hash);
    }
}
