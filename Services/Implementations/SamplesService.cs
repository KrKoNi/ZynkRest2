using ZynkRest2.Models;
using ZynkRest2.Repositories;

namespace ZynkRest2.Services.Implementations;

public class SamplesService : IService<Sample>
{
    private readonly IRepository<Sample> _samplesRepo;

    public SamplesService(IRepository<Sample> samplesRepo) =>
        _samplesRepo = samplesRepo;
    
    public List<Sample> GetAll()
    {
        return _samplesRepo.GetAll();
    }

    public void DeleteById(long id)
    {
        _samplesRepo.DeleteById(id);
    }

    public Sample GetById(long id)
    {
        return _samplesRepo.GetById(id) ?? throw new InvalidOperationException();
    }

    public List<Sample> GetByIdIntersection(List<long> materialIds)
    {
        return _samplesRepo.GetAll().FindAll(sample => materialIds.Intersect(sample.MaterialIds).Count() == sample.MaterialIds.Count());
    } 
}