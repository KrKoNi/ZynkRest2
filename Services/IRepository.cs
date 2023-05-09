namespace ZynkRest2.Services;

public interface IService<T>
{
    T? GetById(long id);
    List<T> GetAll();
    void DeleteById(long id);
    List<T> GetByIdIntersection(List<long> ids);
}