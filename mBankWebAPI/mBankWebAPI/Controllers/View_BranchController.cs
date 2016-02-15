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
    public class View_BranchController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/View_Branch
        public IQueryable<View_Branch> GetView_Branch()
        {
            return db.View_Branch;
        }

        // GET: api/View_Branch/5
        [ResponseType(typeof(View_Branch))]
        public async Task<IHttpActionResult> GetView_Branch(int id)
        {
            View_Branch view_Branch = await db.View_Branch.FindAsync(id);
            if (view_Branch == null)
            {
                return NotFound();
            }

            return Ok(view_Branch);
        }

        // PUT: api/View_Branch/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutView_Branch(int id, View_Branch view_Branch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Branch.ID)
            {
                return BadRequest();
            }

            db.Entry(view_Branch).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_BranchExists(id))
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

        // POST: api/View_Branch
        [ResponseType(typeof(View_Branch))]
        public async Task<IHttpActionResult> PostView_Branch(View_Branch view_Branch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Branch.Add(view_Branch);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = view_Branch.ID }, view_Branch);
        }

        // DELETE: api/View_Branch/5
        [ResponseType(typeof(View_Branch))]
        public async Task<IHttpActionResult> DeleteView_Branch(int id)
        {
            View_Branch view_Branch = await db.View_Branch.FindAsync(id);
            if (view_Branch == null)
            {
                return NotFound();
            }

            db.View_Branch.Remove(view_Branch);
            await db.SaveChangesAsync();

            return Ok(view_Branch);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_BranchExists(int id)
        {
            return db.View_Branch.Count(e => e.ID == id) > 0;
        }
    }
}