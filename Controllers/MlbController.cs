using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dugout.WebApi.Services;
using dugout.WebApi.Models;

namespace dugout.WebApi.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class MlbController : ControllerBase
    {
        public IMlbService _mlbService;
        public MlbContext _context; 
        public MlbController(IMlbService mlbService, MlbContext context) {
          _mlbService = mlbService;
          _context = context;
        }
        [HttpPost]
        public async Task<IEnumerable<Team>> UpdateTeams()
        { 
            var teams = await _mlbService.GetTeams(SportIds.Mlb);
            _context.Teams.AddRange(teams);
            _context.SaveChanges();
            return teams;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}