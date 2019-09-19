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
     public class WCombo
    {
        ManagerBD Manager;
        ICombo ViewCombo;
        CCombo objCombo;

        //constractor
        public WCombo(ICombo InterfazCombo)
        {
            objCombo = new CCombo();
            Manager = new ManagerBD();
            ViewCombo = InterfazCombo;
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

        public void ListarDatos(int intOpcion, string ClaveCCT = null)
        {
            bool bolExistenDatos = false;
            DataSet datDatos = new DataSet();

            if (ExisteConexion())
            {
                bolExistenDatos = objCombo.ObtenerCatalogo(intOpcion, ref datDatos, ClaveCCT);

                if (bolExistenDatos == true)
                {
                    List<CCombo> lisDatos = new List<CCombo>();
                    foreach (DataRow fila in datDatos.Tables[0].Rows)
                    {
                        CCombo item = new CCombo()
                        {
                            Id = fila[0].ToString(),
                            Descripcion = fila[1].ToString()
                        };
                        lisDatos.Add(item);
                    }
                    ViewCombo.LlenarCombo = lisDatos;
                }
               // else
                   // vieGraficas.Mensaje("No hay registros!!!", 3);
            }
           // else
               // vieGraficas.Mensaje("No hay conexión de Red con el Servidor.", 4);
        }

      


    }
}
