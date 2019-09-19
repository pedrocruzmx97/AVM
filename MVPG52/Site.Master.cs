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
    public partial class SiteMaster : MasterPage,IAlumno,IEspecialista
    {
        CAlumno objLoggerdUser;
        CEspecialista objLoggerdUserEspecialista;

        protected void Page_Load(object sender, EventArgs e)
        {
            WAlumno   objWAlumno = new WAlumno(this);
            WEspecialista objwEspecialista = new WEspecialista(this);

            objLoggerdUser = new CAlumno();
            objLoggerdUserEspecialista = new CEspecialista();

            
            if (!IsPostBack)
            {
               
                objLoggerdUser = (CAlumno)Session["UsuarioLogeado"];
                objLoggerdUserEspecialista = (CEspecialista)Session["UsuarioLogeadoEspecialista"];


                if (objLoggerdUser != null  || objLoggerdUserEspecialista != null)
                {
                    if ( objLoggerdUser!=null)
                    {
                        if (objLoggerdUser.alu_Rol == 1) {
                            MenuNombre.Text = objLoggerdUser.alu_Nombre+" "+objLoggerdUser.alu_ApePaterno;
                            TipoUsuario.Text = "Alumno";
                            //Activamos los botones del panel de alumno
                            PanelBotonesAlumno.Visible = true;
                            PanelBotonesEspecialista.Visible = false;
                        }
                    }
                    if (objLoggerdUserEspecialista!=null)
                    {
                        if (objLoggerdUserEspecialista.Rol == 2 && objLoggerdUserEspecialista.Activo=="1") {
                            MenuNombre.Text = objLoggerdUserEspecialista.Nombre+" "+objLoggerdUserEspecialista.Apellido;
                            TipoUsuario.Text = "Especialista";
                            //Activamos los botones del panel de alumno
                            PanelBotonesAlumno.Visible = false;
                            PanelBotonesEspecialista.Visible = true;
                        }
                        if (objLoggerdUserEspecialista.Rol == 3)
                        {
                            Session.Add("admin", objLoggerdUserEspecialista);
                            Response.Redirect("http://localhost:16748/", true);
                        }

                        
                    }
                }
                else
                {
                    this.Visible = false;
                    Response.Redirect("/Sesion.aspx", true);
                }  

            }
           
        }


        #region interfaz alumno
        public DataSet ListadAlumno
        {

            set
            {
               
            }
        }

        public CAlumno NewPersona
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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

        public CAlumno ValidarUsuario
        {

            get
            {
                throw new NotImplementedException();
            }
            set {

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

        public void Mensaje(string Mensaje, int tipo)
        {
            
        }


        #endregion

        #region Metodos del Alumno
        //Agendar una cita
        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            Response.Redirect("/AgendarCita.aspx", true);
        }
        //Consulta/Cancelacion de cita
        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/CancelarCita.aspx", true);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Historial-Clinico.aspx", true);
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/Cuestionario.aspx", true);
        }
        #endregion

        #region Interfaz Especialista
        public CEspecialista UsuarioLogeadoEspecialista
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

        public DataSet Empleados { set => throw new NotImplementedException(); }

        #endregion

        #region Metodos del especialista
        protected void LinkButtonAgendaCitas_Click(object sender, EventArgs e)
                {
                    Response.Redirect("/AgendaCitas.aspx", true);
                }
         protected void LinkButtoHistorialClinico_Click(object sender, EventArgs e)
         {
            Response.Redirect("/HistorialClinico.aspx", true);
        }
        protected void LinkButtonHistorialCitas_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HistorialCitas.aspx", true);
        }
        protected void LinkButtonArchivos_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Archivos.aspx", true);
        }


        #endregion

        protected void LinkButtonSALIR_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("/Sesion.aspx", true);
        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CitaRapida.aspx", true);
        }
    }
}