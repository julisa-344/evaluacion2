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
    public class EmpleadoBAL
    {
        private EmpleadoDAL dal = new EmpleadoDAL();
        private DistritoBAL distritoBAL = new DistritoBAL(); // Instancia de DistritoBAL
        private TipoDocumentoBAL tipoDocumentoBAL = new TipoDocumentoBAL(); // Instancia de TipoDocumentoBAL
        private RolBAL rolBAL = new RolBAL(); // Instancia de RolBAL

        public List<EmpleadoBO> MostrarEmpleado()
        {
            return dal.MostrarEmpleado();
        }

        public List<EmpleadoBO> MostrarEmpleadoTodo()
        {
            return dal.MostrarEmpleadoTodo();
        }

        public List<DistritoBO> MostrarDistritos()
        {
            return distritoBAL.MostrarDistritoTodo(); // Asegúrate de que este método esté implementado
        }

        public List<TipoDocumentoBO> MostrarTiposDocumento()
        {
            return tipoDocumentoBAL.MostrarTipoDocumentoTodo(); // Asegúrate de que este método esté implementado
        }

        public List<RolBO> MostrarRoles()
        {
            return rolBAL.MostrarRolTodo(); // Asegúrate de que este método esté implementado
        }

        public bool RegistrarEmpleado(EmpleadoBO p)
        {
            return dal.RegistrarEmpleado(p);
        }

        public bool ActualizarEmpleado(EmpleadoBO p)
        {
            return dal.ActualizarEmpleado(p);
        }

        public bool EliminarEmpleado(EmpleadoBO p)
        {
            return dal.EliminarEmpleado(p);
        }

        public bool HabilitarEmpleado(EmpleadoBO p)
        {
            return dal.HabilitarEmpleado(p);
        }

        public int MostrarCodigoEmpleado()
        {
            return dal.MostrarCodigoEmpleado();
        }
    }
}