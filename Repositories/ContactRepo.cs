using AddressBook.Data;
using AddressBook.Models;
using AddressBook.Services.Interfaces;

namespace AddressBook.Repositories
{
    public class ContactRepo : ICrudRepository<Contact>
    {
        private readonly ApplicationDBContext _context;
        private readonly IImageService _imageService;

        public ContactRepo(ApplicationDBContext context, IImageService imageService)
        {
            _context = context;
            _imageService = imageService;
        }

        public async Task CreateAsync(Contact contact)
        {
            if(contact.ImageFile != null)
            {
                contact.ImageData = await _imageService.ConvertFileToByteArrayAsync(contact.ImageFile);
                contact.ImageType = contact.ImageFile.ContentType;
            }

            _context.Add(contact);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }


}
