namespace ZynkRest2.Models;

public class Sample
{
    public long Id { get; set; }
    public string Name { get; set; }
    public List<long> MaterialIds { get; set; }

    public Sample(long id, string name) => (Id, Name) = (id, name);
    public Sample(long id, string name, List<long> materialIds) => (Id, Name, MaterialIds) = (id, name, materialIds);
}