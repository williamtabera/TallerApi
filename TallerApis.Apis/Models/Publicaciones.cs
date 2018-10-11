using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApis.Apis.Models
{
    public class Publicaciones : DbContext
    {
        public Publicaciones() : base("PlublicacionConnection")
        {

        }
    }
}