namespace ZynkRest2.Repositories;

public interface IRepository<T>
{
    T? GetById(long id);
    List<T> GetAll();
    void DeleteById(long id);
}