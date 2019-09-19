using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using System.Net.Mail;
using System.Threading;

using Core.Model;
using System.Globalization;
using System.Net.Mime;
using System.Net;

using System.Threading;

namespace Core.Model
{
    public class CConsulta
    {
        #region Variables
        //varibles de la consulta
        public int ConsultaActiva { get; set; }
        public string fk_Alumno { get; set; }
        public string fk_Especialista { get; set; }
        public string fk_EspecialistaControl { get; set; }
        public string fk_Fecha { get; set; }
        public string fk_Hora { get; set; }
        public int TipoUsuario { get; set; }
        ///nuevas propiedades para generar una cita medica

        public string pk_Reservacion { get; set; }
        public string ResumenAntecedente { get; set; }
        public float Peso { get; set; }
        public float Talla { get; set; }
        public float PresionArterial { get; set; }
        public string ExploracionFisica { get; set; }
        public string Diagnostico { get; set; }
        public string PlanDeTratamiento { get; set; }
        public float Temperatura { get; set; }
        public float RitmoCardiaco { get; set; }
        public float DiasReposo { get; set; }

  

        //Varibles para el uso de combos
        public string Id { get; set; }
        public string Descripcion { get; set; }

        //Variables para el odontograma
        public int Diente { get; set; }
        public string FechaOdontograma { get; set; }
        public string DiagnositcoOdontograma { get; set; }
        public string TratatmientoOdontograma { get; set; }
        public string ObservacionesOdontograma { get; set; }

        //Correo
        public string CorreoEspecialista { get; set; }


        private CConsulta ObjMailConsulta;

        private CAlumno objMailAlumno;

        ManagerBD objManagerBD;
        #endregion
        MailMessage mail = new MailMessage();
         
       
        public CConsulta() {
            objManagerBD = new ManagerBD();
        }
        #region Metodos Del Alumno
        //Reguistrar una cita
        public bool reguistro(int opcion, CConsulta obj)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@ConsultaActiva", SqlDbType.Int) { Value = obj.ConsultaActiva });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.NVarChar, 50) { Value = obj.fk_Alumno });
            lstParametros.Add(new SqlParameter("@fk_Especialista", SqlDbType.VarChar,50) { Value = obj.fk_Especialista });
            lstParametros.Add(new SqlParameter("@Fecha", SqlDbType.VarChar,50) { Value = obj.fk_Fecha });
            lstParametros.Add(new SqlParameter("@fk_Horario", SqlDbType.Int) { Value = obj.fk_Hora });
            lstParametros.Add(new SqlParameter("@TipoUsuario", SqlDbType.Int) { Value = obj.TipoUsuario });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PConsulta", lstParametros.ToArray())) {
                return true;
            }

