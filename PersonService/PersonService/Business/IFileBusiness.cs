using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PersonService.Data.VO;

namespace PersonService.Business
{
    public interface IFileBusiness
    {
         public byte[] GetFile(string fileName);

         public Task<FileDetailVO> SaveFileToDisk(IFormFile file);
         public Task<List<FileDetailVO>> SaveFilesToDisk(IList<IFormFile> file);
    }
}