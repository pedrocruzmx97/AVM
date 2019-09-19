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

using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace MVPG52
{
    public partial class NuevaConsulta : System.Web.UI.Page, IConsulta, ICuestionario
    {

        List<CConsulta> listaDatos = new List<CConsulta>(); //Lista para almacenar los datos de las listas combos
                                                            //Especialista
        CEspecialista usuariologeado;//Objeto donde se guarda los datos de sesion del especialista
                                     //Consulta
        CConsulta objConsultainf;
        WConsulta WConsultaVista;
        //Cuestionario
        WCuestionario miCuestionario;
        //Alumno
        CAlumno miAlumno;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuariologeado = new CEspecialista();
            usuariologeado = (CEspecialista)Session["UsuarioLogeadoEspecialista"];  //Objeto donde esta los datos de sesion del especialista

            miAlumno = (CAlumno)Session["DatosCitaAlumno"];//Agregamos datos generales de la pagina (AGENDA CITAS) para poder obtener datos del alumno que tiene la consulta

            if (usuariologeado != null && usuariologeado.Rol == 2)
            {
                if (miAlumno != null)
                {


                    //inicializacion de objetos 
                    objConsultainf = new CConsulta();
                    WConsultaVista = new WConsulta(this);
                    miCuestionario = new WCuestionario(this);

                    miCuestionario.ListarUsuarioHistorialClinico(7, miAlumno.alu_NumControl);//Metodo que carga el historial clinico 
                    WConsultaVista.ListarHistorialMedico(9, DatosPasienteConsulta);//Obtenemos el historial de citas del alumno
                    WConsultaVista.ListarOdontograma(14, miAlumno.alu_NumControl);    // llenado del odontograma


                    LlenadoALumno();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('No tiene un pasiente asignado');", true);
                }
                //activacion de paneles de rol
                if (usuariologeado.fk_Especialidad == "1")//dentista
                {
                    HyperLinkMedico.Visible = true;
                }
                if (usuariologeado.fk_Especialidad == "2")//medico
                {
                    HyperLinkMedico.Visible = true;
                    HyperLinkOdontograma.Visible = true;
                }
                if (usuariologeado.fk_Especialidad == "3")//Psicologo
                {
                    HyperLinkPsicologo.Visible = true;
                }
            }
            else
            {
                Response.Redirect("/Sesion.aspx", true);
            }
        }

        #region Interfaz Consulta
        public DataSet Odontograma
        {
            set
            {
                if (true)
                {
                    GridViewOdontogtrama.DataSource = value; //Pestañana 2 se genera el historial de citas medicas
                    GridViewOdontogtrama.DataBind();
                }
            }
        }
        public CConsulta DatosPasienteConsulta
        {
            get
            {
                CConsulta Datos = new CConsulta();
                Datos.fk_Alumno = miAlumno.alu_NumControl;
                Datos.TipoUsuario = Convert.ToInt32(usuariologeado.fk_Especialidad);// selecciona el tipo de historial dependiendo del rol del doctor
                return Datos;
            }
        }
        public CConsulta NewConsulta
        {
            //Generalizacion de los 3 consultas en una sola
            get
            {
                CConsulta Datos = new CConsulta();

                Datos.fk_Alumno = miAlumno.alu_NumControl; //Numero de control de alumno
                Datos.fk_Especialista = usuariologeado.pk_Especialista;// numero de control de especialista
                Datos.fk_EspecialistaControl = usuariologeado.Numero_Control;
                Datos.pk_Reservacion = miAlumno.pk_Reservacion; // numero de reservacion de la cita


                Datos.ResumenAntecedente = ResumenAntecedente.Text; //Interrogatorio al paciente
                Datos.Temperatura = (Talla.Text != "") ? float.Parse(Talla.Text) :  0;
                Datos.Temperatura = (Temperatura.Text != "") ? float.Parse(Temperatura.Text) : 0;
                Datos.Peso= (Peso.Text != "")? float.Parse(Peso.Text): 0;
                Datos.RitmoCardiaco= (RtimoCardiaco.Text != "")? float.Parse(RtimoCardiaco.Text) :  0;
                Datos.PresionArterial= (Presion1.Text != "" && Presion.Text != "")? float.Parse(Presion.Text) / float.Parse(Presion1.Text):  0;
                Datos.ExploracionFisica = ResumenExploracion.Text;

                Datos.Diagnostico = (autocompleteDiagnostico.Text!="")?autocompleteDiagnostico.Text:"Sin especificacion";

                Datos.PlanDeTratamiento = PlanTratamiento.Text;

                Datos.DiasReposo= (DiasReposo.Text != "")? int.Parse(DiasReposo.Text): Datos.DiasReposo = 0;
            

                //Odontograma
                if (NumeroDiente.Text != "") Datos.Diente = int.Parse(NumeroDiente.Text); else Datos.Diente = 0;
                Datos.DiagnositcoOdontograma = DiagnosticoDiente.Text;
                Datos.TratatmientoOdontograma = TratamientoDiente.Text;
                Datos.ObservacionesOdontograma = ComentarioDiente.Text;
                //Pisolcogo
                if (HyperLinkPsicologo.Visible)
                {
                    Datos.ResumenAntecedente = DiagnosticoPsicologo.Text; //diagnositico
                    Datos.ExploracionFisica = TratamientoPsicologo.Text;//tratamiento
                    Datos.PlanDeTratamiento = ComentarioPsicologo.Text;//Comentarios
                }

                return Datos;
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
                if (value != null)
                {
                    GridViewHIstorialCitas.DataSource = value; //Pestañana 2 se genera el historial de citas medicas
                    GridViewHIstorialCitas.DataBind();
                }
            }
        } //Listado de citas medicas
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
        public List<CConsulta> LlenarEnfermedad
        {
            get
            { return listaDatos; }
            set
            {
                if (value != null)
                { listaDatos = value; }
            }

        }
        #endregion

        #region Interfaz Cuestionario

        public void Mensaje(string Mensaje, int tipo)
        {
            // throw new NotImplementedException();
        }
        public CCuestionario NewCuestionarioDental
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CCuestionario NewCuestionarioMedico
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public CCuestionario NewCuestionarioPsicologico
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DataSet ListadoCuestionarioDental
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public DataSet ListadoCuestionarioMedico
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public DataSet ListadoCuestionarioPsicologico
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<CCuestionario> LlenarComboSangre
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
        public DataSet ListadoCuestionario//Cuestionario general
        {
            set
            {
                if (value != null)
                {
                    //Dentista
                    d1.Text = value.Tables[0].Rows[0][0].ToString();
                    d2.Text = value.Tables[0].Rows[0][1].ToString();
                    d3.Text = value.Tables[0].Rows[0][2].ToString();
                    d4.Text = value.Tables[0].Rows[0][3].ToString();
                    d5.Text = value.Tables[0].Rows[0][4].ToString();
                    d6.Text = value.Tables[0].Rows[0][5].ToString();
                    d7.Text = value.Tables[0].Rows[0][6].ToString();
                    d8.Text = value.Tables[0].Rows[0][7].ToString();
                    d9.Text = value.Tables[0].Rows[0][8].ToString();
                    d10.Text = value.Tables[0].Rows[0][9].ToString();
                    d11.Text = value.Tables[0].Rows[0][10].ToString();


                    m1.Text = value.Tables[0].Rows[0][11].ToString();
                    m2.Text = value.Tables[0].Rows[0][12].ToString();
                    m3.Text = value.Tables[0].Rows[0][13].ToString();
                    m4.Text = value.Tables[0].Rows[0][14].ToString();
                    m5.Text = value.Tables[0].Rows[0][15].ToString();
                    m6.Text = value.Tables[0].Rows[0][16].ToString();
                    m7.Text = value.Tables[0].Rows[0][17].ToString();
                    m8.Text = value.Tables[0].Rows[0][18].ToString();
                    m9.Text = value.Tables[0].Rows[0][19].ToString();
                    m10.Text = value.Tables[0].Rows[0][20].ToString();
                    m11.Text = value.Tables[0].Rows[0][21].ToString();
                    m12.Text = value.Tables[0].Rows[0][22].ToString();
                    m13.Text = value.Tables[0].Rows[0][23].ToString();
                    m14.Text = value.Tables[0].Rows[0][24].ToString();
                    m15.Text = value.Tables[0].Rows[0][25].ToString();
                    m16.Text = value.Tables[0].Rows[0][26].ToString();
                    m17.Text = value.Tables[0].Rows[0][27].ToString();
                    m18.Text = value.Tables[0].Rows[0][28].ToString();
                    m19.Text = value.Tables[0].Rows[0][29].ToString();
                    m20.Text = value.Tables[0].Rows[0][30].ToString();
                    m21.Text = value.Tables[0].Rows[0][31].ToString();
                    m22.Text = value.Tables[0].Rows[0][32].ToString();
                    m23.Text = value.Tables[0].Rows[0][33].ToString();
                    m24.Text = value.Tables[0].Rows[0][34].ToString();
                    m25.Text = value.Tables[0].Rows[0][35].ToString();


                    p1.Text = value.Tables[0].Rows[0][36].ToString();
                    p2.Text = value.Tables[0].Rows[0][37].ToString();
                    p3.Text = value.Tables[0].Rows[0][38].ToString();
                    p4.Text = value.Tables[0].Rows[0][39].ToString();
                    p5.Text = value.Tables[0].Rows[0][40].ToString();
                    p6.Text = value.Tables[0].Rows[0][41].ToString();
                    p7.Text = value.Tables[0].Rows[0][42].ToString();
                    p8.Text = value.Tables[0].Rows[0][43].ToString();
                    p9.Text = value.Tables[0].Rows[0][44].ToString();
                    p10.Text = value.Tables[0].Rows[0][45].ToString();
                    p11.Text = value.Tables[0].Rows[0][46].ToString();
                    p12.Text = value.Tables[0].Rows[0][47].ToString();
                    p13.Text = value.Tables[0].Rows[0][48].ToString();
                    p14.Text = value.Tables[0].Rows[0][49].ToString();
                    p15.Text = value.Tables[0].Rows[0][50].ToString();
                    p16.Text = value.Tables[0].Rows[0][51].ToString();
                    p17.Text = value.Tables[0].Rows[0][52].ToString();
                    p18.Text = value.Tables[0].Rows[0][53].ToString();
                    p19.Text = value.Tables[0].Rows[0][54].ToString();
                }
            }
        }

        public DataSet HistorialCitas
        {
            set
            {
                if (true)
                {
                    GridViewHIstorialCitas.DataSource = value;
                    GridViewHIstorialCitas.DataBind();
                }
            }
        }
        #endregion

        private void LlenadoComboEnfermedades(DropDownList Combo, int Opcion)
        {

            WConsultaVista.ListarEnfermedades(Opcion);/// se implementa el llenado de la interfaz
            if (listaDatos != null)
            {
                foreach (CConsulta item in listaDatos)
                {
                    Combo.Items.Add(new System.Web.UI.WebControls.ListItem(item.Descripcion, item.Id.ToString()));
                }
            }
        }
        private void LlenadoALumno()
        {
            TipoDeConsulta.Text = miAlumno.tipo_usuario;
            LabelNombreAlumno.Text = miAlumno.alu_Nombre + " " + miAlumno.alu_ApePaterno + " " + miAlumno.alu_ApeMaterno;
            LabelMatriculaAlumno.Text = miAlumno.alu_NumControl;

        }
        //
        protected void ButtonOtro_Click(object sender, EventArgs e)
        {
            // WConsultaVista.InsertarEnfermedad(10, txtOtro.Text);
            //ListaDiagnosticio.Items.Clear();
            //LlenadoComboEnfermedades(ListaDiagnosticio, 12);
            //se comento por que el auto llenado de enfermedaddes esta listo
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (NewConsulta != null){
                WConsultaVista.ReguistrarConsulta(NewConsulta);
                Response.Redirect("/AgendaCitas.aspx", true);// no direcciona a la pagina default de la master}
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Listo');", true);
            }
            else {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Faltan datos');", true);
            }
           
        }//Realizar consulta

        protected void Imprimir_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToShortDateString();
            string cadenaFinal = "";
            string path = Server.MapPath("/IMAG/universidad/encabezadoReseta.png");
            cadenaFinal += "<img src='" + path + "' Height='150' Width='500' />";
            cadenaFinal += "<br/><br/>";
            cadenaFinal += "<table colspan=2> <tr><td><b>Tipo de consulta:</b> " + usuariologeado.Especialidad_texto + "</td><td><b>Fecha:</b> " + fecha + "</td></tr> </table>";
            cadenaFinal += "<br/><br/>";
            cadenaFinal += "<table border='1'>";
            cadenaFinal += "<tr><td colspan=4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Datos del médico</b></td></tr>";
            //Tiene que llevar el nombre del médico                                                         Tiene que llevar el nombre del médico  
            cadenaFinal += "<tr><td colspan=2><b>Nombre:</b> " + usuariologeado.Nombre + " " + usuariologeado.Apellido + "<td colspan=2><b>Cédula profesional:</b> " + usuariologeado.Cedula + "</td></tr>";
            cadenaFinal += "</table>";
            cadenaFinal += "<br/><br/><br/>";
            cadenaFinal += "<TABLE BORDER='1'>" +
                "<div> <TR><TD colspan=4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <b>Datos del alumno</b> </TD></TR> </div>" +
                "<TR><TD colspan=2><b>Nombre:</b> " + LabelNombreAlumno.Text + "</TD><TD colspan=2><b>Matrícula:</b> " + LabelMatriculaAlumno.Text + "</TD></TR>" +
                            "<TR><TD colspan=4><b>Resumen del antecedente:</b> " + ResumenAntecedente.Text + "</TD></TR>" +
                            "<TR><TD colspan=4 >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>Datos físicos</b> </TD></TR>" +
                            "<tr><td colspan=2><b>Talla:</b> " + Talla.Text + "</td>" +
                            "<td colspan=3><b>Peso:</b> " + Peso.Text + "</td>" +

                            "<td colspan=2><b>Presión:</b> " + Presion.Text + "/" + Presion1.Text + "</td></tr>" +
                            "<tr><td colspan=2><b>Temperatura: </b>" + Temperatura.Text + "</td></tr>" +
                            "<TR><TD colspan=4><b>Resumen Exploración Física:</b> " + ResumenExploracion.Text + "</TD></TR>" +
                            "<TR><TD colspan=4><b>Diagnóstico:</b> " + autocompleteDiagnostico.Text + "</TD></TR>" +
                            "<TR><TD colspan=4><b>Plan de tratamiento:</b> " + PlanTratamiento.Text + "</TD></TR>" +
                            "<tr><TD colspan=2><b>Días de reposo: </b>" + DiasReposo.Text + "</TD><TD colspan=2><b>Tipo de usuario: </b>" + TipoDeConsulta.Text + "</TD></tr>" +
                            "</TABLE><br/><br/><br/><br/>";
            cadenaFinal += "<table border=1><tr><td>Especialista: " + usuariologeado.Nombre + " " + usuariologeado.Apellido + "</td><td>Firma</td></tr></table>";
            string nom = "RecetaMedica" + LabelNombreAlumno.Text;

            ImprimirPDF(cadenaFinal, nom);
        }
        public void ImprimirPDF(string cadenaFinal, string nom)
        {

            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

            try
            {
                PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

                //Open PDF Document to write data 
                pdfDoc.Open();




                cadenaFinal += "<h4> © Universidad Politécnica de Tulancingo.  Calle Ingenierías # 100. Col. Huapalcalco, Tulancingo, Hidalgo, México. C.P. 43629, Teléfono: 01(775) 75 5 82 02, Fax: 01(775) 75 5 83 21 </h5>";


                //Assign Html content in a string to write in PDF 
                string strContent = cadenaFinal;

                //Read string contents using stream reader and convert html to parsed conent 
                var parsedHtmlElements = HTMLWorker.ParseToList(new StringReader(strContent), null);

                //Get each array values from parsed elements and add to the PDF document 
                foreach (var htmlElement in parsedHtmlElements)
                    pdfDoc.Add(htmlElement as IElement);

                //Close your PDF 
                pdfDoc.Close();

                Response.ContentType = "application/pdf";

                //Set default file Name as current datetime 
                Response.AddHeader("content-disposition", "attachment; filename=" + nom + ".pdf");
                System.Web.HttpContext.Current.Response.Write(pdfDoc);


                Response.Flush();
                Response.End();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

        }
        protected void AgregarOdontograma_Click(object sender, EventArgs e)
        {
            WConsultaVista.InsertarOdontograma(15, NewConsulta);
            WConsultaVista.ListarOdontograma(14, miAlumno.alu_NumControl);    // llenado del odontograma

        }
        protected void ImprimirDental_Click(object sender, ImageClickEventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToShortDateString();
            string cadenaFinal = "";
            string path = Server.MapPath("/IMAG/universidad/encabezadoReseta.png");
            cadenaFinal += "<img src='" + path + "' Height='150' Width='500' />";
            cadenaFinal += "<br/><br/>";
            cadenaFinal += "<table colspan=2> <tr><td><b>Tipo de consulta:</b> " + usuariologeado.Especialidad_texto + "</td><td><b>Fecha:</b> " + fecha + "</td></tr> </table>";
            cadenaFinal += "<br/><br/>";
            cadenaFinal += "<table border='1'>";
            cadenaFinal += "<tr><td colspan=4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Datos del médico</b></td></tr>";
            //Tiene que llevar el nombre del médico                                                         Tiene que llevar el nombre del médico  
            cadenaFinal += "<tr><td colspan=2><b>Nombre:</b> " + usuariologeado.Nombre + " " + usuariologeado.Apellido + "<td colspan=2><b>Cédula profesional:</b> " + usuariologeado.Cedula + "</td></tr>";
            cadenaFinal += "</table>";
            cadenaFinal += "<br/><br/><br/>";
            cadenaFinal += "<TABLE BORDER='1'>" +
                "<div> <TR><TD colspan=4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <b>Datos del alumno</b> </TD></TR> </div>" +
                "<TR><TD colspan=2><b>Nombre:</b> " + LabelNombreAlumno.Text + "</TD><TD colspan=2><b>Matrícula:</b> " + LabelMatriculaAlumno.Text + "</TD></TR>" +
                            "<TR><TD colspan=2><b>Diente:</b> " + NumeroDiente.Text + "</TD></TR><tr><td colspan=2><b>Diagnóstico:"+DiagnosticoDiente.Text+"</b></td></tr>" +
                           

                            "<TR><TD colspan=4><b>Plan de tratamiento:</b> " + TratamientoDiente.Text + "</TD></TR>" +
                            "<TR><TD colspan=4><b>Comentario:</b> " + ComentarioDiente.Text + "</TD></TR>" +
                             "</TD><TD colspan=2><b>Tipo de usuario: </b>" + TipoDeConsulta.Text + "</TD></tr>" +
                            "</TABLE><br/><br/><br/><br/>";
            cadenaFinal += "<table border=1><tr><td>Especialista: " + usuariologeado.Nombre + " " + usuariologeado.Apellido + "</td><td>Firma</td></tr></table>";
            string nom = "RecetaMedica" + LabelNombreAlumno.Text;

            ImprimirPDF(cadenaFinal, nom);
        }
    }

}