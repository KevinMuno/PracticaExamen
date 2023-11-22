using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen
{
    public class Libro : Publicacion
    {       
        public string Autor { get; set; }
       
        public DateTime FechaPublicacion { get; set; }
        
    }
}
