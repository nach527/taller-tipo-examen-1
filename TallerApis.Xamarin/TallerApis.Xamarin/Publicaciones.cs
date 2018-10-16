using System;
using System.Collections.Generic;
using System.Text;

namespace TallerApis.Xamarin
{
    class Publicaciones
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPubliciacion { get; set; }
        public int MeGusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivado { get; set; }
    }
}
