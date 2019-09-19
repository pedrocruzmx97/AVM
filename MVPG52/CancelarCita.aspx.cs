using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core.Model;
using Core.Presenter;
using Core.View;

namespace MVPG52
{
    public partial class CancelarCita : System.Web.UI.Page,IConsulta
    {

        CAlumno objLoggerinf;
        CConsulta objConsultainf;//Objeto donde estara la informacion de logeo temporal

        WConsulta WConsultaVista;//meotodo para poder ocupar los metodos de la wAlumno
    
        GridViewRow FilaSeleccionada;

        protected void Page_Load(object sender, EventArgs e)
        {
            objLoggerinf = new CAlumno();
            objLoggerinf = (CAlumno)Session["UsuarioLogeado"];

            WConsultaVista = new WConsulta(this);

            if (objLoggerinf != null)
            {
                objConsultainf = new CConsulta();
          
                if (!IsPostBack)
                {
                  
                    WConsultaVista.Listar(5, DatosPasienteConsulta);
                }
            }
            else
            {
                Response.Redirect("/Sesion.aspx", true);// no direcciona a la pagina default de la master
            }


        }
        #region IConsulta
        public CConsulta DatosPasienteConsulta
        {
            get
            {
                CConsulta Datos = new CConsulta();
                Datos.fk_Alumno = objLoggerinf.alu_NumControl;
                return Datos;
            }
        }
        public DataSet ListadoConsulta
        {
            set
            {
                if (value != null)
                {
                    GridViewCitasPasiente.DataSource = value;
                    GridViewCitasPasiente.DataBind();
                }
            }
        }
        public DataSet ListadoDeEspecialistas
        {
            set
            {
                throw new NotImplementedException();
            }
        }
        public DataSet ListadoDeFechas
        {
            set
            {
                throw new NotImplementedException();
            }
        }
        public DataSet ListadoDeHoras
        {
            set
            {
                throw new NotImplementedException();
            }
        }
        public CConsulta NewConsulta
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int EliminarConsulta
        {
            get
            {
                int x = Convert.ToInt32("") ;
                return x;
            }
        }

        public List<CConsulta> LlenarComboEspecialidad
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<CConsulta> LlenarComboEspecialista
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<CConsulta> LlenarComboHora
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DataSet HistorialCitas
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<CConsulta> LlenarEnfermedad
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DataSet Odontograma
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Mensaje(string Mensaje, int tipo)
        {
            
        }

        #endregion
        #region ICombo
        #endregion

        protected void GridViewCitasPasiente_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            FilaSeleccionada = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Eliminar")
            {
                int x = Convert.ToInt32((((Label)FilaSeleccionada.FindControl("Label2")).Text));
                WConsultaVista.EliminarConsulta(6, x);
                Response.Redirect("/CancelarCita.aspx", true);// no direcciona a la pagina default de la master
            }
        }

       
    }
}