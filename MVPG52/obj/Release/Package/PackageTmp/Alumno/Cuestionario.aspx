<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cuestionario.aspx.cs" Inherits="MVPG52.Paginas.Alumno.Cuestionario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        label {
            color: black;
        }

        img {
            width: 100%;
        }

        button {
            width: 100px;
            height: 100px;
        }

        .parallax-container {
            height: 300px;
        }

        icons {
        }

        .material-icons {
            color: red;
            font-size: 50px;
            text-align: left;
        }

        // Class for when element is above threshold .pin-top {
            position: relative;
        }

        // Class for when element is below threshold .pin-bottom {
            position: relative;
        }

        // Class for when element is pinned .pinned {
            position: fixed;
        }
    </style>
    <div class="parallax-container" style="height: 179px">
        <div class="parallax">
            <img src="IMAG\universidad\ban.jpg" class="responsive-img" />
        </div>
    </div>
    <div class="col-lg-12  nav nav-pills">
        <!--barra de cuestionario-->
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#menu0">Médico</a></li>
            <li><a data-toggle="tab" href="#menu1">Dentista</a></li>
            <li><a data-toggle="tab" href="#menu2">Psicologo </a></li>
        </ul>

        <div class="tab-content">
            <div id="menu0" class="tab-pane fade in active">
                <%-- Banner de cuestionario medico --%>
                <div id="red" class="#fafafa grey lighten-5" style="height: 100%">
                    <nav class="pushpin-demo-nav" data-target="red" style="top: 0px; z-index: 3">
                        <div class="nav-wrapper red">
                            <div class="container">
                                <a href="#" class="brand-logo">Cuestionario Médico</a>
                                <ul id="nav-mobile2" class="right hide-on-med-and-down">
                                </ul>
                            </div>
                        </div>
                    </nav>
                    <br />
                    <br />
                    <%-- Pregunta 1 Doctor --%>
                    <div class="col s6">
                        <h3>1.-Alimentación diaria</h3>
                        <br />
                        <p>
                            <asp:RadioButton ID="pre1Res1" runat="server" Text="1 comida." GroupName="pm1" />
                        </p>
                        <p>
                            <asp:RadioButton ID="pre1Res2" runat="server" Text="2 comidas." GroupName="pm1" />
                        </p>
                        <p>
                            <asp:RadioButton ID="pre1Res3" runat="server" Text="3 comidas." GroupName="pm1" />
                        </p>
                        <p>
                            <asp:RadioButton ID="pre1Res4" runat="server" Text="4 o más." GroupName="pm1" />
                        </p>
                    </div>
                    <%-- Pregunta 2 Doctor --%>
                    <div class="row">
                        <div class="col s8">
                            <h3>2.-¿Cuantas veces a la semana realizas ejercicio?</h3>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre2Res1" runat="server" Text="3 o más veces por semana." GroupName="pm2" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre2Res2" runat="server" Text="Una vez a la semana." GroupName="pm2" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre2Res3" runat="server" Text="Una vez cada 15 dias." GroupName="pm2" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre2Res4" runat="server" Text="Una vez al mes." GroupName="pm2" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre2Res5" runat="server" Text="Nunca." GroupName="pm2" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 3 Doctor --%>
                    <div class="row">
                        <div class="col s8">
                            <h3>3.-¿Cual es su grupo sanguineo?</h3>
                            <br />
                            <label>Grupo sanguineo</label>
                            <select class="browser-default">
                                <option value="" disabled selected>Seleccione uno</option>
                                <option value="1">A Positiva </option>
                                <option value="2">A Negativo</option>
                                <option value="3">B Positivo</option>
                                <option value="4">'B Negativo</option>
                                <option value="5">O Positivo</option>
                                <option value="6">O Negativo</option>
                                <option value="7">AB Positivo</option>
                                <option value="8">AB Negativo</option>
                            </select>
                        </div>
                    </div>
                    <%-- Pregunta 4 Doctor --%>
                    <div class="row">
                        <div class="col s6">

                            <h3>4.-¿Con que frecuencia consumes bebidas alcohólicas?</h3>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre4Res1" runat="server" Text="2 o más veces por semana." GroupName="pm4" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre4Res2" runat="server" Text="Una vez a la semana." GroupName="pm4" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre4Res3" runat="server" Text="Una vez al mes." GroupName="pm4" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre4Res4" runat="server" Text="Nunca." GroupName="pm4" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 5 Doctor --%>
                    <div class="row">
                        <div class="col s6">
                            <h3>5.-¿Con que frecuencia fumas tabaco?</h3>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre5Res1" runat="server" Text="Diario." GroupName="pm5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre5Res2" runat="server" Text="Una vez a la semana." GroupName="pm5" />

                            </p>
                            <p>
                                <asp:RadioButton ID="pre5Res3" runat="server" Text="Una vez al mes." GroupName="pm5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre5Res4" runat="server" Text="Nunca." GroupName="pm5" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 6 Doctor --%>
                    <div class="row">
                        <div class="col s6">

                            <h3>6.-¿Consumes alguna droga ilegal (marihuana , cocaina, ácidos(LCD),inhalantes,etc)?</h3>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre6Res1" runat="server" Text="Diario." GroupName="pm6" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre6Res2" runat="server" Text="Una vez a la semana." GroupName="pm6" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre6Res3" runat="server" Text="Una vez al mes." GroupName="pm6" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre6Res14" runat="server" Text="Nunca." GroupName="pm6" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 7 Doctor --%>
                    <div class="col s6">
                        <h3>7.-¿Tienes alguna alergia?</h3>
                        <div class="switch col s4">
                            <label>
                                No
      <asp:CheckBox ID="pre7Res1" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>
                        <div class="input-field col s6">
                            <input id="mtest7Alergias" type="text" class="validate" />
                            <label class="active" for="Alergias">Descripción</label>
                        </div>
                    </div>
                    <%-- Pregunta 8 Doctor --%>

                    <%-- Pregunta 9 Doctor --%>
                    <div class="row">
                        <div class="col s6">

                            <h3>9.-¿Con que frecuencia te bañas?</h3>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre9Res1" runat="server" Text="Diario." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre9Res2" runat="server" Text="Cada tercer día." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre9Res3" runat="server" Text="Una vez a la semana." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre9Res4" runat="server" Text="Una vez al mes." GroupName="pm9" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 10 Doctor --%>
                    <div class="row">
                        <div class="col s6">
                            <h3>10.-¿Qué tipo de baño hay donde vives?</h3>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre10Res1" runat="server" Text="Baño con drenaje." GroupName="pm10" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre10Res2" runat="server" Text="Letrina." GroupName="pm10" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre10Res3" runat="server" Text="Fosa Séptica." GroupName="pm10" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre10Res4" runat="server" Text="Ras de suelo." GroupName="pm10" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 11 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>11.-¿Vives en lugares con enfermedades como el Dengue, Paludismo, etc.?</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                <asp:CheckBox ID="pre11Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>

                    </div>
                    <%-- Pregunta 12 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>12.-Estás en algún tratamiento hormonal. </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                <asp:CheckBox ID="pre12Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 13 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>13.-¿Tomas anticonceptivos? </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                <asp:CheckBox ID="pre13Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 14 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>14.-¿Alguna ves te practicaron una cirugía?</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                    <asp:CheckBox ID="pre14Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 15 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>15.-¿Alguna vez te han practicado una transfunción de sangre?
                                </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                <asp:CheckBox ID="pre15Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 16 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>16.-¿Estás en contacto directo con pacientes diagnosticados con VIH o Tuberculosis? </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                <asp:CheckBox ID="pre16Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 17 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>17.-¿Cuál es tu altura en metros? </h3>
                            </div>
                        </div>

                        <div class="input-field col s6" runat="server">
                            <asp:TextBox ID="pre17Res1" runat="server"></asp:TextBox>
                            <label class="active" for="pre17Res1">Altura(metros)</label>
                        </div>
                    </div>

                    <%-- Pregunta 18 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>18.-¿Cuál es tu peso en kilogramos? </h3>
                            </div>
                        </div>
                        <div class="input-field col s6" runat="server" id="txtPeso">
                            <asp:TextBox ID="pre18Res1" runat="server"></asp:TextBox>
                            <label class="active" for="pm18">Peso(kg)</label>

                        </div>
                    </div>
                    <%-- Pregunta 19 Doctor --%>
                    <%---------------------------falta la 19 es el calculo imc --%>
                    <%-- Pregunta 20 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>19.-¿Tu regla es regular? </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                    <asp:CheckBox ID="pre20Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 21 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>20.-¿Estás enbarazada? </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
                <asp:CheckBox ID="pre21Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 22 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>21.-¿Estás lactando (dando pecho)? </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4" id="switch" runat="server">
                                <label>
                                    No
                    <asp:CheckBox ID="pre22Res1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 23 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>22.-¿Tus abuelos padecieron algunas de estas enfermedades? </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s6">
                                <p>
                                    <asp:CheckBox ID="pre23Res1" runat="server" Text="Diabetes Mellitu." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res2" runat="server" Text="Hipertensión Arterial." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res3" runat="server" Text="Cardiopatias." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res4" runat="server" Text="Cancer." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res5" runat="server" Text="Epilepsia." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res6" runat="server" Text="Enfermedades autoinmunes." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res7" runat="server" Text="Psiquiatricas." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res8" runat="server" Text="Sanguineas." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre23Res9" runat="server" Text="Ninguna." />
                                </p>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 24 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>23.-¿Tus padres padecieron algunas de estas enfermedades?</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s6">
                                <p>
                                    <asp:CheckBox ID="pre24Res1" runat="server" Text="Diabetes Mellitu." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res2" runat="server" Text="Hipertensión Arterial." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res3" runat="server" Text="Cardiopatias." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res4" runat="server" Text="Cancer." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res5" runat="server" Text="Epilepsia." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res6" runat="server" Text="Enfermedades autoinmunes." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res7" runat="server" Text="Psiquiatricas." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res8" runat="server" Text="Sanguineas." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre24Res9" runat="server" Text="Ninguna." />
                                </p>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 25 Doctor --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h3>24.-¿Tus hermanos,primos o tios padecieron algunas de estas enfermedades?</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s6">
                                <p>
                                    <asp:CheckBox ID="pre25Res1" runat="server" Text="Diabetes Mellitu." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res2" runat="server" Text="Hipertensión Arterial." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res3" runat="server" Text="Cardiopatias." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res4" runat="server" Text="Cancer." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res5" runat="server" Text="Epilepsia." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res6" runat="server" Text="Enfermedades autoinmunes." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res7" runat="server" Text="Psiquiatricas." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res8" runat="server" Text="Sanguineas." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre25Res9" runat="server" Text="Ninguna." />
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <%-- Banner de cuestionario medico Fin --%>
            </div>
            <div id="menu1" class="tab-pane fade">
                <h3>Información del pasiente</h3>
                <%-- Banner de cuestionario Dentista y preguntas --%>
                <div id="red" class="#fafafa grey lighten-5" style="height: 100%">
                    <nav class="pushpin-demo-nav" data-target="red" style="top: 0px; z-index: 3">
                        <div class="nav-wrapper red">
                            <div class="container">
                                <a href="#" class="brand-logo">Cuestionario Dental</a>
                                <ul id="nav-mobile2" class="right hide-on-med-and-down">
                                </ul>
                            </div>
                        </div>
                    </nav>
                    <br />
                    <br />
                    <%-- Pregunta 1 Dentista --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>1.-¿Cuando fue la última vez qur fuiste al dentista?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre1ResD1" runat="server" Text="Menos de 6 meses." GroupName="pd1" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre1ResD2" runat="server" Text="Menos de un año." GroupName="pd1" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre1ResD3" runat="server" Text="Un año o más." GroupName="pd1" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre1ResD4" runat="server" Text="Nuncas." GroupName="pd1" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 2 Dentista --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>2.-¿Motivo de tu última visita dental?</h2>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col s6">
                                <p>
                                    <asp:CheckBox ID="pre2ResD1" runat="server" Text=" Diagnostico ." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre2ResD2" runat="server" Text="Caries." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre2ResD3" runat="server" Text="Profilaxis (limpieza) ." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre2ResD4" runat="server" Text="Dolor de muelas (muelas del juicio)." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre2ResD5" runat="server" Text="Gingivitis (sangrado ) ." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre2ResD6" runat="server" Text="Tratamientos de ortodoncia (braquetes)." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre2ResD7" runat="server" Text="Endodoncia." />
                                </p>
                                <p>
                                    <asp:CheckBox ID="pre2ResD8" runat="server" Text="Ninguna." />
                                </p>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 3 Dentista --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>3.-¿Cómo califica su boca?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre3ResD1" runat="server" Text="Muy buena." GroupName="pd3" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre3ResD2" runat="server" Text="Buena." GroupName="pd3" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre3ResD3" runat="server" Text="Mala." GroupName="pd3" />
                            </p>
                            <p>
                                <asp:RadioButton ID="pre3ResD4" runat="server" Text="Muy mala." GroupName="pd3" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 4 Dentista --%>
                    <div class="row">
                        <div class="col s6">
                            <label>4.-¿Cuántas veces al día cepilla sus dientes?</label>
                            <br />
                            <p>
                                <asp:RadioButton ID="pre4ResD1" runat="server" Text="Diario." GroupName="pd4" />

                            </p>
                            <p>
                                <asp:RadioButton ID="pre4ResD2" runat="server" Text="Diario." GroupName="pd4" />

                            </p>
                            <p>
                                <asp:RadioButton ID="pre4ResD3" runat="server" Text="Diario." GroupName="pd4" />

                            </p>
                            <p>
                                <asp:RadioButton ID="pre4ResD4" runat="server" Text="Ninguna." GroupName="pd4" />

                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 5 Dentista --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>5.-¿Te truena la mandibula cuando abres mucho la boca?</h2>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4" id="Div1" runat="server">
                                <label>
                                    No
                    <asp:CheckBox ID="pre5ResD1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 6 Dentista --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>6.-¿Te sangran las encias cuando te cepillas los dientes?
                                </h2>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4" id="Div3" runat="server">
                                <label>
                                    No
                    <asp:CheckBox ID="pre6ResD1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 7 Dentista --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>7.-¿Tienes dificultad para abrir la boca en algunas ocasiones? </h2>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4" id="Div4" runat="server">
                                <label>
                                    No
                    <asp:CheckBox ID="pre7ResD1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 8 Dentista --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>8.-¿Se ha quedado alguna vez con la boca abierta sin poder cerrarla? </h2>
                            </div>
                        </div>
                        <div class="row">

                            <div class="switch col s4" id="Div5" runat="server">
                                <label>
                                    No
                        <asp:CheckBox ID="pre8ResD1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 9 Dentista --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>9.-¿Has tenido perforaciones en la boca (percings)? </h2>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4" id="Div6" runat="server">
                                <label>
                                    No
                    <asp:CheckBox ID="pre9ResD1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                    <%-- Pregunta 10 Dentista --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>10.-¿Has presentado mal aliento? </h2>
                        </div>
                    </div>
                    <div class="row">
                        <div class="switch col s4">
                            <label>
                                No
   <asp:CheckBox ID="pre10ResD1" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>
                    </div>
                    <%-- Pregunta 11 Dentista --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>11.-¿Tienes el hábito de morderte las uñas. apretar o tallarte los dientes o morder objetos?</h2>
                            </div>
                        </div>
                        <div class="row">
                            <div class="switch col s4">
                                <label>
                                    No
      <asp:CheckBox ID="pre11ResD1" runat="server" />
                                    <span class="lever"></span>
                                    Si
                                </label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="menu2" class="tab-pane fade">
                <%-- Banner de cuestionario Psicologo --%>
                <div id="green" class="block white">
                    <nav class="pushpin-demo-nav" data-target="green" style="top: 0px; z-index: 3">
                        <div class="nav-wrapper green">
                            <div class="container">
                                <a href="#" class="brand-logo">Cuestionario Psicológico</a>
                                <ul id="nav-mobile3" class="right hide-on-med-and-down">
                                </ul>
                            </div>
                        </div>
                    </nav>
                    <%-- Pregunta 1 Psicologo --%>
                    <div>
                        <div class="row">
                            <div class="col s6">
                                <h2>1.-¿La Universidad Politécnica de Tulancingo fue tu primera opción? </h2>
                            </div>
                        </div>
                        <div class="row">
                            <label>
                                No
      <asp:CheckBox ID="pre11ResP1" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>

                    </div>
                    <%-- Pregunta 2 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>2.-¿La carrera que elegiste fue tu primera opción? </h2>
                        </div>
                    </div>
                    <div class="row">
                        <div class="switch col s4" runat="server">
                            <label>
                                No
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>
                    </div>
                    <%-- Pregunta 3 Psicologo --%>
                    <div class="row">

                        <div class="col s6">
                            <h2>3.-¿Qué tan satisfecho estas con la elección de tu carrera?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton1" runat="server" Text="Muy satisfecho." GroupName="pp1" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton2" runat="server" Text="Satisfecho." GroupName="pp1" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton3" runat="server" Text="Poco satisfecho." GroupName="pp1" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton4" runat="server" Text="Insatisfecho." GroupName="pp1" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 4 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>4.-¿Sabes cuál es tu perfil vocacional? </h2>
                        </div>
                    </div>
                    <div class="row">
                        <div class="switch col s4" runat="server">
                            <label>
                                No
                <asp:CheckBox ID="CheckBox3" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>
                    </div>
                    <%-- Pregunta 5 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>5.-¿Cómo es tu relación con tus abuelos?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton5" runat="server" Text="Buena." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton6" runat="server" Text="Regular." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton7" runat="server" Text="Mala." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton8" runat="server" Text="Sin relación." GroupName="pp5" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 6 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>6.-¿Cómo es tu relación con tu mamá?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton9" runat="server" Text="Buena." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton10" runat="server" Text="Regular." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton11" runat="server" Text="Mala." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton12" runat="server" Text="Sin relación." GroupName="pp5" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 7 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>7.-¿Cómo es tu relación con tu papá?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton13" runat="server" Text="Buena." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton14" runat="server" Text="Regular." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton15" runat="server" Text="Mala." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton16" runat="server" Text="Sin relación." GroupName="pp5" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 8 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>8.-¿Cómo es tu relación con tus hermanos?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton17" runat="server" Text="Buena." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton18" runat="server" Text="Regular." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton19" runat="server" Text="Mala." GroupName="pp5" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton20" runat="server" Text="Sin relación." GroupName="pp5" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 9 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>9.-¿Cuál es el acontecimiento más relevante de tu infancia(0-9 años)?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton21" runat="server" Text=" Divorcio de los padres ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton22" runat="server" Text="Nacimiento de un hermano ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton23" runat="server" Text="Fallecimiento de uno de tus  abuelo ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton24" runat="server" Text="Fallecimiento de uno de tus padres ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton25" runat="server" Text="Fallecimiento de uno de tus hermanos ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton26" runat="server" Text="Fallecimiento de un familiar ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton27" runat="server" Text="Ausencia del padre ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton28" runat="server" Text="Ausencia de la madre ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton29" runat="server" Text="Cambio de domicilio ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton30" runat="server" Text="Violencia familiar." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton31" runat="server" Text="Abuso sexual ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton32" runat="server" Text="Víctima de bullying ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton33" runat="server" Text="Ninguno ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton34" runat="server" Text="Otro." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <label class="active" for="pm18">Descripción.</label>
                            </p>

                        </div>
                    </div>
                    <%-- Pregunta 10 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>10.-¿Cuál es el acontecimiento más relevante de tu adolecnciz(10-19 años)?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton35" runat="server" Text=" Divorcio de los padres ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton36" runat="server" Text="Nacimiento de un hermano ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton37" runat="server" Text="Fallecimiento de uno de tus  abuelo ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton38" runat="server" Text="Fallecimiento de uno de tus padres ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton39" runat="server" Text="Fallecimiento de uno de tus hermanos ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton40" runat="server" Text="Fallecimiento de un familiar ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton41" runat="server" Text="Ausencia del padre ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton42" runat="server" Text="Ausencia de la madre ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton43" runat="server" Text="Cambio de domicilio ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton44" runat="server" Text="Violencia familiar." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton45" runat="server" Text="Abuso sexual ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton46" runat="server" Text="Víctima de bullying ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton47" runat="server" Text="Ninguno ." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton48" runat="server" Text="Otro." GroupName="pm9" />
                            </p>
                            <p>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                <label class="active" for="pm18">Descripción.</label>
                            </p>

                        </div>
                    </div>
                    <%-- Pregunta 11 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <label>11.-¿Cómo consideras que es tu autoestima?</label>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton49" runat="server" Text="Muy Buena." GroupName="pp11" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton50" runat="server" Text="Buena." GroupName="pp11" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton51" runat="server" Text="Mala." GroupName="pp11" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton52" runat="server" Text="Muy mala." GroupName="pp11" />
                            </p>
                        </div>

                    </div>
                    <%-- Pregunta 12 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <label>12.-¿Cómo consideras tu capacidad para relacionarte con otras personas?</label>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton53" runat="server" Text="Muy Buena." GroupName="pp12" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton54" runat="server" Text="Buena." GroupName="pp12" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton55" runat="server" Text="Mala." GroupName="pp12" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton56" runat="server" Text="Muy mala<." GroupName="pp12" />

                            </p>
                        </div>

                    </div>
                    <%-- Pregunta 13 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <label>
                                13.-¿Tienes proyecto de vida?
                            </label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="switch col s4" runat="server">
                            <label>
                                No
     <asp:CheckBox ID="CheckBox4" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>
                    </div>
                    <%-- Pregunta 14 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>14.-¿Te gustaría recibir atención psicológica?</h2>
                        </div>
                    </div>
                    <div class="row">
                        <div class="switch col s4" runat="server">
                            <label>
                                No
     <asp:CheckBox ID="CheckBox5" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>
                    </div>
                    <%-- Pregunta 15 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>15.-¿Qué número de hijo eres?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton57" runat="server" Text="Mayor." GroupName="pp15" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton58" runat="server" Text="Intermedio." GroupName="pp15" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton59" runat="server" Text="Menor." GroupName="pp15" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton60" runat="server" Text="Único." GroupName="pp15" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 16 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <label>16.-¿Con quién vives actualmente?</label>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton61" runat="server" Text="Papás." GroupName="pp16" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton62" runat="server" Text="Familiares o Amigos." GroupName="pp16" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton63" runat="server" Text="Casa de huespedes." GroupName="pp16" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton64" runat="server" Text="Sólo." GroupName="pp16" />
                            </p>
                        </div>

                    </div>
                    <%-- Pregunta 17 Psicologo --%>
                    <div class="row">

                        <div class="col s6">
                            <h2>17.-¿Cuál es tu preferencia sexuale?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton65" runat="server" Text="Hetero Sexual." GroupName="pp17" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton66" runat="server" Text="Homosexual." GroupName="pp17" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton67" runat="server" Text="Bisexual." GroupName="pp17" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton68" runat="server" Text="Otro." GroupName="pp17" />
                            </p>
                        </div>
                    </div>
                    <%-- Pregunta 18 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <label>
                                14.-¿Has asistido  a terapia psicológica anteriormente?
                            </label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="switch col s4" runat="server">
                            <label>
                                No
      <asp:CheckBox ID="CheckBox6" runat="server" />
                                <span class="lever"></span>
                                Si
                            </label>
                        </div>
                    </div>
                    <%-- Pregunta 19 Psicologo --%>
                    <div class="row">
                        <div class="col s6">
                            <h2>19.-¿Cuantas horas duermes diariamente?</h2>
                            <br />
                            <p>
                                <asp:RadioButton ID="RadioButton69" runat="server" Text="Menos de 2 horas." GroupName="pp19" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton70" runat="server" Text="De 2 a 5 horas." GroupName="pp19" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton71" runat="server" Text="De 5 a 8 horas." GroupName="pp19" />
                            </p>
                            <p>
                                <asp:RadioButton ID="RadioButton72" runat="server" Text="Más de 8 horas." GroupName="pp19" />
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <asp:CheckBox ID="CheckBox1" runat="server" Text="Un textbox solo" />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <%-- Scripts --%>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/materialize.min.js"></script>
    <script>
        $(document).ready(function () {
            //código que queremos ejecutar
            $('.pushpin-demo-nav').each(function () {
                var $this = $(this);
                var $target = $('#' + $(this).attr('data-target'));
                $this.pushpin({
                    top: $target.offset().top,
                    bottom: $target.offset().top + $target.outerHeight() - $this.height()
                });
            });
            $('.target').pushpin({
                top: 0,
                bottom: 1000,
                offset: 0
            });
            $('.carousel').carousel();
            $('select').material_select();
            $('.parallax').parallax();
            $('.tooltipped').tooltip({ delay: 10 });
            $(".button-collapse").sideNav();
            $('.button-collapse').sideNav({
                menuWidth: 350, // Default is 300
                edge: 'left', // Choose the horizontal origin
                closeOnClick: true, // Closes side-nav on <a> clicks, useful for Angular/Meteor
                draggable: true, width: 40, height: 30
                // Choose whether you can drag to open on touch screens
            });
            $('.modal').modal();
        });
    </script>
</asp:Content>
