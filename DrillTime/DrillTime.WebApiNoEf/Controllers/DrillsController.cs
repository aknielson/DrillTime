using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using DrillTime.DomainClasses;
using DrillTime.EfData;

namespace DrillTime.WebApiNoEf.Controllers
{
    public class DrillsController : ApiController
    {

        private UnitOfWork uow = new UnitOfWork();

        // GET: api/Drills

        public IEnumerable<Drill> Get()
        {
            var drills = uow.Drills;
            var foob = drills.GetAll();
            return foob;
        }

        // GET: api/Drills/5
        public Drill Get(int id)
        {
            var drill = uow.Drills.Get(id);
            return drill;
        }

        // POST: api/Drills
        public IHttpActionResult Post([FromBody]Drill drill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            uow.Drills.Add(drill);
            uow.Complete();

            return new OkResult(this);

         
        }

        // PUT: api/Drills/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Drills/5
        public void Delete(int id)
        {
        }
    }
}
