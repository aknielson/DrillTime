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
    builder.EntitySet<LogEntry>("LogEntries");
    builder.EntitySet<Drill>("Drills"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class LogEntriesController : ODataController
    {
        private DrillDbContext db = new DrillDbContext();

        // GET: odata/LogEntries
        [EnableQuery]
        public IQueryable<LogEntry> GetLogEntries()
        {
            return db.LogEntries;
        }

        // GET: odata/LogEntries(5)
        [EnableQuery]
        public SingleResult<LogEntry> GetLogEntry([FromODataUri] int key)
        {
            return SingleResult.Create(db.LogEntries.Where(logEntry => logEntry.Id == key));
        }

        // PUT: odata/LogEntries(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<LogEntry> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            LogEntry logEntry = db.LogEntries.Find(key);
            if (logEntry == null)
            {
                return NotFound();
            }

            patch.Put(logEntry);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogEntryExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(logEntry);
        }

        // POST: odata/LogEntries
        public IHttpActionResult Post(LogEntry logEntry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LogEntries.Add(logEntry);
            db.SaveChanges();

            return Created(logEntry);
        }

        // PATCH: odata/LogEntries(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<LogEntry> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            LogEntry logEntry = db.LogEntries.Find(key);
            if (logEntry == null)
            {
                return NotFound();
            }

            patch.Patch(logEntry);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogEntryExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(logEntry);
        }

        // DELETE: odata/LogEntries(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            LogEntry logEntry = db.LogEntries.Find(key);
            if (logEntry == null)
            {
                return NotFound();
            }

            db.LogEntries.Remove(logEntry);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/LogEntries(5)/Drill
        [EnableQuery]
        public SingleResult<Drill> GetDrill([FromODataUri] int key)
        {
            return SingleResult.Create(db.LogEntries.Where(m => m.Id == key).Select(m => m.Drill));
        }

    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LogEntryExists(int key)
        {
            return db.LogEntries.Count(e => e.Id == key) > 0;
        }
    }
}
