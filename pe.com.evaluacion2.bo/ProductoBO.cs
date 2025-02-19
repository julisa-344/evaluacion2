using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.evaluacion2.bo
{
    public class ProductoBO
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public double cantidad { get; set; }
        public bool estado { get; set; }
        public MarcaBO marca { get; set; }
        public CategoriaBO categoria { get; set; }
    }
}