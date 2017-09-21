using System;
using System.Collections.Generic;
using System.Linq;
using Joker.Controllers;
using Joker.Data;
using Joker.Objects;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Test
{
    public class JokesControllerTests
    {
        [Fact]
        public void QueryJokes_Should_Return_List_Of_Jokes()
        {
        }

        [Fact]
        public void CreateJoke_Should_Return_201()
        {
            Assert.Equal(true, false);
        }
    }
}
