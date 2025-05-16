using System.Threading.Tasks;
using Backend_ind.Interfaces;
using Backend_ind.Models;

namespace Backend_ind.Services;

public class FileService : EfService<FileEntity>
{
    public async Task AddFromRequest(UploadFileRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.name))
        {
            throw new Exception("File must have a name");
        }
    }
}