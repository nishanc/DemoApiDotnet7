using DemoApiDotnet7.Data;
using DemoApiDotnet7.DTOs;
using DemoApiDotnet7.Models;
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
            var value = await _context.Assets.Include(x => x.WorkStation).FirstOrDefaultAsync(x => x.Id == id);

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

        // POST api/Asset
        [HttpPost]
        public async Task<IActionResult> NewAsset([FromBody] AssetToInsert assetToInsert)
        {
            if (assetToInsert is null){
                return BadRequest();
            }
            var asset = new Asset{
                ItemCode = assetToInsert.ItemCode,
                Name = assetToInsert.Name,
                Description = assetToInsert.Description,
                WorkStationId = assetToInsert.WorkStationId
            };

            try
            {
                await _context.Assets.AddAsync(asset);
                await _context.SaveChangesAsync();   
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
                return StatusCode(500);
            }
            
            return Ok(asset);
        }
    }
}