using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.evaluacion2.bo;
using pe.com.evaluacion2.dal;

namespace pe.com.evaluacion2.bal
{
    public class TipoDocumentoBAL
    {
        //creamos un objeto deTipoDocumentoaDAL
        TipoDocumentoDAL dal = new TipoDocumentoDAL();

        public List<TipoDocumentoBO> MostrarTipoDocumento()
        {
            return dal.MostrarTipoDocumento();
        }

        public List<TipoDocumentoBO> MostrarTipoDocumentoTodo()
        {
            return dal.MostrarTipoDocumentoTodo();
        }

        public bool RegistrarTipoDocumento(TipoDocumentoBO c)
        {
            return dal.RegistrarTipoDocumento(c);
        }
        public bool ActualizarTipoDocumento(TipoDocumentoBO c)
        {
            return dal.ActualizarTipoDocumento(c);
        }
        public bool EliminarTipoDocumento(TipoDocumentoBO c)
        {
            return dal.EliminarTipoDocumento(c);
        }

        public bool HabilitarTipoDocumento(TipoDocumentoBO c)
        {
            return dal.HabilitarTipoDocumento(c);
        }

        public int MostrarCodigoTipoDocumento()
        {
            return dal.MostrarCodigoTipoDocumento();
        }

    }
}
