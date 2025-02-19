using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.evaluacion2.bo;
using pe.com.evaluacion2.dal;

namespace pe.com.evaluacion2.bal
{
    public class RolBAL
    {
        //creamos un objeto de RolDAL
        RolDAL dal = new RolDAL();

        public List<RolBO> MostrarRol()
        {
            return dal.MostrarRol();
        }

        public List<RolBO> MostrarRolTodo()
        {
            return dal.MostrarRolTodo();
        }

        public bool RegistrarRol(RolBO c)
        {
            return dal.RegistrarRol(c);
        }
        public bool ActualizarRol(RolBO c)
        {
            return dal.ActualizarRol(c);
        }
        public bool EliminarRol(RolBO c)
        {
            return dal.EliminarRol(c);
        }

        public bool HabilitarRol(RolBO c)
        {
            return dal.HabilitarRol(c);
        }

        public int MostrarCodigoRol()
        {
            return dal.MostrarCodigoRol();
        }

    }
}