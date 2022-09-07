using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lms.Data.Data;
using Lms.Core.Enteties;

namespace Lms.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesController : ControllerBase
    {
        private readonly LmsApiContext db;

        public ModulesController(LmsApiContext context)
        {
            db = context;
        }

        // GET: api/Modules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Module>>> GetModule()
        {
          if (db.Module == null)
          {
              return NotFound();
          }
            return await db.Module.ToListAsync();
        }

        // GET: api/Modules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Module>> GetModule(int id)
        {
          if (db.Module == null)
          {
              return NotFound();
          }
            var @module = await db.Module.FindAsync(id);

            if (@module == null)
            {
                return NotFound();
            }

            return @module;
        }
    }
}
