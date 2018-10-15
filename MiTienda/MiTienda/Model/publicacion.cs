﻿using Java.Lang;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiTienda.Model
{
    class publicacion
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Megusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivada { get; set; }

    }
}
