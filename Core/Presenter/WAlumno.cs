using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;


namespace Core.Presenter
{
    public class WAlumno
    {
        ManagerBD Manager;
        IAlumno ViewAlumno;
        CAlumno objAlumno;

        //constractor
        public WAlumno(IAlumno InterfazAlumno)
        {
            objAlumno = new CAlumno();
            Manager = new ManagerBD();
            ViewAlumno = InterfazAlumno;
        }

        public bool ExisteConexion()
        {
            bool ConexcionAvierta = false;
            SqlConnection sqlCon = Manager.GetConnection();
            if (sqlCon.State == ConnectionState.Open)
            {
                ConexcionAvierta = true;
            }
            return ConexcionAvierta;
        }
        #region  Metodos para el acceso
        public void ObtenerDatosDeAlumno(int opcion, CAlumno AlumnoIngresado)
        {
            DataSet datLoggerUserInformation = new DataSet();
            CAlumno objAuthenticatedUser = new CAlumno();
            bool ExisteUsuario = false;

            if (ExisteConexion())
            {
                ExisteUsuario = objAuthenticatedUser.ValidarAlumno(opcion, ref datLoggerUserInformation, AlumnoIngresado);
                if (ExisteUsuario)
                {
                    try
                    {
                        objAuthenticatedUser.alu_ID = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][0].ToString());
                        objAuthenticatedUser.alu_E1 = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][1].ToString());
                        objAuthenticatedUser.alu_E2 = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][2].ToString());
                        objAuthenticatedUser.alu_E3 = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][3].ToString());
                        objAuthenticatedUser.alu_Rol = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][4].ToString());
                        objAuthenticatedUser.alu_NumControl = datLoggerUserInformation.Tables[0].Rows[0][5].ToString();
                        objAuthenticatedUser.alu_Nombre = datLoggerUserInformation.Tables[0].Rows[0][6].ToString();
                        objAuthenticatedUser.alu_ApePaterno = datLoggerUserInformation.Tables[0].Rows[0][7].ToString();
                        objAuthenticatedUser.alu_ApeMaterno = datLoggerUserInformation.Tables[0].Rows[0][8].ToString();
                        objAuthenticatedUser.alu_Sexo = datLoggerUserInformation.Tables[0].Rows[0][9].ToString();
                        objAuthenticatedUser.alu_FechaNacimiento = datLoggerUserInformation.Tables[0].Rows[0][10].ToString();
                        objAuthenticatedUser.alu_Carrera= datLoggerUserInformation.Tables[0].Rows[0][11].ToString();

                        ViewAlumno.UsuarioLogeado = objAuthenticatedUser;
                    }
                    catch (Exception)
                    {
                        ViewAlumno.UsuarioLogeado = null;

                    }

                }
                else
                {
                    ViewAlumno.Mensaje("No Valido", 2);
                }
               
            }
            else
            {
                ViewAlumno.Mensaje("No hay conexion en red", 1);
            }
        }
        public void ActualizarDatosDeAlumno(CAlumno AlumnoIngresado)
        {
            DataSet datLoggerUserInformation = new DataSet();
            CAlumno objAuthenticatedUser = new CAlumno();
            bool ExisteUsuario = false;
            if (ExisteConexion())
            {
                ExisteUsuario = objAuthenticatedUser.ActualizarDatos( ref datLoggerUserInformation, AlumnoIngresado);
                if (ExisteUsuario)
                {
                    objAuthenticatedUser.alu_ID = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][0].ToString());
                    objAuthenticatedUser.alu_E1 = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][1].ToString());
                    objAuthenticatedUser.alu_E2 = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][2].ToString());
                    objAuthenticatedUser.alu_E3 = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][3].ToString());
                    objAuthenticatedUser.alu_Rol = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][4].ToString());
                    objAuthenticatedUser.alu_NumControl = datLoggerUserInformation.Tables[0].Rows[0][5].ToString();
                    objAuthenticatedUser.alu_Nombre = datLoggerUserInformation.Tables[0].Rows[0][6].ToString();
                    objAuthenticatedUser.alu_ApePaterno = datLoggerUserInformation.Tables[0].Rows[0][7].ToString();
                    objAuthenticatedUser.alu_ApeMaterno = datLoggerUserInformation.Tables[0].Rows[0][8].ToString();
                    objAuthenticatedUser.alu_Sexo = datLoggerUserInformation.Tables[0].Rows[0][9].ToString();
                    objAuthenticatedUser.alu_FechaNacimiento = datLoggerUserInformation.Tables[0].Rows[0][10].ToString();
                    objAuthenticatedUser.alu_Carrera = datLoggerUserInformation.Tables[0].Rows[0][11].ToString();
                    ViewAlumno.UsuarioActulizar = objAuthenticatedUser;
                }
                else
                {
                    ViewAlumno.Mensaje("No Valido", 2);
                }
            }
            else
            {
                ViewAlumno.Mensaje("No hay conexion en red", 1);
            }
        }

        #endregion



    }
}






