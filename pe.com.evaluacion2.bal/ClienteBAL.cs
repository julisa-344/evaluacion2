using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.evaluacion2.bal;
using pe.com.evaluacion2.bo;
using pe.com.evaluacion2.dal;

namespace pe.com.evaluacion2.bal
{
    public class ClienteBAL
    {
        private ClienteDAL clienteDAL = new ClienteDAL();
        private DistritoBAL distritoBAL = new DistritoBAL(); // Instancia de DistritoBAL
        private TipoDocumentoBAL tipoDocumentoBAL = new TipoDocumentoBAL(); // Instancia de TipoDocumentoBAL

        public List<ClienteBO> MostrarClienteTodo()
        {
            return clienteDAL.MostrarClienteTodo();
        }

        public List<DistritoBO> MostrarDistrito()
        {
            return distritoBAL.MostrarDistritoTodo(); // Asegúrate de que este método esté implementado en DistritoDAL
        }

        public List<TipoDocumentoBO> MostrarTipoDocumento()
        {
            return tipoDocumentoBAL.MostrarTipoDocumentoTodo(); // Asegúrate de que este método esté implementado en TipoDocumentoDAL
        }

        public bool RegistrarCliente(ClienteBO cliente)
        {
            return clienteDAL.RegistrarCliente(cliente);
        }

        public bool ActualizarCliente(ClienteBO cliente)
        {
            return clienteDAL.ActualizarCliente(cliente);
        }

        public bool EliminarCliente(ClienteBO cliente)
        {
            return clienteDAL.EliminarCliente(cliente);
        }

        public bool HabilitarCliente(ClienteBO cliente)
        {
            return clienteDAL.HabilitarCliente(cliente);
        }

        public int MostrarCodigoCliente()
        {
            return clienteDAL.MostrarCodigoCliente();
        }
    }
}