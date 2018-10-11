using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerApis.Apis.Models;

namespace TallerApis.Apis.Controllers
{
    public class PublicacionesController : ApiController
    {
        [HttpGet]
        public IEnumerable<tblPublicacion> Get()
        {
            using (var context = new Publicaciones())
            {
                return context.Publicacion.ToList();
            }
        }

        [HttpGet]
        public tblPublicacion Get(int id)
        {
            using (var context = new Publicaciones())
            {
                return context.Publicacion.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(tblPublicacion producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new Publicaciones())
            {
                context.Publicacion.Add(producto);
                context.SaveChanges();
                return Ok(producto);
            }
        }

        [HttpPut]
        public tblPublicacion Put(tblPublicacion publicacion)
        {
            using (var context = new Publicaciones())
            {
                var publicacionAct = context.Publicacion.FirstOrDefault(x => x.Id == publicacion.Id);
                publicacionAct.Usuario = publicacion.Usuario;
                publicacionAct.Descripcion = publicacion.Descripcion;
                publicacionAct.FechaPublicacion = publicacion.FechaPublicacion;
                publicacionAct.MeGusta = publicacion.MeGusta;
                publicacionAct.MeDisGusta = publicacion.MeDisGusta;
                publicacionAct.VecesCompartido = publicacion.VecesCompartido;
                publicacionAct.EsPrivada = publicacion.EsPrivada;
                context.SaveChanges();
                return publicacion;
            }
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            using (var context = new Publicaciones())
            {
                var productoDel = context.Publicacion.FirstOrDefault(x => x.Id == Id);
                context.Publicacion.Remove(productoDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}
