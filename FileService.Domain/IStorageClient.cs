using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FileService.Domain
{
    /// <summary>
    /// 防腐层接口
    /// 用于 体现   外部第三方云存贮保存服务 的功能 
    /// 我不管你用的是哪一个三方服务，我只管你要做什么
    /// 我不管你具体是怎么做的，我只管你要做什么
    /// </summary>
    public interface IStorageClient
    {
        StorageType StorageType { get; }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="key">文件的key（一般是文件路径的一部分）</param>
        /// <param name="content">文件内容</param>
        /// <returns>存储返回的可以被访问的文件Url</returns>
        Task<Uri> SaveAsync(string key, Stream content, CancellationToken cancellationToken = default);
    }
}
