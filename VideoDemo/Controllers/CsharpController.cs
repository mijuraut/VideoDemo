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
    public class CsharpController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Csharp> GetAll()
        {
            videoDBContext context = new videoDBContext();
            List<Csharp> csharpVideos = context.Csharp.ToList();
            return csharpVideos;
        }
    }
}