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
    public class WCuestionario
    {
        ManagerBD Manager;
        ICuestionario ViewCuestionario;
        CCuestionario objCuestionario;
        public WCuestionario(ICuestionario InterfazCuestionario)
        {
            objCuestionario = new CCuestionario();
            Manager = new ManagerBD();
            ViewCuestionario = InterfazCuestionario;
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
        public void ReguistrarCuestionario(CCuestionario objCuestionario,int OpcionCuestionario)//Objeto con datos de cuestionario , opcion que indica que metodo de cuestionario se seleccionara 
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                switch (OpcionCuestionario)
                {
                    case 1: BolRegistro = objCuestionario.ReguistroDental(objCuestionario);  break;
                    case 2: BolRegistro = objCuestionario.ReguistroMedico(objCuestionario); break;
                    case 3: BolRegistro = objCuestionario.ReguistroPsicologico(objCuestionario); break;
                    case 4: BolRegistro = objCuestionario.AceptarTerminos(objCuestionario); break;
                    case 5: BolRegistro = objCuestionario.AceptarArchivo(objCuestionario); break;
                    default: BolRegistro = false; break;
                }
                if (BolRegistro == true) {
                    ViewCuestionario.Mensaje(" registrado", 1);
                }
                else {
                    ViewCuestionario.Mensaje(" no reguistrado", 1);
                } 
            }
        }
        public void ListarCuestionarioUsuario(int opcion, string id)
        {
            //opciones=tipo de cuestionario
            //id del alumno
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            CCuestionario miCuestionario = new CCuestionario();
            if (ExisteConexion())
            {
                ExistenDatos =objCuestionario.listarAlumnoCuestionario(ref dtsDatos,id,opcion); 
                
                if (ExistenDatos == true)
                {
                    switch (opcion)
                    {
                        case 4: ViewCuestionario.ListadoCuestionarioDental = dtsDatos;  break;
                        case 5: ViewCuestionario.ListadoCuestionarioMedico = dtsDatos; break;
                        case 6: ViewCuestionario.ListadoCuestionarioPsicologico = dtsDatos; break;
                        default: ViewCuestionario.Mensaje("No hay reguistros", 2);  break;
                    }
                }
                else
                    ViewCuestionario.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewCuestionario.Mensaje("No hay conexion en red", 2);
            }

        }// Este metodo permite obtener el resultado por seccion seleccionada
        public void ListarSangre(int intOpcion)
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objCuestionario.ListarSangre(intOpcion, ref datDatos);

                if (bolExistenDatos == true)
                {
                    List<CCuestionario> lisDatos = new List<CCuestionario>();
                    foreach (DataRow fila in datDatos.Tables[0].Rows)
                    {
                        CCuestionario item = new CCuestionario()
                        {
                            Id = fila[0].ToString(),
                            Descripcion = fila[1].ToString()
                        };
                        lisDatos.Add(item);
                    }
                    ViewCuestionario.LlenarComboSangre = lisDatos;
                }
                // else
                // vieGraficas.Mensaje("No hay registros!!!", 3);
            }
            // else
            // vieGraficas.Mensaje("No hay conexión de Red con el Servidor.", 4);
        }
        //metodos especialista
        public void ListarUsuarioHistorialClinico(int opcion, string id)//Este metodo nos returna todo el historial clinico
        {

            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            CCuestionario miCuestionario = new CCuestionario();
            if (ExisteConexion())
            {
                ExistenDatos = objCuestionario.listarAlumnoCuestionario( ref dtsDatos,id,opcion);
                if (ExistenDatos == true)
                {
                    ViewCuestionario.ListadoCuestionario = dtsDatos;
                }

                else
                    ViewCuestionario.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewCuestionario.Mensaje("No hay conexion en red", 2);
            }

        }
        public void GetFolio(string id,int opcion) {
            

            //Se utilizaran la interfaz de medico para almacenar temporalmente el folio
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            CCuestionario miCuestionario = new CCuestionario();
            if (ExisteConexion())
            {
                ExistenDatos = objCuestionario.folio(ref dtsDatos, id, opcion);
                if (ExistenDatos == true)
                {
                    ViewCuestionario.ListadoCuestionarioMedico = dtsDatos;
                }

                else
                    ViewCuestionario.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewCuestionario.Mensaje("No hay conexion en red", 2);
            }
        }
        public string PDFExamen() {
            
            string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"700px\" height=\"500px\">";
            embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            embed += "</object>";
           
            return embed;

        }

    }
}
