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
    public class View_ProductController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/View_Product
        public IQueryable<View_Product> GetView_Product()
        {
            return db.View_Product;
        }

        // GET: api/View_Product/5
        [ResponseType(typeof(View_Product))]
        public async Task<IHttpActionResult> GetView_Product(int id)
        {
            View_Product view_Product = await db.View_Product.FindAsync(id);
            if (view_Product == null)
            {
                return NotFound();
            }

            return Ok(view_Product);
        }

        // PUT: api/View_Product/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutView_Product(int id, View_Product view_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Product.ID)
            {
                return BadRequest();
            }

            db.Entry(view_Product).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_ProductExists(id))
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

        // POST: api/View_Product
        [ResponseType(typeof(View_Product))]
        public async Task<IHttpActionResult> PostView_Product(View_Product view_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Product.Add(view_Product);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = view_Product.ID }, view_Product);
        }

        // DELETE: api/View_Product/5
        [ResponseType(typeof(View_Product))]
        public async Task<IHttpActionResult> DeleteView_Product(int id)
        {
            View_Product view_Product = await db.View_Product.FindAsync(id);
            if (view_Product == null)
            {
                return NotFound();
            }

            db.View_Product.Remove(view_Product);
            await db.SaveChangesAsync();

            return Ok(view_Product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_ProductExists(int id)
        {
            return db.View_Product.Count(e => e.ID == id) > 0;
        }
    }
}