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
    public partial class SiteDoctor : System.Web.UI.MasterPage,IAlumno
    {
        CAlumno objLoggerdUser;

       

        protected void Page_Load(object sender, EventArgs e)
        {
            WAlumno objWAlumno = new WAlumno(this);

            objLoggerdUser = new CAlumno();

            if (!IsPostBack)
            {
                objLoggerdUser = (CAlumno)Session["UsuarioLogeado"];
                if (objLoggerdUser != null)
                {
                    MenuNombre.Text = objLoggerdUser.alu_Nombre;
                    if (objLoggerdUser.alu_ConestetoEncuesta != 0)
                    {
                        LinkButtonCuestionario.Visible = false;
                    }
                }
                else
                {
                    this.Visible = false;
                    Response.Redirect("/InicioEspecialista.aspx", true);
                }
            }
        }

        #region interfaz alumno

        public CAlumno UsuarioLogeado
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

        public DataSet ListadAlumno
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public CAlumno NewPersona
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CAlumno ValidarUsuario
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

        public CAlumno UsuarioActulizar
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

        #endregion

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            Response.Redirect("/AgendarCita.aspx", true);// no direcciona a la pagina default de la master
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/ConsultarCita.aspx", true);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/Cuestionario.aspx", true);
        }

        public void Mensaje(string Mensaje, int tipo)
        {
            throw new NotImplementedException();
        }
    }
}