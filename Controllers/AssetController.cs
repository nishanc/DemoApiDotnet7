using DemoApiDotnet7.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiDotnet7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly DataContext _context;
        public AssetController(DataContext context)
        {
            _context = context;
        }
    }
}