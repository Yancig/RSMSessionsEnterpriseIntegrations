using Microsoft.AspNetCore.Mvc;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;

namespace RSMEnterpriseIntegrationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderHeaderController : ControllerBase
    {
        private readonly ISalesOrderHeaderService _salesOrderHeaderService;


        public SalesOrderHeaderController(ISalesOrderHeaderService service)
        {

            _salesOrderHeaderService = service;
        }

        [HttpGet("GetAll")]

        public async Task <IActionResult>Get()
        {
            return Ok(await _salesOrderHeaderService.GetAllSalesOrderHeaders());
        }
    }
}
