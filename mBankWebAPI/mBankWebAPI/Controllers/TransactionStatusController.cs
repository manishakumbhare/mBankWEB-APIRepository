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
    public class TransactionStatusController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/TransactionStatus
        public IQueryable<TransactionStatu> GetTransactionStatus()
        {
            return db.TransactionStatus;
        }

        // GET: api/TransactionStatus/5
        [ResponseType(typeof(TransactionStatu))]
        public async Task<IHttpActionResult> GetTransactionStatu(int id)
        {
            TransactionStatu transactionStatu = await db.TransactionStatus.FindAsync(id);
            if (transactionStatu == null)
            {
                return NotFound();
            }

            return Ok(transactionStatu);
        }

        // PUT: api/TransactionStatus/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTransactionStatu(int id, TransactionStatu transactionStatu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != transactionStatu.Id)
            {
                return BadRequest();
            }

            db.Entry(transactionStatu).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionStatuExists(id))
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

        // POST: api/TransactionStatus
        [ResponseType(typeof(TransactionStatu))]
        public async Task<IHttpActionResult> PostTransactionStatu(TransactionStatu transactionStatu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TransactionStatus.Add(transactionStatu);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = transactionStatu.Id }, transactionStatu);
        }

        // DELETE: api/TransactionStatus/5
        [ResponseType(typeof(TransactionStatu))]
        public async Task<IHttpActionResult> DeleteTransactionStatu(int id)
        {
            TransactionStatu transactionStatu = await db.TransactionStatus.FindAsync(id);
            if (transactionStatu == null)
            {
                return NotFound();
            }

            db.TransactionStatus.Remove(transactionStatu);
            await db.SaveChangesAsync();

            return Ok(transactionStatu);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TransactionStatuExists(int id)
        {
            return db.TransactionStatus.Count(e => e.Id == id) > 0;
        }
    }
}