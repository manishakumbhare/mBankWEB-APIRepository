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
    public class SuperAdminsController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/SuperAdmins
        public IQueryable<SuperAdmin> GetSuperAdmins()
        {
            return db.SuperAdmins;
        }

        // GET: api/SuperAdmins/5
        [ResponseType(typeof(SuperAdmin))]
        public async Task<IHttpActionResult> GetSuperAdmin(int id)
        {
            SuperAdmin superAdmin = await db.SuperAdmins.FindAsync(id);
            if (superAdmin == null)
            {
                return NotFound();
            }

            return Ok(superAdmin);
        }

        // PUT: api/SuperAdmins/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSuperAdmin(int id, SuperAdmin superAdmin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != superAdmin.ID)
            {
                return BadRequest();
            }

            db.Entry(superAdmin).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuperAdminExists(id))
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

        // POST: api/SuperAdmins
        [ResponseType(typeof(SuperAdmin))]
        public async Task<IHttpActionResult> PostSuperAdmin(SuperAdmin superAdmin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SuperAdmins.Add(superAdmin);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = superAdmin.ID }, superAdmin);
        }

        // DELETE: api/SuperAdmins/5
        [ResponseType(typeof(SuperAdmin))]
        public async Task<IHttpActionResult> DeleteSuperAdmin(int id)
        {
            SuperAdmin superAdmin = await db.SuperAdmins.FindAsync(id);
            if (superAdmin == null)
            {
                return NotFound();
            }

            db.SuperAdmins.Remove(superAdmin);
            await db.SaveChangesAsync();

            return Ok(superAdmin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SuperAdminExists(int id)
        {
            return db.SuperAdmins.Count(e => e.ID == id) > 0;
        }
    }
}