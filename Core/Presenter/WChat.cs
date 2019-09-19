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
    public class WChat
    {
        ManagerBD Manager;
        IChat interfaceChat;
        CChat miChat;
        public WChat(IChat InterfaceChat)
        {
            Manager = new ManagerBD();
            this.interfaceChat = InterfaceChat;
            miChat = new CChat();
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
        public void ListarConversacion(int opcion, CChat objChat)
        {
            bool ExistenDatos = false;
            DataSet dtsDatos = new DataSet();
            if (ExisteConexion())
            {
                ExistenDatos = miChat.listarConversacion(opcion, ref dtsDatos, objChat);
                if (ExistenDatos == true)
                    interfaceChat.DatosChat = dtsDatos;

            }


        }
        public void Enviar(CChat objChat)
        {
            bool BolRegistro = false;
            if (ExisteConexion())
            {
                BolRegistro = miChat.EnviarMensaje(2, objChat);

            }
        }
    }
}

