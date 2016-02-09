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
using mBankWebAPI.Models;

namespace mBankWebAPI.Controllers
{
    public class ManagersController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/Managers
        public IQueryable<Manager> GetManagers()
        {
            return db.Managers;
        }

        // GET: api/Managers/5
        [ResponseType(typeof(Manager))]
        public IHttpActionResult GetManager(int id)
        {
            Manager manager = db.Managers.Find(id);
            if (manager == null)
            {
                return NotFound();
            }

            return Ok(manager);
        }

        // PUT: api/Managers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutManager(int id, Manager manager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != manager.ID)
            {
                return BadRequest();
            }

            db.Entry(manager).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManagerExists(id))
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

        // POST: api/Managers
        [ResponseType(typeof(Manager))]
        public IHttpActionResult PostManager(Manager manager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Managers.Add(manager);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = manager.ID }, manager);
        }

        // DELETE: api/Managers/5
        [ResponseType(typeof(Manager))]
        public IHttpActionResult DeleteManager(int id)
        {
            Manager manager = db.Managers.Find(id);
            if (manager == null)
            {
                return NotFound();
            }

            db.Managers.Remove(manager);
            db.SaveChanges();

            return Ok(manager);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ManagerExists(int id)
        {
            return db.Managers.Count(e => e.ID == id) > 0;
        }
    }
}