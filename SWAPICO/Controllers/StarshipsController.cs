using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWAPICO.Entities;
using SWAPICO.Models;

namespace SWAPICO.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class StarshipsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StarshipsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetStarshipById(int id)
        {
            var model = _context.Starships.Find(id);

            if (model == null)
            {
                return NotFound(new { invalid = "Not fount by id" });
            }
            return Ok(model);
        }

        [HttpGet]
        public IActionResult StarshipList()
        {
            var model = _context.Starships.Select(p => new Starship
            {
                Name = p.Name,
                Model = p.Model,
                Manufacturer = p.Manufacturer,
                CostInCredits = p.CostInCredits,
                Length = p.Length,
                MaxAtmospheringSpeed = p.MaxAtmospheringSpeed,
                Crew = p.Crew,
                Passengers = p.Passengers,
                URL = p.URL
            }).ToList();

            return Ok(model);
        }
    }
}