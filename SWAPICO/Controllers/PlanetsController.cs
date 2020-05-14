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
    public class PlanetsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PlanetsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetPlanetById(int id)
        {
            var model = _context.Planets.Find(id);

            if (model == null)
            {
                return NotFound(new { invalid = "Not fount by id" });
            }
            return Ok(model);
        }

        [HttpGet]
        public IActionResult PlanetList()
        {
            var model = _context.Planets.Select(p => new Planet
            {
                Name = p.Name,
                RotationPeriod = p.RotationPeriod,
                OrbitalPeriod = p.OrbitalPeriod,
                Diameter = p.Diameter,
                Climate = p.Climate,
                Gravity = p.Gravity,
                Terrain = p.Terrain,
                SurfaceWater = p.SurfaceWater,
                Population = p.Population,
                URL = p.URL
            }).ToList();

            return Ok(model);
        }
    }
}