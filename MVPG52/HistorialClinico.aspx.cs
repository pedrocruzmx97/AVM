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
    public partial class HistorialClinico : System.Web.UI.Page,ICuestionario
    {
        //Especialista
        CEspecialista usuariologeado;//Objeto donde se guarda los datos de sesion del especialista

        WCuestionario WmiCuestionario;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuariologeado = new CEspecialista();
            usuariologeado = (CEspecialista)Session["UsuarioLogeadoEspecialista"];  //Objeto donde esta los datos de sesion del especialista

            if (usuariologeado != null)
            {
                WmiCuestionario = new WCuestionario(this);




                


                if (!IsPostBack)
                {
                  
                }
            }
            else
            {
                Response.Redirect("/Sesion.aspx", true);
            }
        }

        #region ICuestionario
        public void Mensaje(string Mensaje, int tipo)
        {

        }
        public CCuestionario NewCuestionario
        {
            get
            {
                CCuestionario CmiCuestionario = new CCuestionario();
                return CmiCuestionario;
            }
            set
            {
                if (value != null)
                {

                }

            }
        }
        public DataSet ListadoCuestionario
        {
            set
            {
                if (value != null)
                {
                  
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

                if (d1.Text!="")
                {
                    PanelPreguntas.Visible = true;
                    PanelCuestionarioMensaje.Visible = false;
                }
                else{
                    PanelPreguntas.Visible = false;
                    PanelCuestionarioMensaje.Visible = true;
                }
            }
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
       
        #endregion
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                WmiCuestionario.ListarUsuarioHistorialClinico(7, txtId.Text);

                VistPDF(txtId.Text);
            }
            else {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Ingrese un id valido');", true);
            }
           
            
        }
        


        protected void Button2_Click(object sender, EventArgs e)
        {
            string cadenaFinal = "";
            string path = Server.MapPath("/IMAG/universidad/HMedico.png");
            cadenaFinal += "<img src='" + path + "' Height='150' Width='500' />";
            cadenaFinal += "<table colspan=2 border=2>";
            cadenaFinal += "<tr><td colspan=2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Historial Médico del alumno con la matrícula: <b>" + txtId.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>1.-Alimentación diaria: </b></td><td>" + m1.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>2.-Veces que realiza ejercicio por semana: </b></td><td>" + m2.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>3.-Tipo de sangre: </b></td><td>" + m3.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>4.-Frecuencia de consumo de bebidas alcóholicas: </b></td><td>" + m4.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>5.-Frecuencia de consumo de tabaco: </b></td><td>" + m5.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>6.-Consumo de drogas ilegales: </b></td><td>" + m6.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>7.-Padecimiento de alergias: </b></td><td>" + m7.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>8.-Enfermedades que padece: </b></td><td>" + m8.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>9.-Frecuencia con que se baña: </b></td><td>" + m9.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>10.-Tipo de baño que hay donde vive: </b></td><td>" + m10.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>11.- Vive en lugares con enfermedades como el Dengue,Paludismo,etce: </b></td><td>" + m11.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>12.-Está en tratamientos hormonales: </b></td><td>" + m12.Text + "</td><tr>";
            cadenaFinal += "<tr><td><b>13.-Toma anticonceptivos: </b></td><td>" + m13.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>14.-¿Alguna vez le practicaron cirugía?: </b></td><td>" + m14.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>15.-¿Le han practicado una transfusión sanguínea?: </b></td><td>" + m15.Text + "</td</tr>";
            cadenaFinal += "<tr>><td><b>16.-¿Está en contacto directo con pacientes diagnosticados con VIH o Tuberculosis?: </b></td><td>" + m16.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>17.-Estatura(cm): </b></td><td>" + m17.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>18.-Peso(kg): </b></td><td>" + m18.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>19.-Cálculo IMC: </b></td><td>" + m19.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>20.-¿Su regla es regular?: </b></td><td>" + m20.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>21.-¿Está embarazada?: </b></td><td>" + m21.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>22.-¿Está lactando?: </b></td><td>" + m22.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>23.-Enfermedades que padecieron los abuelos: </b></td><td>" + m24.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>24.-Enfermedades que padecieron los padres: </b></td><td>" + m16.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>25.-Enfermedades que padecieron los hermanos primos y tíos: </b></td><td>" + m25.Text + "</td></tr>";

            cadenaFinal += "</table>";

            cadenaFinal += "<br/><br/>";
            string nom = "HistorialMedico" + txtId.Text;
            ImprimirPDF(cadenaFinal, nom);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string cadenaFinal = "";
            string path = Server.MapPath("/IMAG/universidad/HDental.png");
            cadenaFinal += "<img src='" + path + "' Height='150' Width='500' />";
            cadenaFinal += "<table colspan=2 border=2>";
            cadenaFinal += "<tr><td colspan=2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Historial Dental del alumno con la matrícula: <b>" + txtId.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>1.-Última vez que acudió al dentista: </b></td><td>" + d1.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>2.-Motivo de su última consulta dental: </b></td><td>" + d2.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>3.-¿Cómo calificó su boca?: </b></td><td>" + d3.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>4.-¿Cuantas veces al día cepilla sus dientes?: </b></td><td>" + d4.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>5.-¿Le truena la mandíbula cuando abre mucho la boca?: </b></td><td>" + d5.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>6.-¿Le sangran las encias cuando se cepilla los dientes?: </b></td><td>" + d6.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>7.-¿Tiene dificultad para abrir la boca en algunas ocasiones?: </b></td><td>" + d7.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>8.-¿Se ha quedado alguna vez con la boca abierta y ha tenido incapacidad para cerrarla?: </b></td><td>" + d8.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>9.-¿Has tenido perforaciones en la boca (piercings)?: </b></td><td>" + d9.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>10.-¿Ha presentado mal aliento?: </b></td><td>" + d10.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>11.-¿Tienes el hábito de morderte las uñas, tallarte o morder objetos?: </b></td><td>" + d11.Text + "</td></tr>";


            cadenaFinal += "</table>";

            cadenaFinal += "<br/><br/>";
            string nom = "HistorialDental" + txtId.Text;
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
        protected void Button4_Click(object sender, EventArgs e)
        {
            string cadenaFinal = "";
            string path = Server.MapPath("/IMAG/universidad/HPsico.png");
            cadenaFinal += "<img src='" + path + "' Height='150' Width='500' />";
            cadenaFinal += "<table colspan=2 border=2>";
            cadenaFinal += "<tr><td colspan=2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Histotial Psicologico del alumno con la matrícula: <b>"+txtId.Text+"</b></td></tr>";
            cadenaFinal += "<tr><td><b>1.-¿La Universidad Politécnica de Tulancingo fue su primera opción?: </b></td><td>" + p1.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>2.-¿La carrera que eligió fue su primera opción?: </b></td><td>" + p2.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>3.-¿Qué tan satisfecho está con la elección de carrera?: </b></td><td>" + p3.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>4.-¿Sabe cuál es su perfil vocacional?: </b></td><td>" + p4.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>5.-¿Cómo es la relación con sus abuelos?: </b></td><td>" + p5.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>6.-¿Cómo es la relación con su mamá?: </b></td><td>" + p6.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>7.-¿Cómo es la relación con su papá?: </b></td><td>" + p7.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>8.-¿Cómo es la relación con sus hermanos?: </b></td><td>" + p8.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>9.-¿Cuál es el acontecimiento más relevante de su infancia?: </b></td><td>" + p9.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>10.-¿Cuál es el acontecimiento más relevante de su adolesencia?: </b></td><td>" + p10.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>11.-¿Cómo es su autoestima?: </b></td><td>" + p11.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>12.-¿Cómo considera su capacidad para relacionarse con otras personas?: </b></td><td>" + p12.Text + "</td><tr>";
            cadenaFinal += "<tr><td><b>13.-¿Tiene algún proyecto de vida?s: </b></td><td>" + p13.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>14.-¿Le gustaría recibir orientación psicológica?: </b></td><td>" + p14.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>15.-¿Número de hijo que es?: </b></td><td>" + p15.Text + "</td</tr>";
            cadenaFinal += "<tr><td><b>16.-¿Con quién vive actualmente?: </b></td><td>" + p16.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>17.-¿Cuales son sus preferencias sexuales?: </b></td><td>" + p17.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>18.-¿Ha asistido a terapia psicológica?: </b></td><td>" + p18.Text + "</td></tr>";
            cadenaFinal += "<tr><td><b>19.-¿Cuantas horas duermes diariamente?: </b></td><td>" + p19.Text + "</td></tr>";

            cadenaFinal += "</table>";

            cadenaFinal += "<br/><br/>";
            string nom = "HistorialPsicológico" + txtId.Text;
            ImprimirPDF(cadenaFinal, nom);
        }

        protected void VistPDF(string id)
        {
            string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"800px\" height=\"700px\">";
            embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            embed += "</object>";
            ltEmbed.Text = string.Format(embed, ResolveUrl("~/Files/"+id+".pdf"));
        }
    }
}