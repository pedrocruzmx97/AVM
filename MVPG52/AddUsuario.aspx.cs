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
    public partial class AddUsuario : System.Web.UI.Page,IEspecialista
    {
        CEspecialista objLoggerinf;
        WEspecialista vistaEspecialista;

        GridViewRow FilaSeleccionada;

        public int OpcionObjetoEspecialista=0;

        protected void Page_Load(object sender, EventArgs e)
        {

            objLoggerinf = (CEspecialista)Session["UsuarioLogeadoEspecialista"];
            if (objLoggerinf != null && objLoggerinf.Rol == 2)
            {
                vistaEspecialista = new WEspecialista(this);

                vistaEspecialista.ListarEmpleados(2,objLoggerinf);
            }
            else
            {
                Response.Redirect("/Sesion.aspx", true);//
            }


        }

        #region Especialista
        public CEspecialista UsuarioLogeadoEspecialista {
            get {
                CEspecialista ObjEspecialista = new CEspecialista();

                switch (this.OpcionObjetoEspecialista)
                {
                    case 1:
                        ObjEspecialista.Activo = "1";
                        ObjEspecialista.Cedula = Cedula.Text;
                        ObjEspecialista.Numero_Control = NumeroControl.Text;
                        ObjEspecialista.Contrasena = Clave.Text;
                        ObjEspecialista.Nombre = Nombre.Text;
                        ObjEspecialista.Apellido = Apellido.Text;
                        ObjEspecialista.FechaNacimiento = TextBoxFecha.Text;
                        ObjEspecialista.Direccion = Direccion.Text;
                        ObjEspecialista.Correo = Correo.Text;
                        ObjEspecialista.Telefono = Telefono.Text;
                        ObjEspecialista.fk_Especialidad = RolEspecialista.SelectedValue;
                        ObjEspecialista.Rol = Convert.ToInt32(Rol.SelectedValue);
                        ObjEspecialista.Genero = GeneroList.SelectedValue;
                        break;
                    case 2:
                        ObjEspecialista.Activo = "1";
                        ObjEspecialista.Cedula = Cedula1.Text;
                        ObjEspecialista.Numero_Control = NumeroControl1.Text;
                        ObjEspecialista.Contrasena = Clave1.Text;
                        ObjEspecialista.Nombre = Nombre1.Text;
                        ObjEspecialista.Apellido = Apellido1.Text;
                        ObjEspecialista.Direccion = Direccion1.Text;
                        ObjEspecialista.Correo = Correo1.Text;
                        ObjEspecialista.Telefono = Telefono1.Text;
                        
                        if (EspecialidadCAmbio.Text == "Medico")
                            ObjEspecialista.fk_Especialidad = "1";
                        if (EspecialidadCAmbio.Text == "Dental")
                            ObjEspecialista.fk_Especialidad = "2";
                        if (EspecialidadCAmbio.Text == "Psicologico")
                            ObjEspecialista.fk_Especialidad = "3";
                        if (RolEspecialista.SelectedValue != "0")
                        {
                            ObjEspecialista.fk_Especialidad = DropDownListEspecilaidadesCambio.SelectedValue;
                        }


                        if (DropDownListGenero.SelectedValue != "3")
                            ObjEspecialista.Genero = DropDownListGenero.SelectedValue;
                        else
                            ObjEspecialista.Genero = (Genero1.Text == "Femenino") ? "0" : "1";
                        break;

                    default:return null;
                      

                }
                

                return ObjEspecialista ;
            }
            set {
                if (value!=null)
                {
                    Cedula1.Text = value.Cedula.ToString();
                    NumeroControl1.Text = value.Numero_Control.ToString();
                    Clave1.Text = value.Contrasena.ToString();
                    Nombre1.Text = value.Nombre.ToString();
                    Apellido1.Text = value.Apellido.ToString();

                    Genero1.Text = (value.Genero.ToString()=="0")? "Femenino":"Masculino";
                    Direccion1.Text = value.Direccion.ToString();
                    Correo1.Text = value.Correo.ToString();
                    Telefono1.Text = value.Telefono.ToString();

                    EspecialidadCAmbio.Text = value.fk_Especialidad.ToString();

                    
                }
            }
        }
        public DataSet Empleados {
            set {
                if (value!=null)
                {
                    GridViewEmpleados.DataSource = value;
                    GridViewEmpleados.DataBind();
                }
            }
        }

        public void Mensaje(string Mensaje, int tipo)
        {
           
        }
        #endregion

        protected void GridViewEmpleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            FilaSeleccionada = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Eliminar")
            {
                string x = (((Label)FilaSeleccionada.FindControl("Label2")).Text);
                CEspecialista objaux = new CEspecialista();
                objaux.Numero_Control = x;
                vistaEspecialista.ConfiguracionEmpleados(objaux, 5);
                Response.Redirect("/AddUsuario.aspx", true);//
            }
            if (e.CommandName == "Modificacion")
            {
                string x = (((Label)FilaSeleccionada.FindControl("Label2")).Text);
                CEspecialista objaux = new CEspecialista();
                objaux.Numero_Control = x;
                vistaEspecialista.ConfiguracionEmpleados(objaux, 6);
               
            }
        }
        protected void Guardar_Click(object sender, EventArgs e)
        {
            bool listo = true;
            if (Clave.Text != ClaveRepetir.Text) {           
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Contraseñas no coinciden');", true);
                listo=false;
                goto Final;
            }


            if (NumeroControl.Text != NumeroControlReoetir.Text) {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Numero de control no Coincide');", true);
                listo = false;
                goto Final;
            }



            Final:
            if (listo)
            {
                this.OpcionObjetoEspecialista = 1;//toma los datos de alta
                vistaEspecialista.ConfiguracionEmpleados(UsuarioLogeadoEspecialista, 3);
                Response.Redirect("/AddUsuario.aspx", true);//
                this.OpcionObjetoEspecialista = 0;//se limpia la variable
            }
        }

        protected void Cambiar_Click(object sender, EventArgs e)
        {
            bool listo = true;


         
            if (listo)
            {
                this.OpcionObjetoEspecialista = 2;//toma los datos de modificacion
                vistaEspecialista.ConfiguracionEmpleados(UsuarioLogeadoEspecialista, 4);
                Response.Redirect("/AddUsuario.aspx", true);//
                this.OpcionObjetoEspecialista = 0;//se limpia la variable
            }
        }
    }
}