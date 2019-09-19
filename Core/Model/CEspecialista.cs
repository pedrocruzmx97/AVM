using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using Core.Model;
namespace Core.Model
{
    public class CEspecialista
    {
        ManagerBD objManagerBD;
        public CEspecialista() {
            objManagerBD = new ManagerBD();
        }

        public bool ValidarUsuario(int opcion, ref DataSet objDatos, CEspecialista obEspecialista)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@Numero_Control", SqlDbType.Int) { Value = obEspecialista.Numero_Control });
            lstParametros.Add(new SqlParameter("@Contrasena", SqlDbType.NVarChar, 50) { Value = obEspecialista.Contrasena });

            objDatos = objManagerBD.GetData("PEspecialista", lstParametros.ToArray());

            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        public bool listarEmpleados(int opcion, ref DataSet objDatos, CEspecialista obj)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@Rol", SqlDbType.NVarChar, 50) { Value = obj.Rol });
            lstParametros.Add(new SqlParameter("@Numero_Control", SqlDbType.VarChar) { Value = obj.Numero_Control });
            objDatos = objManagerBD.GetData("PEspecialista", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        public bool ConfigurarEmpleado(int opcion, CEspecialista objEspecialista)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });


            lstParametros.Add(new SqlParameter("@pk_Especialista", SqlDbType.VarChar) { Value = objEspecialista.pk_Especialista });
            lstParametros.Add(new SqlParameter("@Activo", SqlDbType.VarChar) { Value = objEspecialista.Activo });
            lstParametros.Add(new SqlParameter("@Cedula", SqlDbType.VarChar) { Value = objEspecialista.Cedula });
            lstParametros.Add(new SqlParameter("@Numero_Control", SqlDbType.VarChar) { Value = objEspecialista.Numero_Control });
            lstParametros.Add(new SqlParameter("@Contrasena", SqlDbType.VarChar) { Value = objEspecialista.Contrasena });
            lstParametros.Add(new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = objEspecialista.Nombre });
            lstParametros.Add(new SqlParameter("@Apellido", SqlDbType.VarChar) { Value = objEspecialista.Apellido });
            lstParametros.Add(new SqlParameter("@FechaNacimiento", SqlDbType.VarChar) { Value = objEspecialista.FechaNacimiento });
            lstParametros.Add(new SqlParameter("@Genero", SqlDbType.Int) { Value = objEspecialista.Genero });
            lstParametros.Add(new SqlParameter("@Direccion", SqlDbType.VarChar) { Value = objEspecialista.Direccion });
            lstParametros.Add(new SqlParameter("@Correo", SqlDbType.VarChar) { Value = objEspecialista.Correo });
            lstParametros.Add(new SqlParameter("@Telefono", SqlDbType.VarChar) { Value = objEspecialista.Telefono });
            lstParametros.Add(new SqlParameter("@fk_Especialidad", SqlDbType.VarChar) { Value = objEspecialista.fk_Especialidad });
            lstParametros.Add(new SqlParameter("@Rol", SqlDbType.VarChar) { Value = objEspecialista.Rol });

            



            //falta
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PEspecialista", lstParametros.ToArray()))
                return true;
            return false;
        }


        #region variables del especialista
        public string pk_Especialista { get; set; }
        public string Activo { get; set; }
        public string Cedula { get; set; }
        public string Numero_Control { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public string fk_Especialidad { get; set; }
        public string Especialidad_texto { get; set; }
        public string Telefono { get; set; }
        public int Rol { get; set; }
        public string Correo { get; set; }

        #endregion

    }
}
