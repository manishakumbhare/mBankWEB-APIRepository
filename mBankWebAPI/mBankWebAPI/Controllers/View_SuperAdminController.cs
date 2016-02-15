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
    public class View_SuperAdminController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/View_SuperAdmin
        public IQueryable<View_SuperAdmin> GetView_SuperAdmin()
        {
            return db.View_SuperAdmin;
        }




        // GET: api/View_SuperAdmin/5
        [ResponseType(typeof(View_SuperAdmin))]
        public async Task<IHttpActionResult> GetView_SuperAdmin(int id)
        {
            View_SuperAdmin view_SuperAdmin = await db.View_SuperAdmin.FindAsync(id);
            if (view_SuperAdmin == null)
            {
                return NotFound();
            }

            return Ok(view_SuperAdmin);
        }

        // PUT: api/View_SuperAdmin/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutView_SuperAdmin(int id, View_SuperAdmin view_SuperAdmin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_SuperAdmin.ID)
            {
                return BadRequest();
            }

            db.Entry(view_SuperAdmin).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_SuperAdminExists(id))
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

        // POST: api/View_SuperAdmin
        [ResponseType(typeof(View_SuperAdmin))]
        public async Task<IHttpActionResult> PostView_SuperAdmin(View_SuperAdmin view_SuperAdmin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_SuperAdmin.Add(view_SuperAdmin);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = view_SuperAdmin.ID }, view_SuperAdmin);
        }

        // DELETE: api/View_SuperAdmin/5
        [ResponseType(typeof(View_SuperAdmin))]
        public async Task<IHttpActionResult> DeleteView_SuperAdmin(int id)
        {
            View_SuperAdmin view_SuperAdmin = await db.View_SuperAdmin.FindAsync(id);
            if (view_SuperAdmin == null)
            {
                return NotFound();
            }

            db.View_SuperAdmin.Remove(view_SuperAdmin);
            await db.SaveChangesAsync();

            return Ok(view_SuperAdmin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_SuperAdminExists(int id)
        {
            return db.View_SuperAdmin.Count(e => e.ID == id) > 0;
        }
    }
}