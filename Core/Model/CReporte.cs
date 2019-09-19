using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace Core.Model
{
    public class CReporte
    {
        ManagerBD objManagerBD;
        //Datos para hacer la consulta
        public int anioConsulta { get; set; }

        //variables para uso de combos
        public string Id { get; set; }
        public string Descripcion { get; set; }
        //Constructor
        public CReporte()
        {
            objManagerBD = new ManagerBD();
        }

        #region Metodos de los reportes
        public bool ListarDatos(int opcion, ref DataSet objDatos)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            objDatos = objManagerBD.GetData("spReporte", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;

        }
        public bool ListarDatosFecha(int opcion, ref DataSet objDatos, string inicio, string fin, int pk)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@inicio", SqlDbType.VarChar, 50) { Value = inicio });
            lstParametros.Add(new SqlParameter("@fin", SqlDbType.VarChar, 50) { Value = fin });
            lstParametros.Add(new SqlParameter("@pk", SqlDbType.Int) { Value = pk });
            objDatos = objManagerBD.GetData("spReporte", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;

        }
        public bool listarEspecialista(int opcion, ref DataSet objDatos, string IdPespecialista)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Especialidad", SqlDbType.Int) { Value = IdPespecialista });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());

            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;

            return ExisteDatos;
        }
            #endregion


        }
    }
