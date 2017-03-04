using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using DrillTime.DomainClasses;
using DrillTime.EfData;

namespace DrillTime.WebApi.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using DrillTime.DomainClasses;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Drill>("Drills");
    builder.EntitySet<LogEntry>("LogEntries"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class DrillsController : ODataController
    {
        private DrillDbContext db = new DrillDbContext();

        // GET: odata/Drills
        [EnableQuery]
        public IQueryable<Drill> GetDrills()
        {
            return db.Drills;
        }

        // GET: odata/Drills(5)
        [EnableQuery]
        public SingleResult<Drill> GetDrill([FromODataUri] int key)
        {
            return SingleResult.Create(db.Drills.Where(drill => drill.Id == key));
        }

        // PUT: odata/Drills(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Drill> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Drill drill = db.Drills.Find(key);
            if (drill == null)
            {
                return NotFound();
            }

            patch.Put(drill);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrillExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(drill);
        }

        // POST: odata/Drills
        public IHttpActionResult Post(Drill drill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Drills.Add(drill);
            db.SaveChanges();

            return Created(drill);
        }

        // PATCH: odata/Drills(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Drill> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Drill drill = db.Drills.Find(key);
            if (drill == null)
            {
                return NotFound();
            }

            patch.Patch(drill);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrillExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(drill);
        }

        // DELETE: odata/Drills(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Drill drill = db.Drills.Find(key);
            if (drill == null)
            {
                return NotFound();
            }

            db.Drills.Remove(drill);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Drills(5)/LogEntries
        [EnableQuery]
        public IQueryable<LogEntry> GetLogEntries([FromODataUri] int key)
        {
            return db.Drills.Where(m => m.Id == key).SelectMany(m => m.LogEntries);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DrillExists(int key)
        {
            return db.Drills.Count(e => e.Id == key) > 0;
        }
    }
}
