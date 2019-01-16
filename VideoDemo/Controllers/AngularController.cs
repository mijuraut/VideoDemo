using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoDemo.Models;

namespace VideoDemo.Controllers
{
    [Route("toiminnot/[controller]")]
    [ApiController]
    public class AngularController : ControllerBase
    {
        [HttpGet] // <-- kun tämä filtteri on voimassa, vain Get-kutsut menee läpi
        [Route("")]
        public List<Angular> GetAll()
        {
            videoDBContext context = new videoDBContext();
            List<Angular> angularVideos = context.Angular.ToList();
            return angularVideos;
        }

    }
}