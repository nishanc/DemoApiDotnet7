using DemoApiDotnet7.Data;
using DemoApiDotnet7.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // GET api/asset/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsset(int id)
        {
            var value = await _context.Assets.FirstOrDefaultAsync(x => x.Id == id);

            if (value is null){
                return NotFound();
            }

            var assetToReturn = new AssetToReturn{
                Id = value.Id,
                ItemCode = value.ItemCode,
                Name = value.Name,
                Description = value.Description
            };
            
            return Ok(value);
        }
    }
}