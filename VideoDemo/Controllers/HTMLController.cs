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
    public class HTMLController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Html> GetAll()
        {
            videoDBContext context = new videoDBContext();
            List<Html> HTMLVideos = context.Html.ToList();
            return HTMLVideos;
        }
    }
}