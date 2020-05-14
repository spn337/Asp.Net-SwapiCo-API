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
    public class PeopleController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PeopleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonById(int id)
        {
            var model = _context.People.Find(id);

            if (model == null)
            {
                return NotFound(new { invalid = "Not fount by id" });
            }
            return Ok(model);
        }

        [HttpGet]
        public IActionResult PeopleList()
        {
            var result = _context.People.Select(p => new Person
            {
                Name = p.Name,
                Height = p.Height,
                Mass = p.Mass,
                HairColor = p.HairColor,
                SkinColor = p.SkinColor,
                EyeColor = p.EyeColor,
                BirthYear = p.BirthYear,
                Gender = p.Gender,
                Homeworld = p.Homeworld,
                URL = p.URL
            }).ToList();
            return Ok(result);
        }
    }
}