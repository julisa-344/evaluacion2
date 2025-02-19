﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.evaluacion2.bo;
using pe.com.evaluacion2.dal;


namespace pe.com.evaluacion2.bal
{
    public class DistritoBAL
    {
        DistritoDAL dal = new DistritoDAL();

        public List<DistritoBO> MostrarDistrito()
        {
            return dal.MostrarDistrito();
        }

        public List<DistritoBO> MostrarDistritoTodo()
        {
            return dal.MostrarDistritoTodo();
        }

        public bool RegistrarDistrito(DistritoBO c)
        {
            return dal.RegistrarDistrito(c);
        }

        public bool ActualizarDistrito(DistritoBO c)
        {
            return dal.ActualizarDistrito(c);
        }

        public bool EliminarDistrito(DistritoBO c)
        {
            return dal.EliminarDistrito(c);
        }

        public bool HabilitarDistrito(DistritoBO c)
        {
            return dal.HabilitarDistrito(c);
        }

        public int MostrarCodigoDistrito()
        {
            return dal.MostrarCodigoDistrito();
        }
    }
}
