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
        EmpleadoDAL dal = new EmpleadoDAL();

        public List<EmpleadoBO> MostrarEmpleado()
        {
            return dal.MostrarEmpleado();
        }

        public List<EmpleadoBO> MostrarEmpleadoTodo()
        {
            return dal.MostrarEmpleadoTodo();
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
