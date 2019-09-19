using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;
namespace Core.Model
{
    public class CCombo
    {

        ManagerBD objManagerBD;

        public CCombo()
        {
            objManagerBD = new ManagerBD();
        }

        public string Id { get; set; }
        public string Descripcion { get; set; }
        public bool ObtenerCatalogo(int opcion,ref DataSet objDatos, string ClaveCCT = null) {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }


    }
}
