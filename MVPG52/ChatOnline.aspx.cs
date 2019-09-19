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
    public partial class ChatOnline : System.Web.UI.Page,IChat,IAlumno
    {

        public GridViewRow FilaSeleccionada { get; private set; }

        public CChat objChat
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

        public DataSet DatosChat
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

        WAlumno vistaAlumno;
        WChat vistaChat;
        CEspecialista usuarioEspecialista;
        protected void Page_Load(object sender, EventArgs e)
        {
            vistaAlumno = new WAlumno(this);
            vistaChat = new WChat(this);
            try
            {
                usuarioEspecialista = new CEspecialista();
                usuarioEspecialista = (CEspecialista)Session["UsuarioLogeado"];
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lBtn = sender as LinkButton;
            string id = ((LinkButton)sender).CommandArgument.ToString();
            Label1.Text = lBtn.Text; //This lable used to display selected frend name.
            vistaChat.ListarConversacion(1, objChat);
            // LoadChatbox();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           
        }

        protected void UpdatePanel1_DataBinding(object sender, EventArgs e)
        {

        }

        public void Mensaje(string Mensaje, int tipo)
        {
            throw new NotImplementedException();
        }
    }
}