using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using mBankWebAPI.Models;

namespace mBankWebAPI.Controllers
{
    public class View_AdminController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/View_Admin
        public IQueryable<View_Admin> GetView_Admin()
        {
            return db.View_Admin;
        }

        // GET: api/View_Admin/5
        [ResponseType(typeof(View_Admin))]
        public async Task<IHttpActionResult> GetView_Admin(int id)
        {
            View_Admin view_Admin = await db.View_Admin.FindAsync(id);
            if (view_Admin == null)
            {
                return NotFound();
            }

            return Ok(view_Admin);
        }

        // PUT: api/View_Admin/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutView_Admin(int id, View_Admin view_Admin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Admin.ID)
            {
                return BadRequest();
            }

            db.Entry(view_Admin).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_AdminExists(id))
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

        // POST: api/View_Admin
        [ResponseType(typeof(View_Admin))]
        public async Task<IHttpActionResult> PostView_Admin(View_Admin view_Admin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Admin.Add(view_Admin);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = view_Admin.ID }, view_Admin);
        }

        // DELETE: api/View_Admin/5
        [ResponseType(typeof(View_Admin))]
        public async Task<IHttpActionResult> DeleteView_Admin(int id)
        {
            View_Admin view_Admin = await db.View_Admin.FindAsync(id);
            if (view_Admin == null)
            {
                return NotFound();
            }

            db.View_Admin.Remove(view_Admin);
            await db.SaveChangesAsync();

            return Ok(view_Admin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_AdminExists(int id)
        {
            return db.View_Admin.Count(e => e.ID == id) > 0;
        }
    }
}