using ZynkRest2.Models;

namespace ZynkRest2.Repositories.Implementations;

public class MaterialRepo : IRepository<Material>
{
    private static List<Material> mockMaterials = new()
    {
        new (0L, "Water"),
        new (1L, "Cement"),
        new (2L, "Iron"),
        new (3L, "Sand"),
    };
    
    public Material? GetById(long id)
    {
        return mockMaterials.Find(material => material.Id == id);
    }

    public List<Material> GetAll()
    {
        return mockMaterials;
    }

    public void DeleteById(long id)
    {
        var index = mockMaterials.FindIndex(material => material.Id == id);
        
        if (index != -1)
        {
            mockMaterials.RemoveAt(index);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}