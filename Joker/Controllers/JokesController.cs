using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Joker.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Joker.Controllers
{
    [Produces("application/json")]
    [Route("api/jokes")]
    public class JokesController : Controller
    {
        private static List<Joke> Jokes;

        static JokesController()
        {
            Jokes = new List<Joke>();
            Jokes.Add(new Joke()
            {
                Id = Guid.NewGuid(),
                Content = "This is the funniest joke ever!",
                LikeCount = 42
            });
        }

        [HttpGet("")]
        public async Task<IActionResult> QueryJokes()
        {
            return Ok(Jokes);
        }
    }
}