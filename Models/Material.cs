namespace ZynkRest2.Models;

public class Material
{
    public long Id { get; set; }

    public string Name { get; set; }

    public Material(long id, string name) => (Id, Name) = (id, name);

}