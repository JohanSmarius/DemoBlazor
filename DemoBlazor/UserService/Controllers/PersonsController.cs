using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var result = new List<User>()
            {
                new User()
                {
                    Name = "Daniel Roth",
                    Email = "daniel@microsoft.com",
                    PhoneNumber = "12345468",
                    Picture = "https://avatars2.githubusercontent.com/u/1874516?s=460&v=4"
                },
                new User()
                {
                    Name = "Luke Latham",
                    Email = "luke@microsoft.com",
                    PhoneNumber = "12345468",
                    Picture =
                        "https://avatars0.githubusercontent.com/u/1622880?s=460&v=4"
                }
            };

            return Ok(result);
        } 
    }
}
