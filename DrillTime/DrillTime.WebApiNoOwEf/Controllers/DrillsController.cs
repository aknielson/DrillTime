using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DrillTime.DomainClasses;
using DrillTime.EfData;

namespace DrillTime.WebApiNoOwEf.Controllers
{
    public class DrillsController : ApiController
    {
        private DrillDbContext db = new DrillDbContext();

        // GET: api/Drills
        public IQueryable<Drill> GetDrills()
        {
            return db.Drills;
        }

        // GET: api/Drills/5
        [ResponseType(typeof(Drill))]
        public IHttpActionResult GetDrill(int id)
        {
            if (id == 0)
                return Ok(new Drill {Id = 0});

            Drill drill = db.Drills.Find(id);
            if (drill == null)
            {
                return NotFound();
            }

            return Ok(drill);
        }

        // PUT: api/Drills/5
        [ResponseType(typeof(IHttpActionResult))]
        public IHttpActionResult PutDrill(int id, Drill drill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != drill.Id)
            {
                return BadRequest();
            }

            db.Entry(drill).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrillExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Drills
        [ResponseType(typeof(IHttpActionResult))]
        public IHttpActionResult PostDrill(Drill drill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (drill.Id == 0)
            {
                db.Drills.Add(drill);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new {id = drill.Id}, drill);
            }
            else
            {
                return PutDrill(drill.Id, drill);
            }
        }

        // DELETE: api/Drills/5
        [ResponseType(typeof(Drill))]
        public IHttpActionResult DeleteDrill(int id)
        {
            Drill drill = db.Drills.Find(id);
            if (drill == null)
            {
                return NotFound();
            }

            db.Drills.Remove(drill);
            db.SaveChanges();

            return Ok(drill);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DrillExists(int id)
        {
            return db.Drills.Count(e => e.Id == id) > 0;
        }
    }
}