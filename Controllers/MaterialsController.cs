using Microsoft.AspNetCore.Mvc;
using ZynkRest2.Models;
using ZynkRest2.Services;

namespace ZynkRest2.Controllers;

[ApiController]
[Route("[controller]")]
public class MaterialsController : ControllerBase
{
    private readonly ILogger<MaterialsController> _logger;
    private readonly IService<Material> _materialService;
    
    public MaterialsController(ILogger<MaterialsController> logger, IService<Material> materialService)
    {
        _logger = logger;
        _materialService = materialService;
    }

    [HttpGet(Name = "GetMaterials")]
    public IEnumerable<Material> GetMaterials()
    {
        _logger.LogInformation("Executing GetMaterials()");
        return _materialService.GetAll();
    }
}