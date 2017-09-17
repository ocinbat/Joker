using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Joker.Data;
using Joker.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joker.Controllers
{
    [Produces("application/json")]
    [Route("api/jokes")]
    public class JokesController : Controller
    {
        private readonly DataContext _context;

        public JokesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> QueryJokes()
        {
            return Ok(await _context.Jokes.ToListAsync());
        }
    }
}