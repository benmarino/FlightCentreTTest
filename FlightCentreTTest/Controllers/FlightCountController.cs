using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlightCentreTTest.Controllers
{
    public class FlightCountController : ApiController
    {
        // GET: api/FlightCount
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FlightCount/5
        public string Get([FromUri] string value)
        {
            List<int> instanceCount = new List<int>();
            instanceCount.Add(CountChars(value, 'f'));
            instanceCount.Add(CountChars(value, 'l'));
            instanceCount.Add(CountChars(value, 'i'));
            instanceCount.Add(CountChars(value, 'g'));
            instanceCount.Add(CountChars(value, 'h'));
            instanceCount.Add(CountChars(value, 't'));
            instanceCount.Sort();
            return instanceCount[0].ToString();
        }
        protected int CountChars(string source, char toFind)
        {
            return source.Count(t => t == toFind);
        }
        // POST: api/FlightCount
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/FlightCount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FlightCount/5
        public void Delete(int id)
        {
        }
    }
}
