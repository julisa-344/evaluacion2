using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.evaluacion2.bo
{
    public class ClienteBO
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string correoElectronico { get; set; }
        public bool estado { get; set; }
        public DistritoBO distrito { get; set; }
        public TipoDocumentoBO TipoDocumento { get; set; }

    }
}