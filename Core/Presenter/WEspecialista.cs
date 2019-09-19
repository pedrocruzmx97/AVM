using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Model;
using Core.View;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Core.Presenter
{
    public class WEspecialista
    {
        ManagerBD Manager;
        IEspecialista ViewEspecialista;
        CEspecialista objEspecialista;

        public WEspecialista(IEspecialista InterfazEspecialista)
        {
            objEspecialista = new CEspecialista();
            Manager = new ManagerBD();
            ViewEspecialista = InterfazEspecialista;
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

        public void ObtenerDatosDeEspecialista(int opcion, CEspecialista EspecialistaIngregsado)
        {
            DataSet datLoggerUserInformation = new DataSet();
            CEspecialista objAuthenticatedUser = new CEspecialista();
            bool ExisteUsuario = false;
            if (ExisteConexion())
            {
                ExisteUsuario = objAuthenticatedUser.ValidarUsuario(opcion, ref datLoggerUserInformation, EspecialistaIngregsado);
                if (ExisteUsuario)
                {
                    try
                    {
                        objAuthenticatedUser.pk_Especialista = datLoggerUserInformation.Tables[0].Rows[0][0].ToString();
                        objAuthenticatedUser.Activo = datLoggerUserInformation.Tables[0].Rows[0][1].ToString();
                        objAuthenticatedUser.Cedula = datLoggerUserInformation.Tables[0].Rows[0][2].ToString();
                        objAuthenticatedUser.Numero_Control = datLoggerUserInformation.Tables[0].Rows[0][3].ToString();
                        objAuthenticatedUser.Nombre = datLoggerUserInformation.Tables[0].Rows[0][5].ToString();
                        objAuthenticatedUser.Apellido = datLoggerUserInformation.Tables[0].Rows[0][6].ToString();
                        objAuthenticatedUser.Correo = datLoggerUserInformation.Tables[0].Rows[0][10].ToString();
                        objAuthenticatedUser.fk_Especialidad = datLoggerUserInformation.Tables[0].Rows[0][12].ToString();
                        objAuthenticatedUser.Rol = Convert.ToInt32(datLoggerUserInformation.Tables[0].Rows[0][13].ToString());
                        objAuthenticatedUser.Especialidad_texto = datLoggerUserInformation.Tables[0].Rows[0][15].ToString();

                        ViewEspecialista.UsuarioLogeadoEspecialista = objAuthenticatedUser;
                    }
                    catch (Exception)
                    {
                        ViewEspecialista.UsuarioLogeadoEspecialista = null;


                    }
                }
                else
                {
                    ViewEspecialista.Mensaje("No valido", 2);
                }
            }
            else
            {
                ViewEspecialista.Mensaje("No hay conexion en red", 2);
            }
        }

        public void ListarEmpleados(int opcion, CEspecialista DatosEspecialista)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objEspecialista.listarEmpleados(opcion, ref dtsDatos,  DatosEspecialista);
                if (ExistenDatos == true)
                {
                    ViewEspecialista.Empleados = dtsDatos;
                    
                }
                else
                {
                    ViewEspecialista.Mensaje("No hay reguistros", 2);
                }

            }
            else
            {
                ViewEspecialista.Mensaje("No hay conexion en red", 2);
            }

        }
        public void ConfiguracionEmpleados(CEspecialista objEspecialista, int OpcionProcedimiento)//Objeto con datos de especialista , opcion que indica que metodo de cuestionario se seleccionara 
        {
            DataSet dtsDatos = new DataSet();
           
            bool BolRegistro = false;
            if (ExisteConexion())
            {

              
                switch (OpcionProcedimiento)
                {
                    case 2: BolRegistro =  objEspecialista.listarEmpleados(OpcionProcedimiento, ref dtsDatos, objEspecialista); break;//listado
                    case 3: BolRegistro = objEspecialista.ConfigurarEmpleado(OpcionProcedimiento, objEspecialista); break;//registro
                    case 4: BolRegistro = objEspecialista.ConfigurarEmpleado(OpcionProcedimiento, objEspecialista); break;//Modificacion
                    case 5: BolRegistro = objEspecialista.ConfigurarEmpleado(OpcionProcedimiento, objEspecialista); break;//Baja
                    case 6: BolRegistro = objEspecialista.listarEmpleados(OpcionProcedimiento, ref dtsDatos, objEspecialista); break;//Consulta especifica de empleado


                    default: BolRegistro = false; break;
                }
                if (BolRegistro == true)
                {
                    ViewEspecialista.Mensaje(" registrado", 1);
                    if (OpcionProcedimiento == 4)
                        ViewEspecialista.Empleados = dtsDatos;
                    if (OpcionProcedimiento == 6) {
                        CEspecialista objAuxEspecialista = new CEspecialista();
                        if (dtsDatos!=null)
                        {
                            objAuxEspecialista.Activo= dtsDatos.Tables[0].Rows[0][0].ToString();
                            objAuxEspecialista.Cedula = dtsDatos.Tables[0].Rows[0][1].ToString();
                            objAuxEspecialista.Numero_Control = dtsDatos.Tables[0].Rows[0][2].ToString();
                            objAuxEspecialista.Contrasena = dtsDatos.Tables[0].Rows[0][3].ToString();
                            objAuxEspecialista.Nombre = dtsDatos.Tables[0].Rows[0][4].ToString();
                            objAuxEspecialista.Apellido = dtsDatos.Tables[0].Rows[0][5].ToString();
                            objAuxEspecialista.FechaNacimiento = dtsDatos.Tables[0].Rows[0][6].ToString();
                            objAuxEspecialista.Genero = dtsDatos.Tables[0].Rows[0][7].ToString();
                            objAuxEspecialista.Direccion = dtsDatos.Tables[0].Rows[0][8].ToString();
                            objAuxEspecialista.Correo = dtsDatos.Tables[0].Rows[0][9].ToString();
                            objAuxEspecialista.Telefono = dtsDatos.Tables[0].Rows[0][10].ToString();
                            objAuxEspecialista.fk_Especialidad = dtsDatos.Tables[0].Rows[0][11].ToString();
                            objAuxEspecialista.Rol = Convert.ToInt32(dtsDatos.Tables[0].Rows[0][12].ToString());
                        }
                        ViewEspecialista.UsuarioLogeadoEspecialista = objAuxEspecialista;
                    }
                        
                }
                else
                {
                    ViewEspecialista.Mensaje(" no reguistrado", 1);
                }
            }
        }

    }
}
