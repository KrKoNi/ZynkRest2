using Microsoft.AspNetCore.Mvc;
using ZynkRest2.Models;
using ZynkRest2.Services;
using ZynkRest2.Services.Implementations;

namespace ZynkRest2.Controllers;

[ApiController]
[Route("[controller]")]
public class SamplesController : ControllerBase
{
    private readonly ILogger<SamplesController> _logger;
    private readonly IService<Sample> _samplesService;
    
    public SamplesController(ILogger<SamplesController> logger, IService<Sample> samplesService)
    {
        _logger = logger;
        _samplesService = samplesService;
    }

    [HttpGet(Name = "GetSamples")]
    public IEnumerable<Sample> GetSamples()
    {
        _logger.LogInformation("Executing GetSamples()");
        return _samplesService.GetAll();
    }
    
    [HttpPost(Name = "GetSamplesByMaterials")]
    public IEnumerable<Sample> GetSamplesByMaterials(List<long> materialIds)
    {
        _logger.LogInformation("Executing GetSamplesByMaterials()");
        return _samplesService.GetByIdIntersection(materialIds);
    }
}