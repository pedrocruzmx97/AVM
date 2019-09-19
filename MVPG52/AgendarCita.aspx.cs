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
    public partial class AgendarCita : System.Web.UI.Page, IConsulta
    {

    
        List<CConsulta> listaDatos = new List<CConsulta>(); //Lista para almacenar los datos de las listas combos

        CAlumno objLoggerinf; //Datos de sesion
        CConsulta objConsultainf;//Objeto donde estara la informacion de logeo temporal
        WConsulta WConsultaVista;//meotodo para poder ocupar los metodos de la wAlumno

        public string CorreoAux { get; set; }


        private string fecha ;
        protected void Page_Load(object sender, EventArgs e)
        {
            objLoggerinf = new CAlumno();
            objLoggerinf = (CAlumno)Session["UsuarioLogeado"];


            objConsultainf = new CConsulta();

            if (objLoggerinf != null){
                WConsultaVista = new WConsulta(this);
                    if (!IsPostBack)
                    {
                        LlenadoComboEspecialidad(DropDownListESpecialidades, 1);//Se llena el combo de especialidades             
                     }
                }
            else
            {
                Response.Redirect("/Sesion.aspx", true);// no direcciona a la pagina default de la master}
            }
         
        }

        #region Eventos de botones
        protected void Button1_Click1(object sender, EventArgs e)   // Listado de especialista
        {
            DropDownListEspecialista.Items.Clear();
            LlenadoComboEspecialista(DropDownListEspecialista, 2, DropDownListESpecialidades.SelectedValue);
        }
        protected void Button2_Click2(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DropDownListEspecialista.Text) && !string.IsNullOrEmpty(TextBoxFecha.Text))
            {
                fecha = TextBoxFecha.Text;
                DropDownListHorario.Items.Clear();
                LlenadoComboHorario(DropDownListHorario, 3, TextBoxFecha.Text, DropDownListEspecialista.SelectedValue);
                TextBoxFecha.Text = fecha;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Campos vacios');", true);
            }

        } //listado de horarios
        protected void ButtonReuistrarConsulta_Click(object sender, EventArgs e) //agenda de cita
        {
           

            if (!string.IsNullOrWhiteSpace(DropDownListEspecialista.Text) && !string.IsNullOrEmpty(TextBoxFecha.Text) && !string.IsNullOrWhiteSpace(DropDownListHorario.Text))
            {
                //SetCorreo
                WConsultaVista.ObtenerCorreoEspecialista(16, DropDownListEspecialista.SelectedValue);

                WConsultaVista.Reguistrar(NewConsulta,objLoggerinf);//Se realiza el reguistro de la consulta
                DropDownListEspecialista.Items.Clear();
                TextBoxFecha.Text = "";
                DropDownListHorario.Items.Clear();
               
                Response.Redirect("/CancelarCita.aspx", true);// no direcciona a la pagina de citas
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Campos vacios');", true);
            }

        }
        #endregion

        #region Interfaz de Consulta

        public CConsulta DatosPasienteConsulta
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public CConsulta NewConsulta
        {
            get
            {
                CConsulta NuevaConsulta = new CConsulta();
                NuevaConsulta.ConsultaActiva = 2;
                NuevaConsulta.fk_Alumno = objLoggerinf.alu_NumControl;
                NuevaConsulta.fk_Especialista = DropDownListEspecialista.SelectedValue;
                NuevaConsulta.fk_Fecha = TextBoxFecha.Text;
                NuevaConsulta.fk_Hora = DropDownListHorario.SelectedValue;
                NuevaConsulta.CorreoEspecialista = this.CorreoAux;
                //Saber tipo de usuario
                if(TipoUsuario.Checked)
                    NuevaConsulta.TipoUsuario = 2;
                else
                    NuevaConsulta.TipoUsuario = 1;

                return NuevaConsulta;
            }
        }
        public int EliminarConsulta
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
                if (value!=null)
                {
                    this.CorreoAux = value.Tables[0].Rows[0][1].ToString();
                }
            }
        }

        //Llenado de combos
        public List<CConsulta> LlenarComboEspecialidad
        {
            get
            { return listaDatos; }
            set
            {
                if (value != null)
                { listaDatos = value; }
            }
        }
        private void LlenadoComboEspecialidad(DropDownList Combo, int Opcion)
        {
            WConsultaVista.ListarEspecilidad(Opcion);/// se implementa el llenado de la interfaz
            if (listaDatos != null)
            {
                foreach (CConsulta item in listaDatos)
                {
                    Combo.Items.Add(new ListItem(item.Descripcion, item.Id.ToString()));
                }
            }
        }
        public List<CConsulta> LlenarComboEspecialista
        {
            get
            { return listaDatos; }
            set
            {
                if (value != null)
                { listaDatos = value; }
            }
        }
        private void LlenadoComboEspecialista(DropDownList Combo, int Opcion,string Id)
        {
            WConsultaVista.ListarEspecilistas(Opcion, Id);/// se implementa el llenado de la interfaz
            if (listaDatos != null)
            {
                foreach (CConsulta item in listaDatos)
                {
                    Combo.Items.Add(new ListItem(item.Descripcion, item.Id.ToString()));
                }
            }
        }
        public List<CConsulta> LlenarComboHora
        {
            get
            { return listaDatos; }
            set
            {
                if (value != null)
                { listaDatos = value; }
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

        private void LlenadoComboHorario(DropDownList Combo, int Opcion, string Fecha,string fk_Especialista)
        {
            WConsultaVista.ListarHora(Opcion,Fecha, fk_Especialista);/// se implementa el llenado de la interfaz
            if (listaDatos != null)
            {
                foreach (CConsulta item in listaDatos)
                {
                    Combo.Items.Add(new ListItem(item.Descripcion, item.Id.ToString()));
                }
            }
        }
        public void Mensaje(string Mensaje, int tipo)
        {

        }
        #endregion

        protected void TextBoxFecha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}