using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OptionsPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsDemoController : ControllerBase
    {
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;

        public OptionsDemoController(ITransientService transientService, IScopedService scopedService, ISingletonService singletonService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
        }

        [HttpGet]
        [Route("/units/transient")]
        public IActionResult GetUnitsTransient() => Ok(_transientService.GetUnits());


        [HttpGet]
        [Route("/units/scoped")]
        public IActionResult GetUnitsScoped() => Ok(_scopedService.GetUnits());

        [HttpGet]
        [Route("/units/singleton")]
        public IActionResult GetUnitsSingleton() => Ok(_singletonService.GetUnits());
    }
}
