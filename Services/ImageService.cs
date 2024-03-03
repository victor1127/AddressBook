using AddressBook.Services.Interfaces;

namespace AddressBook.Services
{
    public class ImageService : IImageService
    {
        public string ConvertByteArrayToFile(byte[] fileData, string content)
        {
            if (fileData is null) return string.Empty;

            string imageBase64Data = Convert.ToBase64String(fileData);
            return string.Format($"data:{content};base64,{imageBase64Data}");

        }

        public async Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file)
        {
            using MemoryStream memoryStream = new();
            await file.CopyToAsync(memoryStream);
            byte[] byteFile = memoryStream.ToArray();

            return byteFile;

        }
    }
}
