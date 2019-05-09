using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoApi.Models;

namespace ProjetoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            using (var db = new projetoapiContext())
            {
                return db.Usuario.ToList();
            }
        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "Get")]
        public Usuario Get(int id)
        {
            using (var db = new projetoapiContext())
            {
                return db.Usuario.FirstOrDefault(x => x.IdUser == id);
            }
        }
        
        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody]Usuario usuario)
        {
            using (var db = new projetoapiContext())
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
            }
        }
        
        // PUT: api/Usuario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
