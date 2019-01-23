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
    public class AngularController : ControllerBase
    {
        // GetAll() toimii postmanissa
        [HttpGet]
        [Route("")]
        public List<Angular> GetAll()
        {
            videoDBContext context = new videoDBContext();
            List<Angular> angularVideos = context.Angular.ToList();
            return angularVideos;
        }

        // GetSingle() toimii postmanissa
        [HttpGet] //<--kun tämä filtteri on voimassa, vastaa metodi vain httpget-pyyntöihin
        [Route("{key}")]  //{key} aaltosulkujen sisällä on muuttujan nimi, ei ole mitenkään varattu sana! Kaksi paraa:  [Route("{key}/{key2}")] 
        public Angular GetSingle(string key) //selaimen polkuviittaus: api/customers/ALFKI (metodi = Get) <--etsii parhaiten täsmäävän rutiinin
        {
            // get the numeric representation of string key (n)
            int.TryParse(key, out int n);
            videoDBContext context = new videoDBContext();
            Angular angularVid = context.Angular.Find(n);
            Console.WriteLine("get-key -metodissa. context.Angular.Find(key) = " + context.Angular.Find(n));
            
            return angularVid;
        }

        // PutEdit() toimii postmanissa
        [HttpPut]
        [Route("{key}")]
        public string PutEdit(string key, [FromBody] Angular newData) // Key on routessa ja toinen parametri (dataolio) tulee HTTP Bodyssä
        {
            System.Diagnostics.Debug.Write("PutEdit-metodissa");
            int.TryParse(key, out int n);
            videoDBContext context = new videoDBContext();
            Angular angular = context.Angular.Find(n);


            if (angular != null)
            {
                angular.VideoId = newData.VideoId;
                angular.Url = newData.Url;
                angular.Description = newData.Description;
                angular.LengthMinutes = newData.LengthMinutes;
                angular.DateAdded = newData.DateAdded;

                context.SaveChanges();
                return "OK";
            }
            return "NOT FOUND";
        }

        // PostCreateNew() toimii Postmanissa, mutta ei saa syöttää videoID:tä tälle 
        // (se luodaan automaattisesti)
        [HttpPost]
        [Route("")]
        public string PostCreateNew([FromBody] Angular angularVid)
        {
            System.Diagnostics.Debug.Write("\n\nPost-metodissa\n\n");
            //Angular angularVid2 = new Angular();
            videoDBContext context = new videoDBContext();
            //context.Angular.Add(angularVid);
            //angularVid2.Url = angularVid.Url;
            //angularVid2.Description = angularVid.Description;
            //angularVid2.LengthMinutes = angularVid.LengthMinutes;
            //angularVid2.DateAdded = angularVid.DateAdded;

            if (!ModelState.IsValid)
            {
                return "bad request";
            }

            context.Angular.Add(angularVid);
            context.SaveChangesAsync();
            CreatedAtAction("GetAngular", new { id = angularVid.VideoId }, angularVid);

            return "OK";
        }

        //// POST: api/Sqls
        //[HttpPost]
        //public async Task<IActionResult> PostAngular([FromBody] Angular angular)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Angular.Add(angular);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSql", new { id = sql.VideoId }, sql);
        //}

        // DeleteSingle() toimii Postmanissa
        [HttpDelete]
        [Route("{key}")]
        public string DeleteSingle(string key)
        {
            System.Diagnostics.Debug.Write("Delete-metodissa");
            int.TryParse(key, out int n);
            videoDBContext context = new videoDBContext();
            Angular angular = context.Angular.Find(n);

            if (angular != null)
            {
                context.Angular.Remove(angular);
                context.SaveChanges();
                return "DELETED";
            }
            return "NOT FOUND";
        }
        //[HttpDelete]
        //[Route("{key}")]
        //public string DeleteSingle(string key)
        //{
        //    northwindContext context = new northwindContext();
        //    Customers asiakas = context.Customers.Find(key);

        //    if (asiakas != null)
        //    {
        //        context.Customers.Remove(asiakas);
        //        context.SaveChanges();
        //        return "DELETED";
        //    }

        //    return "NOT FOUND";
        //}

        //[HttpPost] //<--filtteri rajoittaa alapuolella olevan metodin vain POST-pyyntöihin (uuden asian luominen tai lisääminen)
        //[Route("")] //<--tyhjä reitinmääritys (ei ole pakko laittaa), eli ei mitään lisättävää reittiin, jolloin
        //public string PostCreateNew([FromBody] Customers customer) //<-- [FromBody] tarkoittaa, että HTTP-pyynnön Body:ssä välitetään JSON-muodossa oleva objekti ,joka om Customers-tyyppinen customer-niminen
        //{
        //    northwindContext context = new northwindContext(); //Context = Kuten entities muodostettu Scaffold DBContext -tykalulla. Voisi olla myös entiteetti frameworkCore
        //    context.Customers.Add(customer);
        //    context.SaveChanges();

        //    return customer.CustomerId; //kuittaus Frontille, että päivitys meni oikein --> Frontti voi tsekata, että kontrolleri palauttaa saman id:n mitä käsitteli
        //}

    }
}