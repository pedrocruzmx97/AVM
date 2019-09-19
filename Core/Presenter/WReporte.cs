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
    public class WReporte
    {
        ManagerBD Manager;
        IReporte ViewReporte;
        CReporte objReporte;
        public WReporte(IReporte InterfazReporte)
        {
            objReporte = new CReporte();
            Manager = new ManagerBD();
            ViewReporte = InterfazReporte;
        }

        //Para verificar la conexión a la existe conexión a la BD
        public bool ExisteConexion()
        {
            bool ConexcionAbierta = false;
            SqlConnection sqlCon = Manager.GetConnection();
            if (sqlCon.State == ConnectionState.Open)
            {
                ConexcionAbierta = true;
            }
            return ConexcionAbierta;
        }

        #region Métodos de los reportes
        public void obtenerDatosReporte(int opcion)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objReporte.ListarDatos(opcion, ref dtsDatos);
                if (ExistenDatos == true)
                    ViewReporte.datosReportes = dtsDatos;
                else
                    ViewReporte.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewReporte.Mensaje("No hay conexion en red", 2);
            }
        }
        public void obtenerDatosReporteFecha(int opcion, string incio, string fin, int fk)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();

            if (ExisteConexion())
            {
                ExistenDatos = objReporte.ListarDatosFecha(opcion, ref dtsDatos, incio, fin, fk);
                if (ExistenDatos == true)
                    ViewReporte.datosReportes = dtsDatos;
                else
                    ViewReporte.Mensaje("No hay reguistros", 2);
            }
            else
            {
                ViewReporte.Mensaje("No hay conexion en red", 2);
            }
        }


        public void ListarEspecilistas(int intOpcion, string idEspecialista)
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objReporte.listarEspecialista(intOpcion, ref datDatos, idEspecialista);

                if (bolExistenDatos == true)
                {
                    List<CReporte> lisDatos = new List<CReporte>();
                    foreach (DataRow fila in datDatos.Tables[0].Rows)
                    {
                        CReporte item = new CReporte()
                        {
                            Id = fila[0].ToString(),
                            Descripcion = fila[1].ToString()
                        };
                        lisDatos.Add(item);
                    }
                    ViewReporte.LlenarComboEspecialista = lisDatos;
                }
                // else
                // vieGraficas.Mensaje("No hay registros!!!", 3);
            }
            // else
            // vieGraficas.Mensaje("No hay conexión de Red con el Servidor.", 4);
        }
        #endregion
    }
}
