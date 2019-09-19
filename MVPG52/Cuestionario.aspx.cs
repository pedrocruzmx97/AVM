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


using System.IO;
using System.IO.MemoryMappedFiles;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace MVPG52
{
    public partial class Cuestionario : System.Web.UI.Page, ICuestionario, IAlumno
    {
        CAlumno objLoggerinf; //Datos de sesion

        WCuestionario WmiCuestionario;

        WAlumno WmiAlumno;

        Panel PanelCues=new Panel();

        private string folio = "";

        List<CCuestionario> listaDatos = new List<CCuestionario>(); //Lista para almacenar los datos de las listas ccuestionario
        protected void Page_Load(object sender, EventArgs e)
        {

            PanelCuestionarnio.Visible = PanelCues.Visible;

            objLoggerinf = new CAlumno();

            WmiCuestionario = new WCuestionario(this);
            WmiAlumno = new WAlumno(this);

            objLoggerinf = (CAlumno)Session["UsuarioLogeado"];


            if (objLoggerinf != null && objLoggerinf.alu_Rol==1) //se valida el objeto y el rol para asegurar si identidad
            {
                if (!IsPostBack)
                {
                    if (objLoggerinf.alu_Sexo == "M")
                    {
                        PanelPreguntasMujer.Visible = false;
                    }
                 
                    LlenadoComboGenerico(pre3, 10);                 // listado de sangre
                    LlenadoComboGenerico(DropDownListPM7, 11);      // listado de alerguas
                    LlenadoComboGenerico(DropDownListPM8, 12);      //listado de enfermedades
                    LlenadoComboGenerico(DropDownListpre14Res1, 13);//Listado de cirujias
                    LlenadoComboGenerico(DropDownListpre13Res1, 14);//Listado de anticonceptivo
                                                                    //Desactivar paneles

                    //Hacer visible el cuestionarnio
                    /*
                     1 los cuestionarnios e1 e2 e3 estan en 0
                     2 al aceptar los terminos e123 =10 ya puede llenar los cuestionarios
                     3 se llenaron los 3 cuestionarnios e1=1 e2=1 e3=1
                     4 cuando e123=1 se desactica cuestionarnio y subir archivo y se activa acuse
                     */


                    //Se aceptan los terminos y condiciones
                    if (objLoggerinf.alu_E1 ==0 && objLoggerinf.alu_E2 == 0 && objLoggerinf.alu_E3 == 0)
                    {                       
                        PanelCuestionarnio.Visible = false;
                        PanelAviso.Visible = true;
                    }
                    else
                    {
                        PanelCuestionarnio.Visible = true;
                        PanelAviso.Visible = false;
                    }

                    //Panel médico
                    if (objLoggerinf.alu_E1 == 10 )
                    {
                        PanelMedico.Visible = true;
                        PanelAvisoMedico.Visible = false;
                    }
                    else
                    {
                        PanelMedico.Visible = false;
                        PanelAvisoMedico.Visible = true;


                    }
                    //Panel denatal
                    if (objLoggerinf.alu_E2 == 10 )
                    {
                        PanelDentista.Visible = true;
                        PanelAvisoDental.Visible = false;
                    }
                    else
                    {
                        PanelDentista.Visible = false;
                        PanelAvisoDental.Visible = true;

                    }
                    //Panel psicologico
                    if (objLoggerinf.alu_E3 == 10)
                    {
                        PanelPsicologo.Visible = true;
                        PanelAvisoPsicologo.Visible = false;
                    }
                    else
                    {
                        PanelPsicologo.Visible = false;
                        PanelAvisoPsicologo.Visible = true;
                    }


                    //Activacion de acuse
                    if (objLoggerinf.alu_E1 == 1 && objLoggerinf.alu_E2 == 1 && objLoggerinf.alu_E3 == 1)
                    {
                        PanelAcuse.Visible = true;
                    }
                    else
                    {
                        PanelAcuse.Visible = false;
                    }



                    //Pregunta de opcion multiple 
                    if (pre14Res1.Checked == true)
                    {
                        Panelpre14Res1.Visible = true;
                    }
                    else
                    {
                        Panelpre14Res1.Visible = false;
                    }

                }
            }
            else
            {
                Response.Redirect("/Sesion.aspx", true);// no direcciona a la pagina default de la master

            }

        }

        #region Metodos de guardar consuta
        private void EstadoDeBotones(bool Estatus) {
            ButtonAgregarDental.Enabled = Estatus;
            ButtonAgregarMedico.Enabled = Estatus;
            ButtonAgregarPsicologo.Enabled = Estatus;
      
        }
        protected void ButtonAgregarDental_Click(object sender, EventArgs e)
        {
            bool Estado = true;
            if (!pre1ResD1.Checked && !pre1ResD2.Checked && !pre1ResD3.Checked && !pre1ResD4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 1');", true);
                Estado = false;
                goto final;
            }
            if (!pre2ResD1.Checked && !pre2ResD2.Checked && !pre2ResD3.Checked && !pre2ResD4.Checked && !pre2ResD5.Checked && !pre2ResD6.Checked && !pre2ResD7.Checked && !pre2ResD8.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 2');", true);
                Estado = false;
                goto final;
            }
            if (!pre3ResD1.Checked && !pre3ResD2.Checked && !pre3ResD3.Checked && !pre3ResD4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 3');", true);
                Estado = false;
                goto final;
            }
            if (!pre4ResD1.Checked && !pre4ResD2.Checked && !pre4ResD3.Checked && !pre4ResD4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 4');", true);
                Estado = false;
                goto final;
            }

            final:
            //Proceso de reguisto
            if (Estado)
            {
                WmiCuestionario.ReguistrarCuestionario(NewCuestionarioDental, 1);
                //Se actulizan datos
                WmiAlumno.ActualizarDatosDeAlumno(UsuarioActulizar);

                Session.Clear();// limpiamos la sesion
                Session.Add("UsuarioLogeado", objLoggerinf);
                Response.Redirect("Cuestionario.aspx");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Reguistro exitoso');", true);

            }
        }
        protected void ButtonAgregarMedico_Click(object sender, EventArgs e)
        {
            bool Estado = true;

            if (!pre1Res1.Checked && !pre1Res2.Checked && !pre1Res3.Checked && !pre1Res4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 1');", true);
                Estado = false;
                goto final;
            }

            if (!pre2Res1.Checked && !pre2Res2.Checked && !pre2Res3.Checked && !pre2Res4.Checked && !pre2Res5.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 2');", true);
                Estado = false;
                goto final;
            }
            if (pre3.Text == "Seleccione")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 3');", true);
                Estado = false;
                goto final;
            }


            if (!pre4Res1.Checked && !pre4Res2.Checked && !pre4Res3.Checked && !pre4Res4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 4');", true);
                Estado = false;
                goto final;
            }
            if (!pre5Res1.Checked && !pre5Res2.Checked && !pre5Res3.Checked && !pre5Res4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 5');", true);
                Estado = false;
                goto final;
            }
            if (!pre6Res1.Checked && !pre6Res2.Checked && !pre6Res3.Checked && !pre6Res4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 6');", true);
                Estado = false;
                goto final;
            }
            if (pre7Res1.Checked && DropDownListPM7.Text == "Seleccione")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 7');", true);
                Estado = false;
                goto final;
            }
            ///8
            ///
            ///9
            ///
            if (!pre9Res1.Checked && !pre9Res2.Checked && !pre9Res3.Checked && !pre9Res4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 9');", true);
                Estado = false;
                goto final;
            }
            if (!pre10Res1.Checked && !pre10Res2.Checked && !pre10Res3.Checked && !pre10Res4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 10');", true);
                Estado = false;
                goto final;
            }
            if (pre17Res1.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 17');", true);
                Estado = false;
                goto final;
            }
            if (pre18Res1.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 18');", true);
                Estado = false;
                goto final;
            }
            if (!pre23Res1.Checked && !pre23Res2.Checked && !pre23Res3.Checked && !pre23Res4.Checked && !pre23Res5.Checked && !pre23Res6.Checked && !pre23Res7.Checked && !pre23Res8.Checked && !pre23Res9.Checked && !pre23Res10.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 22');", true);
                Estado = false;
                goto final;
            }
            if (!pre24Res1.Checked && !pre24Res2.Checked && !pre24Res3.Checked && !pre24Res4.Checked && !pre24Res5.Checked && !pre24Res6.Checked && !pre24Res7.Checked && !pre24Res8.Checked && !pre24Res9.Checked && !pre24Res10.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 23');", true);
                Estado = false;
                goto final;
            }
            if (!pre25Res1.Checked && !pre25Res2.Checked && !pre25Res3.Checked && !pre25Res4.Checked && !pre25Res5.Checked && !pre25Res6.Checked && !pre25Res7.Checked && !pre25Res8.Checked && !pre25Res9.Checked && !pre25Res10.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 24');", true);
                Estado = false;
                goto final;
            }
            final:
            //Proceso de reguisto
            if (Estado)
            {
                WmiCuestionario.ReguistrarCuestionario(NewCuestionarioMedico, 2);
                //Se actulizan datos
                WmiAlumno.ActualizarDatosDeAlumno(UsuarioActulizar);
                Session.Clear();// limpiamos la sesion
                Session.Add("UsuarioLogeado", objLoggerinf);
                Response.Redirect("Cuestionario.aspx");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Reguistro exitoso');", true);

            }
        }
        protected void ButtonAgregarPsicologo_Click(object sender, EventArgs e)
        {
            bool Estado = true;
            if (!res3p1.Checked && !res3p2.Checked && !res3p3.Checked && !res3p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 3');", true);
                Estado = false;
                goto final;
            }
            if (!res5p1.Checked && !res5p2.Checked && !res5p3.Checked && !res5p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 5');", true);
                Estado = false;
                goto final;
            }
            if (!res6p1.Checked && !res6p2.Checked && !res6p3.Checked && !res6p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 6');", true);
                Estado = false;
                goto final;
            }
            if (!res7p1.Checked && !res7p2.Checked && !res7p3.Checked && !res7p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 7');", true);
                Estado = false;
                goto final;
            }
            if (!res8p1.Checked && !res8p2.Checked && !res8p3.Checked && !res8p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 8');", true);
                Estado = false;
                goto final;
            }
            if ((!res9p1.Checked && !res9p2.Checked && !res9p3.Checked && !res9p4.Checked && !res9p5.Checked && !res9p6.Checked && !res9p7.Checked && !res9p8.Checked && !res9p9.Checked && !res9p10.Checked && !res9p11.Checked && !res9p12.Checked && !res9p13.Checked && !res9p14.Checked)  )
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 9');", true);
                Estado = false;
                goto final;
            }

            if (!res10p1.Checked && !res10p2.Checked && !res10p3.Checked && !res10p4.Checked && !res10p5.Checked && !res10p6.Checked && !res10p7.Checked && !res10p8.Checked && !res10p9.Checked && !res10p10.Checked && !res10p11.Checked && !res10p12.Checked && !res10p13.Checked && !res10p14.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 10');", true);
                Estado = false;
                goto final;
            }
            if (!res11p1.Checked && !res11p2.Checked && !res11p3.Checked && !res11p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 11');", true);
                Estado = false;
                goto final;
            }
            if (!res12p1.Checked && !res12p2.Checked && !res12p3.Checked && !res12p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 12');", true);
                Estado = false;
                goto final;
            }
            if (!res15p1.Checked && !res15p2.Checked && !res15p3.Checked && !res15p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 15');", true);
                Estado = false;
                goto final;
            }
            if (!res16p1.Checked && !res16p2.Checked && !res16p3.Checked && !res16p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 16');", true);
                Estado = false;
                goto final;
            }
            if (!res17p1.Checked && !res17p2.Checked && !res17p3.Checked && !res17p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 17');", true);
                Estado = false;
                goto final;
            }
            if (!res19p1.Checked && !res19p2.Checked && !res19p3.Checked && !res19p4.Checked)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Pregunta 19');", true);
                Estado = false;
                goto final;
            }
            final:
            //Proceso de reguisto
            if (Estado)
            {
                WmiCuestionario.ReguistrarCuestionario(NewCuestionarioPsicologico, 3);
                //Se actulizan datos
                WmiAlumno.ActualizarDatosDeAlumno(UsuarioActulizar);
                Session.Clear();// limpiamos la sesion
                Session.Add("UsuarioLogeado", objLoggerinf);
               Response.Redirect("Cuestionario.aspx");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "alert('Reguistro exitoso');", true);

            }
        }
        #endregion

        #region IdCuestionario
        public void Mensaje(string Mensaje, int tipo)
        {
        }
        public CCuestionario NewCuestionarioDental
        {
            get
            {
                CCuestionario CmiCuestionario = new CCuestionario();
                CmiCuestionario.fk_alumno = objLoggerinf.alu_NumControl;
                ////DENTISTA-------------------------------------------------------------------------
                //P1 Dentista
                if (pre1ResD1.Checked)
                    CmiCuestionario.fk_tbl_g1 = 1;
                if (pre1ResD2.Checked)
                    CmiCuestionario.fk_tbl_g1 = 2;
                if (pre1ResD3.Checked)
                    CmiCuestionario.fk_tbl_g1 = 3;
                if (pre1ResD4.Checked)
                    CmiCuestionario.fk_tbl_g1 = 4;

                //P2 Dentista
                if (pre2ResD1.Checked)
                    CmiCuestionario.p2dDiagnostoco = 1;
                else CmiCuestionario.p2dDiagnostoco = 0;

                if (pre2ResD2.Checked)
                    CmiCuestionario.p2dCaries = 1;
                else CmiCuestionario.p2dCaries = 0;


                if (pre2ResD3.Checked)
                    CmiCuestionario.p2dProfiliaxis = 1;
                else CmiCuestionario.p2dProfiliaxis = 0;


                if (pre2ResD4.Checked)
                    CmiCuestionario.p2dDolorDeMuelas =1;
                else CmiCuestionario.p2dDolorDeMuelas = 0;


                if (pre2ResD5.Checked)
                    CmiCuestionario.p2dGingivitis =1;
                else CmiCuestionario.p2dGingivitis = 0;


                if (pre2ResD6.Checked)
                    CmiCuestionario.p2dTratamientos =1;
                else CmiCuestionario.p2dTratamientos = 0;


                if (pre2ResD7.Checked)
                    CmiCuestionario.p2dEdolencias =1;
                else CmiCuestionario.p2dEdolencias = 0;


                if (pre2ResD8.Checked)
                    CmiCuestionario.p2dNinguno =1;
                else CmiCuestionario.p2dNinguno = 0;


                //P3 Dentista
                if (pre3ResD1.Checked)
                    CmiCuestionario.fk_tbl_g2 = 1;
                if (pre3ResD2.Checked)
                    CmiCuestionario.fk_tbl_g2 = 2;
                if (pre3ResD3.Checked)
                    CmiCuestionario.fk_tbl_g2 = 3;
                if (pre3ResD4.Checked)
                    CmiCuestionario.fk_tbl_g2 = 4;

                //P4 Dentista
                if (pre4ResD1.Checked)
                {
                    CmiCuestionario.fk_tbl_g3 = 1;

                }
                if (pre4ResD2.Checked)
                {
                    CmiCuestionario.fk_tbl_g3 = 2;

                }
                if (pre4ResD3.Checked)
                {
                    CmiCuestionario.fk_tbl_g3 = 3;

                }
                if (pre4ResD4.Checked)
                {
                    CmiCuestionario.fk_tbl_g3 = 4;

                }
                //P5 Dentista
                if (pre5ResD1.Checked)
                {
                    CmiCuestionario.pd5 = 1;

                }
                else
                {
                    CmiCuestionario.pd5 = 0;
                }

                //P6 Dentista
                if (pre6ResD1.Checked)
                {
                    CmiCuestionario.pd6 = 1;

                }
                else
                {
                    CmiCuestionario.pd6 = 0;
                }
                //P7 Dentista
                if (pre7ResD1.Checked)
                {
                    CmiCuestionario.pd7 = 1;

                }
                else
                {
                    CmiCuestionario.pd7 = 0;
                }

                //P8 Dentista
                if (pre8ResD1.Checked)
                {
                    CmiCuestionario.pd8 = 1;

                }
                else
                {
                    CmiCuestionario.pd8 = 0;
                }
                //P9 Dentista
                if (pre9ResD1.Checked)
                {
                    CmiCuestionario.pd9 = 1;

                }
                else
                {
                    CmiCuestionario.pd9 = 0;
                }
                //P10 Dentista
                if (pre10ResD1.Checked)
                {
                    CmiCuestionario.pd10 = 1;

                }
                else
                {
                    CmiCuestionario.pd10 = 0;
                }
                //P11 Dentista
                if (pre11ResD1.Checked)
                {
                    CmiCuestionario.pd11 = 1;

                }
                else
                {
                    CmiCuestionario.pd11 = 0;
                }
                return CmiCuestionario;
            }
        }

        public CCuestionario NewCuestionarioMedico
        {
            get
            {
                CCuestionario CmiCuestionario = new CCuestionario();
                CmiCuestionario.fk_alumno = objLoggerinf.alu_NumControl;
                //P1Medico
                if (pre1Res1.Checked)
                {
                    CmiCuestionario.fk_tbl_g4 = 1;

                }
                if (pre1Res2.Checked)
                {
                    CmiCuestionario.fk_tbl_g4 = 2;

                }
                if (pre1Res3.Checked)
                {
                    CmiCuestionario.fk_tbl_g4 = 3;

                }
                if (pre1Res4.Checked)
                {
                    CmiCuestionario.fk_tbl_g4 = 4;

                }
                //P2 Medico
                if (pre2Res1.Checked)
                {
                    CmiCuestionario.fk_tbl_g5 = 1;

                }
                if (pre2Res2.Checked)
                {
                    CmiCuestionario.fk_tbl_g5 = 2;

                }
                if (pre2Res3.Checked)
                {
                    CmiCuestionario.fk_tbl_g5 = 3;

                }
                if (pre2Res4.Checked)
                {
                    CmiCuestionario.fk_tbl_g5 = 4;
                }
                if (pre2Res5.Checked)
                {
                    CmiCuestionario.fk_tbl_g5 = 5;
                }
                //P3 Medico

                CmiCuestionario.fk_tbl_g6 = Convert.ToInt32(pre3.SelectedValue);
                //P4 Medico
                if (pre4Res1.Checked)
                {
                    CmiCuestionario.fk_tbl_g7 = 1;

                }
                if (pre4Res2.Checked)
                {
                    CmiCuestionario.fk_tbl_g7 = 2;

                }
                if (pre4Res3.Checked)
                {
                    CmiCuestionario.fk_tbl_g7 = 3;

                }
                if (pre4Res4.Checked)
                {
                    CmiCuestionario.fk_tbl_g7 = 4;

                }

                //P5 Medico
                if (pre5Res1.Checked)
                {
                    CmiCuestionario.fk_tbl_g8 = 1;

                }
                if (pre5Res2.Checked)
                {
                    CmiCuestionario.fk_tbl_g8 = 2;

                }
                if (pre5Res3.Checked)
                {
                    CmiCuestionario.fk_tbl_g8 = 3;

                }
                if (pre5Res4.Checked)
                {
                    CmiCuestionario.fk_tbl_g8 = 4;

                }
                //P6 Medico
                if (pre6Res1.Checked)
                {
                    CmiCuestionario.fk_tbl_g9 = 1;

                }
                if (pre6Res2.Checked)
                {
                    CmiCuestionario.fk_tbl_g9 = 2;

                }
                if (pre6Res3.Checked)
                {
                    CmiCuestionario.fk_tbl_g9 = 3;

                }
                if (pre6Res4.Checked)
                {
                    CmiCuestionario.fk_tbl_g9 = 4;

                }
                //P7 Medico
                if (pre7Res1.Checked)
                {
                    CmiCuestionario.pm7 = DropDownListPM7.SelectedValue;
                }
                else
                {

                    CmiCuestionario.pm7 = "0";

                }


                //P8 FALTA---------------------------------------------
                if (pre8Res1.Checked)
                {
                    CmiCuestionario.fk_enferdad = Convert.ToInt32(DropDownListPM8.SelectedValue);

                }
                else {
                    CmiCuestionario.fk_enferdad = 0;
                }


                //P9 Medico
                if (pre9Res1.Checked)
                {
                    CmiCuestionario.fk_tbl_g11 = 1;

                }
                if (pre9Res2.Checked)
                {
                    CmiCuestionario.fk_tbl_g11 = 2;

                }
                if (pre9Res3.Checked)
                {
                    CmiCuestionario.fk_tbl_g11 = 3;

                }
                if (pre9Res4.Checked)
                {
                    CmiCuestionario.fk_tbl_g11 = 4;

                }
                //P10 Medico
                if (pre10Res1.Checked)
                {
                    CmiCuestionario.fk_tbl_g12 = 1;

                }
                if (pre10Res2.Checked)
                {
                    CmiCuestionario.fk_tbl_g12 = 2;

                }
                if (pre10Res3.Checked)
                {
                    CmiCuestionario.fk_tbl_g12 = 3;

                }
                if (pre10Res4.Checked)
                {
                    CmiCuestionario.fk_tbl_g12 = 4;

                }

                //P11 Medico
                if (pre11Res1.Checked)
                {
                    CmiCuestionario.pm11 = 1;

                }
                else
                {
                    CmiCuestionario.pm11 = 0;
                }
                //P12 Medico
                if (pre12Res1.Checked)
                {
                    CmiCuestionario.pm12 = 1;

                }
                else
                {
                    CmiCuestionario.pm12 = 0;
                }
                //P13 Medico
                if (pre13Res1.Checked)
                {
                    CmiCuestionario.pm13 = Convert.ToInt32(DropDownListpre13Res1.SelectedValue);

                }
                else
                {
                    CmiCuestionario.pm13 = 0;
                }
                //P14 Medico
                if (pre14Res1.Checked)
                {
                    CmiCuestionario.pm14 = Convert.ToInt32(DropDownListpre14Res1.SelectedValue);

                }
                else
                {
                    CmiCuestionario.pm14 = 0;
                }
                //P15 Medico
                if (pre15Res1.Checked)
                {
                    CmiCuestionario.pm15 = 1;

                }
                else
                {
                    CmiCuestionario.pm15 = 0;
                }
                //P16 Medico
                if (pre16Res1.Checked)
                {
                    CmiCuestionario.pm16 = 1;

                }
                else
                {
                    CmiCuestionario.pm16 = 0;
                }
                //P17 Medico
                CmiCuestionario.pm17 = float.Parse(pre17Res1.Text);
                //P18 Medico
                CmiCuestionario.pm18 = float.Parse(pre18Res1.Text);
                //p19Calculo
                CmiCuestionario.pm19 = CmiCuestionario.pm18 / CmiCuestionario.pm17;
                //P20 Medico
                if (pre20Res1.Checked)
                {
                    CmiCuestionario.pm20 = 1;

                }
                else
                {
                    CmiCuestionario.pm20 = 0;
                }
                //P21 Medico
                if (pre21Res1.Checked)
                {
                    CmiCuestionario.pm21 = 1;

                }
                else
                {
                    CmiCuestionario.pm21 = 0;
                }
                //P22 Medico
                if (pre22Res1.Checked)
                {
                    CmiCuestionario.pm22 = 1;

                }
                else
                {
                    CmiCuestionario.pm22 = 0;
                }


                //P23 Medico
                if (pre23Res1.Checked)
                {
                    CmiCuestionario.pm23DIABETES_MELLITUS = 1;

                }
                if (pre23Res2.Checked)
                {
                    CmiCuestionario.pm23HIPERTENSION_ARTERIAL = 1;

                }
                if (pre23Res3.Checked)
                {
                    CmiCuestionario.pm23CARDIOPATIAS = 1;

                }
                if (pre23Res4.Checked)
                {
                    CmiCuestionario.pm23CANCER = 1;

                }
                if (pre23Res5.Checked)
                {
                    CmiCuestionario.pm23EPILEPSIA = 1;

                }
                if (pre23Res6.Checked)
                {
                    CmiCuestionario.pm23ENFERMEDADES_AUTOINMUNES = 1;

                }
                if (pre23Res7.Checked)
                {
                    CmiCuestionario.pm23ENFERMEDADES_PSIQUIÁTRICAS = 1;

                }
                if (pre23Res8.Checked)
                {
                    CmiCuestionario.pm23ENFERMEDADES_SANGRE = 1;

                }
                if (pre23Res9.Checked)
                {
                    CmiCuestionario.pm23NOSE = 1;

                }

                if (pre23Res10.Checked)
                {
                    CmiCuestionario.pm23Ninguno = 1;

                }

                //P24 Medico
                if (pre24Res1.Checked)
                {
                    CmiCuestionario.pm24DIABETES_MELLITUS = 1;

                }
                if (pre24Res2.Checked)
                {
                    CmiCuestionario.pm24HIPERTENSION_ARTERIAL = 1;

                }
                if (pre24Res3.Checked)
                {
                    CmiCuestionario.pm24CARDIOPATIAS = 1;

                }
                if (pre24Res4.Checked)
                {
                    CmiCuestionario.pm24CANCER = 1;

                }
                if (pre24Res5.Checked)
                {
                    CmiCuestionario.pm24EPILEPSIA = 1;

                }
                if (pre24Res6.Checked)
                {
                    CmiCuestionario.pm24ENFERMEDADES_AUTOINMUNES = 1;

                }
                if (pre24Res7.Checked)
                {
                    CmiCuestionario.pm24ENFERMEDADES_PSIQUIÁTRICAS = 1;

                }
                if (pre24Res8.Checked)
                {
                    CmiCuestionario.pm24ENFERMEDADES_SANGRE = 1;

                }
                if (pre24Res9.Checked)
                {
                    CmiCuestionario.pm24NOSE = 1;
                }
                if (pre24Res10.Checked)
                {
                    CmiCuestionario.pm24Ninguno = 1;
                }
                //P25 Medico
                if (pre25Res1.Checked)
                {
                    CmiCuestionario.pm25DIABETES_MELLITUS = 1;

                }
                if (pre25Res2.Checked)
                {
                    CmiCuestionario.pm25HIPERTENSION_ARTERIAL = 1;

                }
                if (pre25Res3.Checked)
                {
                    CmiCuestionario.pm25CARDIOPATIAS = 1;

                }
                if (pre25Res4.Checked)
                {
                    CmiCuestionario.pm25CANCER = 1;

                }
                if (pre25Res5.Checked)
                {
                    CmiCuestionario.pm25EPILEPSIA = 1;

                }
                if (pre25Res6.Checked)
                {
                    CmiCuestionario.pm25ENFERMEDADES_AUTOINMUNES = 1;

                }
                if (pre25Res7.Checked)
                {
                    CmiCuestionario.pm25ENFERMEDADES_PSIQUIÁTRICAS = 1;

                }
                if (pre25Res8.Checked)
                {
                    CmiCuestionario.pm25ENFERMEDADES_SANGRE = 1;

                }
                if (pre25Res9.Checked)
                {
                    CmiCuestionario.pm25NOSE = 1;

                }
                if (pre25Res10.Checked)
                {
                    CmiCuestionario.pm25Ninguno = 1;

                }
                return CmiCuestionario;
            }
        }

        public CCuestionario NewCuestionarioPsicologico
        {
            get
            {
                CCuestionario CmiCuestionario = new CCuestionario();
                if (pre11ResP1.Checked)
                {
                    CmiCuestionario.pp1 = 1;

                }
                else
                {
                    CmiCuestionario.pp1 = 0;
                }
                // P2 psicologo
                if (pre2p.Checked)
                {
                    CmiCuestionario.pp2 = 1;

                }
                else
                {
                    CmiCuestionario.pp2 = 0;
                }
                //P3 Psicologo
                if (res3p1.Checked)
                {
                    CmiCuestionario.fk_tbl_g13 = 1;

                }
                if (res3p2.Checked)
                {
                    CmiCuestionario.fk_tbl_g13 = 2;

                }
                if (res3p3.Checked)
                {
                    CmiCuestionario.fk_tbl_g13 = 3;

                }
                if (res3p4.Checked)
                {
                    CmiCuestionario.fk_tbl_g13 = 4;

                }
                // P4 psicologo
                if (res4p.Checked)
                {
                    CmiCuestionario.pp4 = 1;

                }
                else
                {
                    CmiCuestionario.pp4 = 0;
                }
                //P5 Psicologo
                if (res5p1.Checked)
                {
                    CmiCuestionario.tbl_g14_5 = 1;

                }
                if (res5p2.Checked)
                {
                    CmiCuestionario.tbl_g14_5 = 2;

                }
                if (res5p3.Checked)
                {
                    CmiCuestionario.tbl_g14_5 = 3;

                }
                if (res5p4.Checked)
                {
                    CmiCuestionario.tbl_g14_5 = 4;

                }
                //P6 Psicologo
                if (res6p1.Checked)
                {
                    CmiCuestionario.tbl_g14_6 = 1;

                }
                if (res6p2.Checked)
                {
                    CmiCuestionario.tbl_g14_6 = 2;

                }
                if (res6p3.Checked)
                {
                    CmiCuestionario.tbl_g14_6 = 3;

                }
                if (res6p4.Checked)
                {
                    CmiCuestionario.tbl_g14_6 = 4;

                }
                //P7 Psicologo
                if (res7p1.Checked)
                {
                    CmiCuestionario.tbl_g14_7 = 1;

                }
                if (res7p2.Checked)
                {
                    CmiCuestionario.tbl_g14_7 = 2;

                }
                if (res7p3.Checked)
                {
                    CmiCuestionario.tbl_g14_7 = 3;

                }
                if (res7p4.Checked)
                {
                    CmiCuestionario.tbl_g14_7 = 4;

                }

                //P7 Psicologo
                if (res8p1.Checked)
                {
                    CmiCuestionario.tbl_g14_8 = 1;

                }
                if (res8p2.Checked)
                {
                    CmiCuestionario.tbl_g14_8 = 2;

                }
                if (res8p3.Checked)
                {
                    CmiCuestionario.tbl_g14_8 = 3;

                }
                if (res8p4.Checked)
                {
                    CmiCuestionario.tbl_g14_8 = 4;

                }
                //P9 Psicologo
                if (res9p1.Checked)
                {
                    CmiCuestionario.pp9DivorcioPadres = 1;

                }
                if (res9p2.Checked)
                {
                    CmiCuestionario.pp9NacimmientoHermano = 1;

                }
                if (res9p3.Checked)
                {
                    CmiCuestionario.pp9FallecimientoAbuelo = 1;

                }
                if (res9p4.Checked)
                {
                    CmiCuestionario.pp9FallecimientoPadres = 1;

                }
                if (res9p5.Checked)
                {
                    CmiCuestionario.pp9FallecimientoHermanos = 1;

                }
                if (res9p6.Checked)
                {
                    CmiCuestionario.pp9FallecimientoFamiliar = 1;

                }
                if (res9p7.Checked)
                {
                    CmiCuestionario.pp9AusenciaDePadre = 1;

                }
                if (res9p8.Checked)
                {
                    CmiCuestionario.pp9AusenciaDeMadre = 1;

                }
                if (res9p9.Checked)
                {
                    CmiCuestionario.pp9CambioDeDomicilio = 1;

                }
                if (res9p10.Checked)
                {
                    CmiCuestionario.pp9ViolenciaFamiliar = 1;

                }
                if (res9p11.Checked)
                {
                    CmiCuestionario.pp9AbusoSexual = 1;

                }
                if (res9p12.Checked)
                {
                    CmiCuestionario.pp9VictimaBullying = 1;

                }
                if (res9p13.Checked)
                {
                    CmiCuestionario.pp9Ninguno = 1;

                }
            
                //P10 Psicologo
                if (res10p1.Checked)
                {
                    CmiCuestionario.pp10DivorcioPadres = 1;

                }
                if (res10p2.Checked)
                {
                    CmiCuestionario.pp10NacimmientoHermano = 1;

                }
                if (res10p3.Checked)
                {
                    CmiCuestionario.pp10FallecimientoAbuelo = 1;

                }
                if (res10p4.Checked)
                {
                    CmiCuestionario.pp10FallecimientoPadres = 1;

                }
                if (res10p5.Checked)
                {
                    CmiCuestionario.pp10FallecimientoHermanos = 1;

                }
                if (res10p6.Checked)
                {
                    CmiCuestionario.pp10FallecimientoFamiliar = 1;

                }
                if (res10p7.Checked)
                {
                    CmiCuestionario.pp10AusenciaDePadre = 1;

                }
                if (res10p8.Checked)
                {
                    CmiCuestionario.pp10AusenciaDeMadre = 1;

                }
                if (res10p9.Checked)
                {
                    CmiCuestionario.pp10CambioDeDomicilio = 1;

                }
                if (res10p10.Checked)
                {
                    CmiCuestionario.pp10ViolenciaFamiliar = 1;

                }
                if (res10p11.Checked)
                {
                    CmiCuestionario.pp10AbusoSexual = 1;

                }
                if (res10p12.Checked)
                {
                    CmiCuestionario.pp10VictimaBullying = 1;

                }
                if (res10p13.Checked)
                {
                    CmiCuestionario.pp10Ninguno = 1;

                }
                //P11 Psicologo
                if (res11p1.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_1 = 1;

                }
                if (res11p2.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_1 = 2;

                }
                if (res11p3.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_1 = 3;

                }
                if (res11p4.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_1 = 4;

                }
                //P12 Psicologo
                if (res12p1.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_2 = 1;

                }
                if (res12p2.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_2 = 2;

                }
                if (res12p3.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_2 = 3;

                }
                if (res12p4.Checked)
                {
                    CmiCuestionario.fk_tbl_g15_2 = 4;

                }
                //P13 psicologo
                if (res13p1.Checked)
                {
                    CmiCuestionario.pp13 = 1;

                }
                else
                {
                    CmiCuestionario.pp13 = 0;
                }
                //P14 psicologo
                if (res14p1.Checked)
                {
                    CmiCuestionario.pp14 = 1;

                }
                else
                {
                    CmiCuestionario.pp14 = 0;
                }
                //P15 Psicologo
                if (res15p1.Checked)
                {
                    CmiCuestionario.fk_tbl_g16 = 1;

                }
                if (res15p2.Checked)
                {
                    CmiCuestionario.fk_tbl_g16 = 2;

                }
                if (res15p3.Checked)
                {
                    CmiCuestionario.fk_tbl_g16 = 3;

                }
                if (res15p4.Checked)
                {
                    CmiCuestionario.fk_tbl_g16 = 4;

                }

                //P16 Psicologo
                if (res16p1.Checked)
                {
                    CmiCuestionario.fk_tbl_g17 = 1;

                }
                if (res16p2.Checked)
                {
                    CmiCuestionario.fk_tbl_g17 = 2;

                }
                if (res16p3.Checked)
                {
                    CmiCuestionario.fk_tbl_g17 = 3;

                }
                if (res16p4.Checked)
                {
                    CmiCuestionario.fk_tbl_g17 = 4;

                }
                //P17 Psicologo
                if (res17p1.Checked)
                {
                    CmiCuestionario.fk_tbl_g18 = 1;

                }
                if (res17p2.Checked)
                {
                    CmiCuestionario.fk_tbl_g18 = 2;

                }
                if (res17p3.Checked)
                {
                    CmiCuestionario.fk_tbl_g18 = 3;

                }
                if (res17p4.Checked)
                {
                    CmiCuestionario.fk_tbl_g18 = 4;

                }
                //P18 psicologo
                if (res18p1.Checked)
                {
                    CmiCuestionario.pp19 = 1;

                }
                else
                {
                    CmiCuestionario.pp19 = 0;
                }
                //P19 Psicologo
                if (res19p1.Checked)
                {
                    CmiCuestionario.fk_tbl_g19 = 1;

                }
                if (res19p2.Checked)
                {
                    CmiCuestionario.fk_tbl_g19 = 2;

                }
                if (res19p3.Checked)
                {
                    CmiCuestionario.fk_tbl_g19 = 3;

                }
                if (res19p4.Checked)
                {
                    CmiCuestionario.fk_tbl_g19 = 4;

                }
                CmiCuestionario.fk_alumno= objLoggerinf.alu_NumControl;
                return CmiCuestionario;
            }
        }
        public DataSet ListadoCuestionarioDental
        {
            set
            {
                if (value!=null)
                {
                    
                }
            }
        }
        public DataSet ListadoCuestionarioMedico
        {
            
            set
            {
                if (value!=null)
                {
                    folio= value.Tables[0].Rows[0][0].ToString();
                }
            }
        }

        public DataSet ListadoCuestionarioPsicologico
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Alumno

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
                CAlumno objLoggerdUser = new CAlumno();
                objLoggerdUser.alu_NumControl = objLoggerinf.alu_NumControl;
                return objLoggerdUser;
            }
            set
            {
                objLoggerinf.alu_E1 = Convert.ToInt32(value.alu_E1);
                objLoggerinf.alu_E2 = Convert.ToInt32(value.alu_E2);
                objLoggerinf.alu_E3 = Convert.ToInt32(value.alu_E3);
                objLoggerinf.alu_NumControl = Convert.ToString(value.alu_NumControl);
                objLoggerinf.alu_Rol = Convert.ToInt32(value.alu_Rol);
                objLoggerinf.alu_Nombre = Convert.ToString(value.alu_Nombre);
                objLoggerinf.alu_ApePaterno = Convert.ToString(value.alu_ApePaterno);
                objLoggerinf.alu_Sexo = Convert.ToString(value.alu_Sexo);
            }
        }
        #endregion

        #region ICombo
        public List<CCuestionario> LlenarComboSangre
        {
            get
            {
                return listaDatos;
            }

            set
            {
                if (value != null)
                { listaDatos = value; }
            }
        }

        public DataSet ListadoCuestionario
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        private void LlenadoComboGenerico(DropDownList Combo, int Opcion)
        {
            WmiCuestionario.ListarSangre(Opcion);/// se implementa el llenado de la interfaz
            if (listaDatos != null)
            {
                foreach (CCuestionario item in listaDatos)
                {
                    Combo.Items.Add(new System.Web.UI.WebControls.ListItem(item.Descripcion, item.Id.ToString()));
                }
            }
        }
        #endregion

        #region  Metodos de validacion
        //validaciones del doctor
        protected void pre7Res1_CheckedChanged(object sender, EventArgs e)
        {
            if (pre7Res1.Checked)
            {
                PanelPM7.Visible = true;
            }
            else
            {

                PanelPM7.Visible = false;
            }
        }
        protected void pre8Res1_CheckedChanged(object sender, EventArgs e)
        {
            if (pre8Res1.Checked)
            {
                PanelPM8.Visible = true;
            }
            else
            {

                PanelPM8.Visible = false;
            }
        }
        protected void pre13Res1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (pre13Res1.Checked)
            {
                Panelpre13Res1.Visible = true;
            }
            else
            {

                Panelpre13Res1.Visible = false;
            }
        }

        protected void pre23Res9_CheckedChanged(object sender, EventArgs e)
        {
            pre23Res1.Checked = false;
            pre23Res2.Checked = false;
            pre23Res3.Checked = false;
            pre23Res4.Checked = false;
            pre23Res5.Checked = false;
            pre23Res6.Checked = false;
            pre23Res7.Checked = false;
            pre23Res8.Checked = false;
        }

        protected void pre24Res9_CheckedChanged(object sender, EventArgs e)
        {
            pre24Res1.Checked = false;
            pre24Res2.Checked = false;
            pre24Res3.Checked = false;
            pre24Res4.Checked = false;
            pre24Res5.Checked = false;
            pre24Res6.Checked = false;
            pre24Res7.Checked = false;
            pre24Res8.Checked = false;
        }




        protected void pre24Res9_CheckedChanged1(object sender, EventArgs e)
        {
            pre24Res1.Checked = false;
            pre24Res2.Checked = false;
            pre24Res3.Checked = false;
            pre24Res4.Checked = false;
            pre24Res5.Checked = false;
            pre24Res6.Checked = false;
            pre24Res7.Checked = false;
            pre24Res8.Checked = false;
        }

        protected void pre25Res9_CheckedChanged(object sender, EventArgs e)
        {
            pre25Res1.Checked = false;
            pre25Res2.Checked = false;
            pre25Res3.Checked = false;
            pre25Res4.Checked = false;
            pre25Res5.Checked = false;
            pre25Res6.Checked = false;
            pre25Res7.Checked = false;
            pre25Res8.Checked = false;
        }

        protected void NingunoLimpinar23(object sender, EventArgs e)
        {
            pre23Res9.Checked = false;
        }
        protected void NingunoLimpinar24(object sender, EventArgs e)
        {
            pre24Res9.Checked = false;
        }
        protected void NingunoLimpinar25(object sender, EventArgs e)
        {
            pre25Res9.Checked = false;
        }
        //validaciones del dentista
        protected void pre2ResD8_CheckedChanged(object sender, EventArgs e)
        {
            pre2ResD1.Checked = false;
            pre2ResD2.Checked = false;
            pre2ResD3.Checked = false;
            pre2ResD4.Checked = false;
            pre2ResD5.Checked = false;
            pre2ResD6.Checked = false;
            pre2ResD7.Checked = false;
        }
        //validaciones del psicologo
        protected void res9p14_CheckedChanged(object sender, EventArgs e)
        {
            Panelres9p14.Visible = true;
            res9p1.Checked = false;
            res9p2.Checked = false;
            res9p3.Checked = false;
            res9p4.Checked = false;
            res9p5.Checked = false;
            res9p6.Checked = false;
            res9p7.Checked = false;
            res9p8.Checked = false;
            res9p9.Checked = false;
            res9p10.Checked = false;
            res9p11.Checked = false;
            res9p12.Checked = false;
            res9p13.Checked = false;
            if (res9p14.Checked)
            {
                Panelres9p14.Visible = true;
            }
            else
            {
                Panelres9p14.Visible = false;
            }

        }
        protected void res10p14_CheckedChanged(object sender, EventArgs e)
        {
            Panelres10p14.Visible = true;
            res10p1.Checked = false;
            res10p2.Checked = false;
            res10p3.Checked = false;
            res10p4.Checked = false;
            res10p5.Checked = false;
            res10p6.Checked = false;
            res10p7.Checked = false;
            res10p8.Checked = false;
            res10p9.Checked = false;
            res10p10.Checked = false;
            res10p11.Checked = false;
            res10p12.Checked = false;
            res10p13.Checked = false;
            if (res10p14.Checked)
            {
                Panelres10p14.Visible = true;
            }
            else
            {
                Panelres10p14.Visible = false;
            }

        }
        protected void pre14Res1_CheckedChanged(object sender, EventArgs e)
        {
            if (pre14Res1.Checked == true)
            {
                Panelpre14Res1.Visible = true;
            }
            else
            {
                Panelpre14Res1.Visible = false;
            }
        }

        #endregion

        protected void ButtonAceptarTerminos_Click(object sender, EventArgs e)
        {
            PanelCuestionarnio.Visible = true;
            PanelAviso.Visible = false;
            WmiCuestionario.ReguistrarCuestionario(NewCuestionarioDental, 4);// Se guarda los terminos y condiciones
            WmiAlumno.ActualizarDatosDeAlumno(UsuarioActulizar);// se actuliza la variable de sesion
            Session.Clear();// limpiamos la sesion
            Session.Add("UsuarioLogeado", objLoggerinf);
            Response.Redirect(Request.RawUrl);
        }

   

        protected void ButtonAcuse_Click(object sender, EventArgs e)
        {
            //Get id de folio
            WmiCuestionario.GetFolio( objLoggerinf.alu_NumControl,15);

            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToShortDateString();
            string cadenaFinal = "";
            string path = Server.MapPath("/IMAG/universidad/Acuse.png");
            cadenaFinal += "<img src='" + path + "' Height='150' Width='500' />";
            cadenaFinal += "<br><br>";
            cadenaFinal += "Fecha: "+fecha;//Tenemos que sacar la fecha
            cadenaFinal += "<br><br>";
            cadenaFinal += "El alumno: " + objLoggerinf.alu_Nombre + ", con la matícula: " + objLoggerinf.alu_NumControl + ", ha llenado correctamente los cuestionarios.";
            cadenaFinal += "<br><br><br><br>";
            cadenaFinal += "Folio :" +folio;
            string nom = "AcuseDeCuestionario" + objLoggerinf.alu_NumControl;
            imprimirPDF(cadenaFinal, nom);
        }

        private void imprimirPDF(string cadenaFinal, string nom)
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
    }

    }