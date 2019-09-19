using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Core.Model;
using Core.Presenter;
using Core.View;
using System.Data;

namespace MVPG52
{
    public partial class AgendaCitas : System.Web.UI.Page, IConsulta
    {
        CEspecialista objLoggerinf;
        WConsulta vistaConsulta;

        CAlumno ObjTmAlumno;// objeto donde se guardan los datos de la tabla 

        protected void Page_Load(object sender, EventArgs e)
        {

            objLoggerinf = (CEspecialista)Session["UsuarioLogeadoEspecialista"];
            if (objLoggerinf != null && objLoggerinf.Rol==2)
            {
                vistaConsulta = new WConsulta(this);
                ObjTmAlumno = new CAlumno();
                vistaConsulta.ListarMedicoAgenda(8, objLoggerinf);
            }
            else {
                Response.Redirect("/Sesion.aspx", true);//
            }

        }

        #region IConsulta
        public CConsulta DatosPasienteConsulta
        {
            get
            {
                CConsulta Datos = new CConsulta();
        
                return Datos;
            }
        }
        public CConsulta NewConsulta
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
        public DataSet ListadoConsulta
        {
            set
            {
                if (value != null)
                {
                    GridView2.DataSource = value;
                    GridView2.DataBind();
                    if (GridView2.Rows.Count<=0)
                    {
                        Panel1.Visible = true;
                    }
                }
              
            }
        }
        public DataSet Odontograma
        {
            set
            {
                
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
        public GridViewRow FilaSeleccionada {
            get;
            private set;
        }

        public DataSet HistorialCitas // se usa para obtener los datos del alumno seleccionado
        {
            set
            {
                if (value!=null)
                {
                    ObjTmAlumno.alu_E1 = Convert.ToInt16(value.Tables[0].Rows[0][1].ToString());
                    ObjTmAlumno.alu_E2 = Convert.ToInt16(value.Tables[0].Rows[0][2].ToString());
                    ObjTmAlumno.alu_E3 = Convert.ToInt16(value.Tables[0].Rows[0][3].ToString());
                    ObjTmAlumno.alu_NumControl = value.Tables[0].Rows[0][5].ToString();
                    ObjTmAlumno.alu_Nombre = value.Tables[0].Rows[0][6].ToString();
                    ObjTmAlumno.alu_ApePaterno = value.Tables[0].Rows[0][7].ToString();
                    ObjTmAlumno.alu_ApeMaterno = value.Tables[0].Rows[0][8].ToString();
                    ObjTmAlumno.alu_Sexo = value.Tables[0].Rows[0][9].ToString();
                    ObjTmAlumno.alu_FechaNacimiento = value.Tables[0].Rows[0][11].ToString();
                }
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

       

        public void Mensaje(string Mensaje, int tipo)
        {

        }
        #endregion
      


        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            FilaSeleccionada = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Eliminar")
            {

                int x = Convert.ToInt32((((Label)FilaSeleccionada.FindControl("Label1")).Text));
                vistaConsulta.EliminarConsulta(6, x);
                Response.Redirect("/AgendaCitas.aspx", true);// no direcciona a la pagina default de la master
            }
            if (e.CommandName == "Realizar")
            {
                string id = (((Label)FilaSeleccionada.FindControl("Label1")).Text);// id de la reservacion
                string matri = (((Label)FilaSeleccionada.FindControl("Label2")).Text);// id del alumno
                string TipoUsuario = (((Label)FilaSeleccionada.FindControl("label4")).Text);// id del alumno


                vistaConsulta.Datosalumno(11, matri);

                ObjTmAlumno.pk_Reservacion = id;// de la reservacion
                ObjTmAlumno.tipo_usuario = TipoUsuario; //agregamos el tipo de usuario

                Session.Add("DatosCitaAlumno",ObjTmAlumno); // se guardar los datos del alumno temporalmente
                Response.Redirect("/NuevaConsulta.aspx", true);// no direcciona a la pagina default de la master
            }
        }
    }


}