using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Core.Model
{
    public class CChat
    {
        ManagerBD objManagerBD;
        public string Alumno { get; set; }
        public string Especialista { get; set; }
        public string mensaje { get; set; }
        public string Remitente { get; set; }

        public CChat()
        {
            objManagerBD = new ManagerBD();
        }
        public bool listarConversacion(int opcion, ref DataSet objDatos, CChat obj)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lsParametros = new List<SqlParameter>();
            lsParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lsParametros.Add(new SqlParameter("@Alumno", SqlDbType.VarChar, 255) { Value = obj.Alumno });
            lsParametros.Add(new SqlParameter("@Especialista", SqlDbType.VarChar, 255) { Value = obj.Especialista });
            objDatos = objManagerBD.GetData("PChat", lsParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;
            return ExisteDatos;
        }
        public bool EnviarMensaje(int opcion, CChat objChat)
        {

            List<SqlParameter> lstParametros = new List<SqlParameter>();

            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@Alumno", SqlDbType.VarChar, 255) { Value = objChat.Alumno });
            lstParametros.Add(new SqlParameter("@Especialista", SqlDbType.VarChar, 255) { Value = objChat.Especialista });
            lstParametros.Add(new SqlParameter("@Remitente", SqlDbType.VarChar, 255) { Value = objChat.Remitente });
            lstParametros.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar, 255) { Value = objChat.mensaje });

            objManagerBD = new ManagerBD();

            if (objManagerBD.UpdateData("PChat", lstParametros.ToArray()))
                return true;

            return false;
        }
    }

}

