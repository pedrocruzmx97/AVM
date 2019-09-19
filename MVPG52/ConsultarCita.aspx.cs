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
    public partial class ConsultarCita : System.Web.UI.Page,IConsulta
    {
     
        CAlumno objLoggerinf;

        CConsulta objConsultainf;//

        WConsulta WConsultaVista;//meotodo para poder ocupar los metodos de la wAlumno

  
        protected void Page_Load(object sender, EventArgs e)
        {
            objLoggerinf = new CAlumno();
            objLoggerinf = (CAlumno)Session["UsuarioLogeado"];

            if (objLoggerinf != null)
            {
                objConsultainf = new CConsulta();
                WConsultaVista = new WConsulta(this);
                if (!IsPostBack)
                {
                    WConsultaVista.Listar(5, DatosPasienteConsulta);
                }
            }
            else {
                Response.Redirect("/Sesion.aspx", true);// no direcciona a la pagina default de la master
            }

        }

        #region IConsulta
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

        public CConsulta DatosPasienteConsulta
        {
            get
            {
                CConsulta Datos = new CConsulta();
                Datos.fk_Alumno = objLoggerinf.alu_NumControl;
                return Datos;
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

      

        public CConsulta EliminarConsulta
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        int IConsulta.EliminarConsulta
        {
            get
            {
                throw new NotImplementedException();
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
    }
}