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
    public class View_LanguageController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/View_Language
        public IQueryable<View_Language> GetView_Language()
        {
            return db.View_Language;
        }

        // GET: api/View_Language/5
        [ResponseType(typeof(View_Language))]
        public async Task<IHttpActionResult> GetView_Language(int id)
        {
            View_Language view_Language = await db.View_Language.FindAsync(id);
            if (view_Language == null)
            {
                return NotFound();
            }

            return Ok(view_Language);
        }

        // PUT: api/View_Language/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutView_Language(int id, View_Language view_Language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != view_Language.ID)
            {
                return BadRequest();
            }

            db.Entry(view_Language).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!View_LanguageExists(id))
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

        // POST: api/View_Language
        [ResponseType(typeof(View_Language))]
        public async Task<IHttpActionResult> PostView_Language(View_Language view_Language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.View_Language.Add(view_Language);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = view_Language.ID }, view_Language);
        }

        // DELETE: api/View_Language/5
        [ResponseType(typeof(View_Language))]
        public async Task<IHttpActionResult> DeleteView_Language(int id)
        {
            View_Language view_Language = await db.View_Language.FindAsync(id);
            if (view_Language == null)
            {
                return NotFound();
            }

            db.View_Language.Remove(view_Language);
            await db.SaveChangesAsync();

            return Ok(view_Language);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool View_LanguageExists(int id)
        {
            return db.View_Language.Count(e => e.ID == id) > 0;
        }
    }
}