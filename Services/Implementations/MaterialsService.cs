using ZynkRest2.Models;
using ZynkRest2.Repositories;

namespace ZynkRest2.Services.Implementations;

public class MaterialsService : IService<Material>
{
    private readonly IRepository<Material> _materialRepo;

    public MaterialsService(IRepository<Material> materialRepo) =>
        _materialRepo = materialRepo;
    
    public List<Material> GetAll()
    {
        return _materialRepo.GetAll();
    }

    public void DeleteById(long id)
    {
        _materialRepo.DeleteById(id);
    }

    public Material GetById(long id)
    {
        return _materialRepo.GetById(id) ?? throw new InvalidOperationException();
    }

    public List<Material> GetByIdIntersection(List<long> ids)
    {
        throw new NotImplementedException();
    }
}