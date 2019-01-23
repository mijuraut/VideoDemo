//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using VideoDemo.Models;

//namespace VideoDemo.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class SqlsController : ControllerBase
//    {
//        private readonly videoDBContext _context;

//        public SqlsController(videoDBContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Sqls
//        [HttpGet]
//        public IEnumerable<Sql> GetSql()
//        {
//            return _context.Sql;
//        }

//        // GET: api/Sqls/5
//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetSql([FromRoute] int id)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            var sql = await _context.Sql.FindAsync(id);

//            if (sql == null)
//            {
//                return NotFound();
//            }

//            return Ok(sql);
//        }

//        // PUT: api/Sqls/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutSql([FromRoute] int id, [FromBody] Sql sql)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            if (id != sql.VideoId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(sql).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!SqlExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Sqls
//        [HttpPost]
//        public async Task<IActionResult> PostSql([FromBody] Sql sql)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            _context.Sql.Add(sql);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetSql", new { id = sql.VideoId }, sql);
//        }

//        // DELETE: api/Sqls/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteSql([FromRoute] int id)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            var sql = await _context.Sql.FindAsync(id);
//            if (sql == null)
//            {
//                return NotFound();
//            }

//            _context.Sql.Remove(sql);
//            await _context.SaveChangesAsync();

//            return Ok(sql);
//        }

//        private bool SqlExists(int id)
//        {
//            return _context.Sql.Any(e => e.VideoId == id);
//        }
//    }
//}