            return false;
        }
        //para la cita rapida
        public bool reguistro(int opcion, CConsulta obj,int Estado)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@ConsultaActiva", SqlDbType.Int) { Value = Estado });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.NVarChar, 50) { Value = obj.fk_Alumno });
            lstParametros.Add(new SqlParameter("@fk_Especialista", SqlDbType.VarChar, 50) { Value = obj.fk_Especialista });
            lstParametros.Add(new SqlParameter("@Fecha", SqlDbType.VarChar, 50) { Value = obj.fk_Fecha });
            lstParametros.Add(new SqlParameter("@fk_Horario", SqlDbType.Int) { Value = obj.fk_Hora });
            lstParametros.Add(new SqlParameter("@TipoUsuario", SqlDbType.Int) { Value = obj.TipoUsuario });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PConsulta", lstParametros.ToArray()))
            {
                return true;
            }

            return false;
        }
        //Cancelacion de una cita
        public bool EliminarConsulta(int opcion, int IdConsulta)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@pk_Reservaciones", SqlDbType.Int) { Value = IdConsulta });
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PConsulta", lstParametros.ToArray())) {
                return true;
            }
               

            return false;
        }
        //Listado de las citas por alumno
        public bool listarCitas(int opcion, ref DataSet objDatos,CConsulta obj)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.NVarChar, 50) { Value = obj.fk_Alumno });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        
      
        //Metodos para poner datos en los DropList
        //Procedimiento 1 Listado de las especialidades
        public bool ListarEspecialidades(int opcion, ref DataSet objDatos)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        //Procedimieto 2 listado de los especialistas basado en lo anteriro
        public bool listarEspecialista(int opcion, ref DataSet objDatos, string IdPespecialista)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Especialidad", SqlDbType.Int) { Value = IdPespecialista });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());

            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;
            
            return ExisteDatos;
        }
        //Procedimieto 3 listado de los horarios dispobiles en aquella fecha
        public bool listarHorario(int opcion, ref DataSet objDatos, String Fecha,String fk_Especialista)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@Fecha", SqlDbType.VarChar,50) { Value = Fecha });
            lstParametros.Add(new SqlParameter("@fk_Especialista", SqlDbType.Int) { Value = fk_Especialista });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0) {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        //ver odontograma
        public bool listarOdontograma(int opcion, ref DataSet objDatos,  string fk_Alumno)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.NVarChar, 50) { Value = fk_Alumno });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        #endregion

        #region Metodos del especialista

        //Reguistro de una consulta medica /dental
        public bool reguistroConsulta(int opcion, CConsulta obj)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.NVarChar, 50) { Value = obj.fk_Alumno });
            lstParametros.Add(new SqlParameter("@fk_Especialista", SqlDbType.VarChar, 50) { Value = obj.fk_EspecialistaControl});
            lstParametros.Add(new SqlParameter("@ResumenAntecedente", SqlDbType.VarChar, 1024) { Value = obj.ResumenAntecedente });
            lstParametros.Add(new SqlParameter("@ExploracionFisica", SqlDbType.VarChar, 1024) { Value = obj.ExploracionFisica });
            lstParametros.Add(new SqlParameter("@Diagnostico", SqlDbType.VarChar, 2048) { Value = obj.Diagnostico });
            lstParametros.Add(new SqlParameter("@PlanDeTratamiento", SqlDbType.VarChar, 2048) { Value = obj.PlanDeTratamiento });
            lstParametros.Add(new SqlParameter("@Talla", SqlDbType.Float) { Value = obj.Talla });
            lstParametros.Add(new SqlParameter("@Peso", SqlDbType.Float) { Value = obj.Peso });
            lstParametros.Add(new SqlParameter("@PresionArterial", SqlDbType.Float) { Value = obj.PresionArterial });
            lstParametros.Add(new SqlParameter("@fk_Reservacion", SqlDbType.Int) { Value = obj.pk_Reservacion });

            lstParametros.Add(new SqlParameter("@Temperatura", SqlDbType.Float) { Value = obj.Temperatura });
            lstParametros.Add(new SqlParameter("@RitmoCardiaco", SqlDbType.Int) { Value = obj.RitmoCardiaco });
            lstParametros.Add(new SqlParameter("@DiasReposo", SqlDbType.Int) { Value = obj.DiasReposo });

            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PConsulta", lstParametros.ToArray()))
                return true;
            return false;
        }
        //ver citas que tiene el medico
        public bool listarCitasMedico(int opcion, ref DataSet objDatos, CEspecialista obj)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Especialista", SqlDbType.NVarChar, 50) { Value = obj.Numero_Control });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }  
        //insertar una nueva enfermedad
        public bool InsertarEnfermedad(int opcion, string enfermedades)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@Enfermedad", SqlDbType.VarChar) { Value = enfermedades });
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PConsulta", lstParametros.ToArray()))
                return true;
            return false;
        }
        //Procedimiento listado de las enfermedades
        public bool listarEnfermedades(int opcion, ref DataSet objDatos)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());

            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;

            return ExisteDatos;
        }
        //Ver historial Clinico por alumno
        public bool listarHistorialClinicoAlumno(int opcion, ref DataSet objDatos, CConsulta obj)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.NVarChar, 50) { Value = obj.fk_Alumno });
            lstParametros.Add(new SqlParameter("@TipoHistorial", SqlDbType.Int, 50) { Value = obj.TipoUsuario });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        //Ver historial Citas por alumno
        public bool listarHistorialCitasAlumno(int opcion, ref DataSet objDatos, string obj,CConsulta DatosAlumno)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@pk_Reservaciones", SqlDbType.NVarChar, 50) { Value = obj });
            lstParametros.Add(new SqlParameter("@TipoHistorial", SqlDbType.Int, 50) { Value = DatosAlumno.TipoUsuario });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.NVarChar, 50) { Value = DatosAlumno.fk_Alumno });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        //Obtenemos datos del alumno para generar la consulta medica
        public bool ListarAlumnoInf(int opcion, ref DataSet objDatos,string id )
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Alumno ", SqlDbType.NVarChar, 50) { Value = id });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());

            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;

            return ExisteDatos;
        }
        //insertar un odontograma
        public bool InsertarOdontograma(int opcion, CConsulta NewOdontograma)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Especialista", SqlDbType.VarChar) { Value = NewOdontograma.fk_EspecialistaControl });
            lstParametros.Add(new SqlParameter("@fk_Alumno", SqlDbType.VarChar) { Value = NewOdontograma.fk_Alumno });
            lstParametros.Add(new SqlParameter("@Diente", SqlDbType.Int) { Value = NewOdontograma.Diente });
            lstParametros.Add(new SqlParameter("@DiagnositcoOdontograma", SqlDbType.VarChar) { Value = NewOdontograma.DiagnositcoOdontograma });
            lstParametros.Add(new SqlParameter("@TratatmientoOdontograma", SqlDbType.VarChar) { Value = NewOdontograma.TratatmientoOdontograma });
            lstParametros.Add(new SqlParameter("@ObservacionesOdontograma", SqlDbType.VarChar) { Value = NewOdontograma.ObservacionesOdontograma });
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("PConsulta", lstParametros.ToArray()))
                return true;
            return false;
        }

        #endregion

        #region Notifiacion Email
        public bool listarCorreo(int opcion, ref DataSet objDatos, string id)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lstParametros.Add(new SqlParameter("@fk_Especialista ", SqlDbType.NVarChar, 50) { Value = id });
            objDatos = objManagerBD.GetData("PConsulta", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }
        private void CorrerProceso()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            if (this.ObjMailConsulta.CorreoEspecialista != null)
            {
                msg.To.Add(this.ObjMailConsulta.CorreoEspecialista);
            }
            else {
                msg.To.Add("1530096@upt.edu.mx");
            }
            
            msg.From = new MailAddress("1530096@upt.edu.mx", "Sistema Clínico UPT", System.Text.Encoding.UTF8);
            msg.Subject = "Notifiación de cita";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "<html>" +
                "<head>" +
                "<title>Blog de tareas </title>" +
                "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css' integrity='sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u' crossorigin='anonymous'>" +
                "</head>" +
                "	<body>" +
                "       <div class='container '>" +
                "           <h1>Aviso de cita</h1>" +
                "           <br>" +
                "           <h2>Datos</h2>" +
                "            <br>" +
                "   <h3>Nombre:  </h3>" + this.objMailAlumno.alu_Nombre+" "+this.objMailAlumno.alu_ApePaterno+" "+this.objMailAlumno.alu_ApeMaterno+
                "   <br>"+
                "   <h3>Fecha: </h3>" +ObjMailConsulta.fk_Fecha+
                "<br>"+
                "       </div>" +
                "	</body></ html > "
                           ;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;

            //Aquí es donde se hace lo especial
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("1530096@upt.edu.mx", "octavioO1230..");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
            }

        }
        public void EmailNotificacion(CConsulta DatosConsulta,CAlumno DatosAlumno)//CAlumno MiAlumno,CEspecialista MiEspecialista,String[] Mensaje)
        {
            this.ObjMailConsulta = DatosConsulta;
            this.objMailAlumno = DatosAlumno;

         
            ThreadStart delegado = new ThreadStart(CorrerProceso);           
            Thread hilo = new Thread(delegado);
            try
            {
                hilo.Start();
            }
            catch (Exception)
            {
            }
        }

        #endregion
    }
}
