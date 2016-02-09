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
    public class UsersRolesController : ApiController
    {
        private BankEntities db = new BankEntities();

        // GET: api/UsersRoles
        public IQueryable<UsersRole> GetUsersRoles()
        {
            return db.UsersRoles;
        }

        // GET: api/UsersRoles/5
        [ResponseType(typeof(UsersRole))]
        public async Task<IHttpActionResult> GetUsersRole(int id)
        {
            UsersRole usersRole = await db.UsersRoles.FindAsync(id);
            if (usersRole == null)
            {
                return NotFound();
            }

            return Ok(usersRole);
        }

        // PUT: api/UsersRoles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUsersRole(int id, UsersRole usersRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usersRole.ID)
            {
                return BadRequest();
            }

            db.Entry(usersRole).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersRoleExists(id))
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

        // POST: api/UsersRoles
        [ResponseType(typeof(UsersRole))]
        public async Task<IHttpActionResult> PostUsersRole(UsersRole usersRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UsersRoles.Add(usersRole);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = usersRole.ID }, usersRole);
        }

        // DELETE: api/UsersRoles/5
        [ResponseType(typeof(UsersRole))]
        public async Task<IHttpActionResult> DeleteUsersRole(int id)
        {
            UsersRole usersRole = await db.UsersRoles.FindAsync(id);
            if (usersRole == null)
            {
                return NotFound();
            }

            db.UsersRoles.Remove(usersRole);
            await db.SaveChangesAsync();

            return Ok(usersRole);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersRoleExists(int id)
        {
            return db.UsersRoles.Count(e => e.ID == id) > 0;
        }
    }
}