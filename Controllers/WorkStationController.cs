using DemoApiDotnet7.Data;
using DemoApiDotnet7.DTOs;
using DemoApiDotnet7.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiDotnet7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkStationController : ControllerBase
    {
        private readonly DataContext _context;
        public WorkStationController(DataContext context)
        {
            _context = context;
        }

        // POST api/WorkStation
        [HttpPost]
        public async Task<IActionResult> NewAsset([FromBody] WorkStationToInsert workStationToInsert)
        {
            if (workStationToInsert is null){
                return BadRequest();
            }
            var workstation = new WorkStation{
                Code = workStationToInsert.Code
            };

            try
            {
                await _context.WorkStations.AddAsync(workstation);
                await _context.SaveChangesAsync();   
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
                return StatusCode(500);
            }
            
            return Ok(workstation);
        }
    }
}