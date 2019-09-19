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
    public class WConsulta
    {
        ManagerBD Manager;
        IConsulta ViewConsulta;
        CConsulta objConsulta;
        public WConsulta(IConsulta InterfazConsulta)
        {
            objConsulta = new CConsulta();
            Manager = new ManagerBD();
            ViewConsulta = InterfazConsulta;
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

        #region Metodos Para Alumno
        //Reguistramos una cita
        public void Reguistrar(CConsulta objConsulta,CAlumno objAlumno)
        {
            bool BolRegistro = false;
      
            if (ExisteConexion())
                BolRegistro = objConsulta.reguistro(4, objConsulta);
            {
                if (BolRegistro == true)
                {
                    ViewConsulta.Mensaje("Cita registrado", 1);
                    //Se reguistro la cita, enviar mensaje al médico
                    objConsulta.EmailNotificacion(objConsulta, objAlumno);//Enviar correo al especialista

                }
                else
                {
                    objConsulta.EmailNotificacion(objConsulta, objAlumno);//Enviar correo al especialista
                    ViewConsulta.Mensaje("Cita no reguistrado", 1);
                }
            }
        }
        //Reguistramos una cita rapida --el estado indica que sera una cita rapida
        public void Reguistrar(CConsulta objConsulta,int Estado)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objConsulta.reguistro(4, objConsulta,Estado);
                if (BolRegistro == true)
                    ViewConsulta.Mensaje("Cita registrado", 1);
                else
                    ViewConsulta.Mensaje("Cita no reguistrado", 1);
            }
        }
        //Cancelacion de una cita
        public void EliminarConsulta(int op,int IdConsulta)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objConsulta.EliminarConsulta(op, IdConsulta);
                if (BolRegistro == true)
                    ViewConsulta.Mensaje("Libro registrado", 1);
                else
                    ViewConsulta.Mensaje("Libro no reguistrado", 1);
            }
        }
        //Listado de las citas por alumno
        public void Listar(int opcion, CConsulta Obj)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
         
            if (ExisteConexion())
            {
                ExistenDatos = objConsulta.listarCitas(opcion, ref dtsDatos, Obj);
                if (ExistenDatos == true)
                    ViewConsulta.ListadoConsulta = dtsDatos;
                else
                    ViewConsulta.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewConsulta.Mensaje("No hay conexion en red", 2);
            }

        }
        //Listado de odontograma
        public void ListarOdontograma(int opcion, string fk_Alumno)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objConsulta.listarOdontograma(opcion, ref dtsDatos, fk_Alumno);
                if (ExistenDatos == true)
                    ViewConsulta.Odontograma = dtsDatos;
                else
                    ViewConsulta.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewConsulta.Mensaje("No hay conexion en red", 2);
            }

        }

        //Para los combos 
        public void ListarEspecilidad(int intOpcion)
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objConsulta.ListarEspecialidades(intOpcion, ref datDatos);

                if (bolExistenDatos == true)
                {
                    List<CConsulta> lisDatos = new List<CConsulta>();
                    foreach (DataRow fila in datDatos.Tables[0].Rows)
                    {
                        CConsulta item = new CConsulta()
                        {
                            Id = fila[0].ToString(),
                            Descripcion = fila[1].ToString()
                        };
                        lisDatos.Add(item);
                    }
                    ViewConsulta.LlenarComboEspecialidad = lisDatos;
                }
                // else
                // vieGraficas.Mensaje("No hay registros!!!", 3);
            }
            // else
            // vieGraficas.Mensaje("No hay conexión de Red con el Servidor.", 4);
        }
        public void ListarEspecilistas(int intOpcion, string idEspecialista)
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objConsulta.listarEspecialista(intOpcion, ref datDatos, idEspecialista);

                if (bolExistenDatos == true)
                {
                    List<CConsulta> lisDatos = new List<CConsulta>();
                    foreach (DataRow fila in datDatos.Tables[0].Rows)
                    {
                        CConsulta item = new CConsulta()
                        {
                            Id = fila[0].ToString(),
                            Descripcion = fila[1].ToString()
                        };
                        lisDatos.Add(item);
                    }
                    ViewConsulta.LlenarComboEspecialista = lisDatos;
                }
                // else
                // vieGraficas.Mensaje("No hay registros!!!", 3);
            }
            // else
            // vieGraficas.Mensaje("No hay conexión de Red con el Servidor.", 4);
        }
        public void ListarHora(int intOpcion, string Fecha,string fk_Especialista)
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objConsulta.listarHorario(intOpcion, ref datDatos, Fecha, fk_Especialista);

                if (bolExistenDatos == true)
                {
                    List<CConsulta> lisDatos = new List<CConsulta>();
                    foreach (DataRow fila in datDatos.Tables[0].Rows)
                    {
                        CConsulta item = new CConsulta()
                        {
                            Id = fila[0].ToString(),
                            Descripcion = fila[1].ToString()
                        };
                        lisDatos.Add(item);
                    }
                    ViewConsulta.LlenarComboHora = lisDatos;
                }
                // else
                // vieGraficas.Mensaje("No hay registros!!!", 3);
            }
            // else
            // vieGraficas.Mensaje("No hay conexión de Red con el Servidor.", 4);
        }

        //lista de correo
        public void ObtenerCorreoEspecialista(int intOpcion,string id)//procedimiento  idEspecialista
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objConsulta.listarCorreo(intOpcion, ref datDatos,id);

                if (bolExistenDatos == true)
                {
                    ViewConsulta.ListadoConsulta = datDatos;
                }
               
            }
           
        }

        #endregion

        #region Metodos para el especialista
        //RegistrarConsulta
        public void ReguistrarConsulta(CConsulta objConsulta)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objConsulta.reguistroConsulta(10, objConsulta);
                if (BolRegistro == true)
                    ViewConsulta.Mensaje("Cita registrado", 1);
                else
                    ViewConsulta.Mensaje("Cita no reguistrado", 1);
            }
        }
        //Lisar historial clinico por alumno
        public void ListarHistorialMedico(int opcion, CConsulta Obj)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objConsulta.listarHistorialClinicoAlumno(opcion,  ref dtsDatos, Obj);
                if (ExistenDatos == true)
                    ViewConsulta.ListadoConsulta = dtsDatos;
                else
                    ViewConsulta.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewConsulta.Mensaje("No hay conexion en red", 2);
            }

        }
        //listar hisotiral de citas por alumno
        public void ListarHistorialCitas(int opcion, string id,CConsulta DatosAlumno)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objConsulta.listarHistorialCitasAlumno(opcion, ref dtsDatos, id,  DatosAlumno);
                if (ExistenDatos == true)
                {
                    ViewConsulta.HistorialCitas = dtsDatos;
                    ViewConsulta.Odontograma = dtsDatos;
                }
                else {
                    ViewConsulta.Mensaje("No hay reguistros", 2);
                }
                   
            }
            else
            {
                ViewConsulta.Mensaje("No hay conexion en red", 2);
            }

        }
        //Ver la agenda del medico
        public void ListarMedicoAgenda(int opcion, CEspecialista Obj)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objConsulta.listarCitasMedico(opcion, ref dtsDatos, Obj);
                if (ExistenDatos == true)
                    ViewConsulta.ListadoConsulta = dtsDatos;
                else
                    ViewConsulta.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewConsulta.Mensaje("No hay conexion en red", 2);
            }

        }
        //Agrega una nueva enfermedad
        public void InsertarEnfermedad(int op, string enfermedad)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objConsulta.InsertarEnfermedad(op, enfermedad);
                if (BolRegistro == true)
                    ViewConsulta.Mensaje("Libro registrado", 1);
                else
                    ViewConsulta.Mensaje("Libro no reguistrado", 1);
            }
        }
        //lista las enfermedades
        public void ListarEnfermedades(int intOpcion)
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objConsulta.listarEnfermedades(intOpcion, ref datDatos);

                if (bolExistenDatos == true)
                {
                    List<CConsulta> lisDatos = new List<CConsulta>();
                    foreach (DataRow fila in datDatos.Tables[0].Rows)
                    {
                        CConsulta item = new CConsulta()
                        {
                            Id = fila[0].ToString(),
                            Descripcion = fila[1].ToString()
                        };
                        lisDatos.Add(item);
                    }
                    ViewConsulta.LlenarEnfermedad = lisDatos;
                }
                // else
                // vieGraficas.Mensaje("No hay registros!!!", 3);
            }
            // else
            // vieGraficas.Mensaje("No hay conexión de Red con el Servidor.", 4);
        }
        //Obtenemos datos del alumno
        public void Datosalumno(int opcion,string id )
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objConsulta.ListarAlumnoInf(opcion, ref dtsDatos, id);
                if (ExistenDatos == true)
                    ViewConsulta.HistorialCitas = dtsDatos;
                else
                    ViewConsulta.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewConsulta.Mensaje("No hay conexion en red", 2);
            }
        }
        //insertar odontograma
        public void InsertarOdontograma(int op, CConsulta ObjOdontograma)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = objConsulta.InsertarOdontograma(op, ObjOdontograma);
                if (BolRegistro == true)
                    ViewConsulta.Mensaje("Libro registrado", 1);
                else
                    ViewConsulta.Mensaje("Libro no reguistrado", 1);
            }
        }
        #endregion

        #region Cita Rapida
        public void DatosalumnoCitaRapida(int opcion, string id) //Metodo que permite obtener datos basicos del alumno para saber si es el correcto
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objConsulta.ListarAlumnoInf(opcion, ref dtsDatos, id);
                if (ExistenDatos == true) {
                    ViewConsulta.ListadoConsulta = dtsDatos; //en la interfaz #ListadoConsulta # se usuaran los datos
                }

                else {
                    ViewConsulta.Mensaje("No hay reguistros", 2);
                    ViewConsulta.ListadoConsulta = null;

                }
                  
            }
            else
            {
                ViewConsulta.Mensaje("No hay conexion en red", 2);
            }
        }
        #endregion


    }

}
