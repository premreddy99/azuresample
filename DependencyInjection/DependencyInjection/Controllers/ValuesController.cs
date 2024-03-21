using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Common.Models;
namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        public readonly IService _service;
        public ValuesController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<List<Student>> getAll() {
            return await _service.getAll();
        }
    }
}
