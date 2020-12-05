using Microsoft.AspNetCore.Http;
using System.IO;

namespace ADID6_GU3002284_API.Entidades.Helpers
{
    public static class ImagemHelper
    {
        public static byte[] IformFileToByteArray(IFormFile formFile)
        {
            byte[] byteArray;

            using (var ms = new MemoryStream())
            {
                formFile.CopyTo(ms);
                byteArray = ms.ToArray();
            }

            return byteArray;
        }
    }
}
