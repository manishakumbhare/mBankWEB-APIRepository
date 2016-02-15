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
    public class View_BankController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/View_Bank
        public IQueryable<View_Bank> GetView_Bank()
        {
            return db.View_Bank;
        }

        // GET: api/View_Bank/5
        [ResponseType(typeof(View_Bank))]
        public async Task<IHttpActionResult> GetView_Bank(int id)
        {
            View_Bank view_Bank = await db.View_Bank.FindAsync(id);
            if (view_Bank == null)
            {
                return NotFound();
            }

            return Ok(view_Bank);
        }

        // PUT: api/View_Bank/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutView_Bank(int id, View_Bank view_Bank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Bank.ID)
            {
                return BadRequest();
            }

            db.Entry(view_Bank).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_BankExists(id))
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

        // POST: api/View_Bank
        [ResponseType(typeof(View_Bank))]
        public async Task<IHttpActionResult> PostView_Bank(View_Bank view_Bank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Bank.Add(view_Bank);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = view_Bank.ID }, view_Bank);
        }

        // DELETE: api/View_Bank/5
        [ResponseType(typeof(View_Bank))]
        public async Task<IHttpActionResult> DeleteView_Bank(int id)
        {
            View_Bank view_Bank = await db.View_Bank.FindAsync(id);
            if (view_Bank == null)
            {
                return NotFound();
            }

            db.View_Bank.Remove(view_Bank);
            await db.SaveChangesAsync();

            return Ok(view_Bank);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_BankExists(int id)
        {
            return db.View_Bank.Count(e => e.ID == id) > 0;
        }
    }
}