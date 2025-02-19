using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.evaluacion2.bo;
using pe.com.evaluacion2.dal;

namespace pe.com.evaluacion2.bal
{
    public class MarcaBAL
    {
        //creamos un objeto de MarcaDAL
        MarcaDAL dal = new MarcaDAL();

        public List<MarcaBO> MostrarMarca()
        {
            return dal.MostrarMarca();
        }

        public List<MarcaBO> MostrarMarcaTodo()
        {
            return dal.MostrarMarcaTodo();
        }

        public bool RegistrarMarca(MarcaBO c)
        {
            return dal.RegistrarMarca(c);
        }
        public bool ActualizarMarca(MarcaBO c)
        {
            return dal.ActualizarMarca(c);
        }
        public bool EliminarMarca(MarcaBO c)
        {
            return dal.EliminarMarca(c);
        }

        public bool HabilitarMarca(MarcaBO c)
        {
            return dal.HabilitarMarca(c);
        }

        public int MostrarCodigoMarca()
        {
            return dal.MostrarCodigoMarca();
        }

    }
}