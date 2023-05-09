using ZynkRest2.Models;

namespace ZynkRest2.Repositories.Implementations;

public class SamplesRepo : IRepository<Sample>
{
    private static List<Sample> mockSamples = new()
    {
        new(0L, "Concrete", new() {0, 1}),
        new(1L, "Better concrete", new () {0, 1, 3}),
        
        new Sample(2L, "Test0", new () {0}),
        new Sample(3L, "Test1", new () {1}),
        new Sample(4L, "Test2", new () {2}),
        new Sample(5L, "Test3", new () {3}),
        
        new Sample(6L, "Test01", new () {0, 1}),
        new Sample(7L, "Test02", new () {0, 2}),
        new Sample(8L, "Test03", new () {0, 3}),
        new Sample(9L, "Test12", new () {1, 2}),
        new Sample(10L, "Test13", new () {1, 3}),
        new Sample(11L, "Test23", new () {2, 3}),

        new Sample(12L, "Test012", new () {0, 1, 2}),
        new Sample(13L, "Test013", new () {0, 1, 3}),
        new Sample(14L, "Test023", new () {0, 2, 3}),
        new Sample(15L, "Test122", new () {1, 2, 3}),
        
        new Sample(16L, "Test1234", new () {1, 2, 3, 4})
    };

    public Sample? GetById(long id)
    {
        return mockSamples.Find(material => material.Id == id);
    }

    public List<Sample> GetAll()
    {
        return mockSamples;
    }

    public void DeleteById(long id)
    {
        var index = mockSamples.FindIndex(material => material.Id == id);

        if (index != -1)
        {
            mockSamples.RemoveAt(index);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}