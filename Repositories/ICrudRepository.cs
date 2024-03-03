namespace AddressBook.Repositories
{
    public interface ICrudRepository<T>
    {
        Task CreateAsync(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(int id);

    }

    
}
