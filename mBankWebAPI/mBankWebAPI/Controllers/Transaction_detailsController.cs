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
    public class Transaction_detailsController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/Transaction_details
        public IQueryable<Transaction_details> GetTransaction_details()
        {
            return db.Transaction_details;
        }

        // GET: api/Transaction_details/5
        [ResponseType(typeof(Transaction_details))]
        public async Task<IHttpActionResult> GetTransaction_details(int id)
        {
            Transaction_details transaction_details = await db.Transaction_details.FindAsync(id);
            if (transaction_details == null)
            {
                return NotFound();
            }

            return Ok(transaction_details);
        }

        // PUT: api/Transaction_details/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTransaction_details(int id, Transaction_details transaction_details)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transaction_details.ID)
            {
                return BadRequest();
            }

            db.Entry(transaction_details).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Transaction_detailsExists(id))
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

        // POST: api/Transaction_details
        [ResponseType(typeof(Transaction_details))]
        public async Task<IHttpActionResult> PostTransaction_details(Transaction_details transaction_details)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Transaction_details.Add(transaction_details);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = transaction_details.ID }, transaction_details);
        }

        // DELETE: api/Transaction_details/5
        [ResponseType(typeof(Transaction_details))]
        public async Task<IHttpActionResult> DeleteTransaction_details(int id)
        {
            Transaction_details transaction_details = await db.Transaction_details.FindAsync(id);
            if (transaction_details == null)
            {
                return NotFound();
            }

            db.Transaction_details.Remove(transaction_details);
            await db.SaveChangesAsync();

            return Ok(transaction_details);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Transaction_detailsExists(int id)
        {
            return db.Transaction_details.Count(e => e.ID == id) > 0;
        }
    }
}