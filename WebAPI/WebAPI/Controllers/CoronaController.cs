using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CoronaController : ApiController
    {
        // GET: /Corona
        [Route("Corona")]
        [HttpGet]
        public List<Datum> Get()
        {
            CoronaOperations coop = new CoronaOperations();
            return coop.GetTheRecords(100, "ASC");
        }

        /*
        // GET: api/Corona
        public List<Datum> Get(string country)
        {
            CoronaOperations coop = new CoronaOperations();
            return coop.GetTheRecords(string.Format("SELECT * FROM theStats WHERE countrycode = '{0}'", country));
        }
        */
        // GET: api/Corona/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: /Corona
        [Route("Corona")]
        [HttpPost]
        // POST: api/Corona
        public void Post([FromBody]Datum datum)
        {
            CoronaOperations coop = new CoronaOperations();
            coop.InsertRecord(datum);
        }

        // PUT: api/Corona/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Corona/5
        public void Delete(int id)
        {
        }
    }
}
