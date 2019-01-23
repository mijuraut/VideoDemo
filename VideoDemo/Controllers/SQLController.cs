using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoDemo.Models;

namespace VideoDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SQLController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Sql> GetAll()
        {
            videoDBContext context = new videoDBContext();
            List<Sql> SQLVideos = context.Sql.ToList();
            Console.Write("Jee SQL lista valmis. :]");
            return SQLVideos;
        }
    }
}