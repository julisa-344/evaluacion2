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
        ClienteDAL dal = new ClienteDAL();

        public List<ClienteBO> MostrarCliente()
        {
            return dal.MostrarCliente();
        }

        public List<ClienteBO> MostrarClienteTodo()
        {
            return dal.MostrarClienteTodo();
        }

        public bool RegistrarCliente(ClienteBO p)
        {
            return dal.RegistrarCliente(p);
        }
        public bool ActualizarCliente(ClienteBO p)
        {
            return dal.ActualizarCliente(p);
        }
        public bool EliminarCliente(ClienteBO p)
        {
            return dal.EliminarCliente(p);
        }

        public bool HabilitarCliente(ClienteBO p)
        {
            return dal.HabilitarCliente(p);
        }

        public int MostrarCodigoCliente()
        {
            return dal.MostrarCodigoCliente();
        }

    }
}
