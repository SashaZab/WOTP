using Microsoft.AspNetCore.Http;

namespace Lab_Zab.Models.File
{
    public class UploadFileViewModel
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}
