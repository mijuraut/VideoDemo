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
    public class JavaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Java> GetAll()
        {
            videoDBContext context = new videoDBContext();
            List<Java> JavaVideos = context.Java.ToList();
            return JavaVideos;
        }
    }
}