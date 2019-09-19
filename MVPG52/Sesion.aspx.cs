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
    public partial class Sesion : System.Web.UI.Page,IAlumno,IEspecialista
    {
    
        CAlumno objLoggerinf;//Objeto donde estara la informacion de logeo temporal
        WAlumno WAlumnoVista;//Objeto para poder ocupar los metodos de la wAlumno


        CEspecialista objLoggerinfEs;//Objeto donde estara la informacion de logeo temporal
        WEspecialista WEspecialistaVista;//Objeto para poder ocupar los metodos de la WEspecialista

        protected void Page_Load(object sender, EventArgs e)
        {

            Session.RemoveAll();

            if (!IsPostBack)
            {
                DropDownListRoles.Items.Clear();
                DropDownListRoles.Items.Add(new ListItem("Alumno", "1"));
                DropDownListRoles.Items.Add(new ListItem("Especialista", "2"));
            }
  

    

                //Inicializamos el objeto y le pasamos this como interfaz
            WAlumnoVista = new WAlumno(this);
            objLoggerinf = new CAlumno();

            objLoggerinfEs = new CEspecialista();
            WEspecialistaVista = new WEspecialista(this);
          }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownListRoles.SelectedValue== "1")
            {
                WAlumnoVista.ObtenerDatosDeAlumno(1, UsuarioLogeado); //En este metodo hace que el UsuarioLogeado objeto los valores del loggeo   
                if (objLoggerinf!=null)//Comparamos si el objeto que nos regreso y agregamos(declarado como objLoggerinf ) es nulo si es nulo no entra y si si nos manda a la pagina de inicio de la pagina
                {
                   Session.Clear();// limpiamos la sesion
                   Session.Add("UsuarioLogeado", objLoggerinf);//Creamos la variable de sesion en donde la podremos utlizar cuando nos mande a la master
                   Response.Redirect("/Default.aspx", true);// no direcciona a la pagina default de la master
                }

            }
            if (DropDownListRoles.SelectedValue == "2")
            {
                WEspecialistaVista.ObtenerDatosDeEspecialista(1, UsuarioLogeadoEspecialista); //En este metodo hace que el UsuarioLogeado objeto los valores del loggeo   
                if (objLoggerinfEs != null)//Comparamos si el objeto que nos regreso y agregamos(declarado como objLoggerinf ) es nulo si es nulo no entra y si si nos manda a la pagina de inicio de la pagina
                {
                    Session.Clear();// limpiamos la sesion
                    Session.Add("UsuarioLogeadoEspecialista", objLoggerinfEs);//Creamos la variable de sesion en donde la podremos utlizar cuando nos mande a la master
                    Response.Redirect("/Default.aspx", true);// no direcciona a la pagina default de la master
                }


            }


        }

        public void Mensaje(string Mensaje, int tipo)
        {
            
        }

        #region  Interfaz de Alumnos
        public CAlumno UsuarioLogeado
        {
            get
            {
                CAlumno objLoggerdUser = new CAlumno();
                objLoggerdUser.alu_Password = TextBoxContrasena.Text;
                objLoggerdUser.alu_NumControl = TextBoxNumeroDeControl.Text;
                objLoggerdUser.alu_Rol = 1;
                return objLoggerdUser;
            }
            set
            {
                if (value != null)
                {
                    objLoggerinf.alu_E1 = Convert.ToInt32(value.alu_E1);
                    objLoggerinf.alu_E2 = Convert.ToInt32(value.alu_E2);
                    objLoggerinf.alu_E3 = Convert.ToInt32(value.alu_E3);
                    objLoggerinf.alu_NumControl = Convert.ToString(value.alu_NumControl);
                    objLoggerinf.alu_Rol = Convert.ToInt32(value.alu_Rol);
                    objLoggerinf.alu_Nombre = Convert.ToString(value.alu_Nombre);
                    objLoggerinf.alu_ApePaterno = Convert.ToString(value.alu_ApePaterno);
                    objLoggerinf.alu_Sexo = Convert.ToString(value.alu_Sexo);
                    objLoggerinf.alu_Carrera = Convert.ToString(value.alu_Carrera);
                }
                else {
                    objLoggerinf = null;
                }

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
        #region IEspecialista

        public CEspecialista UsuarioLogeadoEspecialista
        {
            get
            {
                CEspecialista objLoggerdUser = new CEspecialista();
                objLoggerdUser.Contrasena = TextBoxContrasena.Text;
                objLoggerdUser.Numero_Control = TextBoxNumeroDeControl.Text;

                return objLoggerdUser;
            }
            set
            {
                if (value != null)
                {
                    objLoggerinfEs.pk_Especialista = value.pk_Especialista;
                    objLoggerinfEs.Numero_Control = Convert.ToString(value.Numero_Control);
                    objLoggerinfEs.Activo = Convert.ToString(value.Activo);
                    objLoggerinfEs.Nombre = Convert.ToString(value.Nombre);
                    objLoggerinfEs.Apellido = Convert.ToString(value.Apellido);
                    objLoggerinfEs.fk_Especialidad = Convert.ToString(value.fk_Especialidad);
                    objLoggerinfEs.Rol = Convert.ToInt32(value.Rol);
                    objLoggerinfEs.Especialidad_texto = value.Especialidad_texto;
                    objLoggerinfEs.Cedula = value.Cedula;

                }
                else {
                    objLoggerinfEs = null;
                }
            }
        }

        public DataSet Empleados { set => throw new NotImplementedException(); }

        #endregion
    }
}


