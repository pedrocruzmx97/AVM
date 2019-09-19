<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevaConsulta.aspx.cs" Inherits="MVPG52.NuevaConsulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Compiled and minified CSS -->

    <style>
        input.textbox, select, textarea {
            max-width: none;
            color: black;
        }

        text.textbox {
            color: black;
        }

        label {
            font-size: Medium;
            color: black;
        }
    </style>


    <div class="jumbotron card-panel teal white ">
        <div class="nav-wrapper card-panel  accent-1#ffffff white">
            <div class="container">
                <h2 class="center-align">Cita Médica</h2>
            </div>
        </div>

        <!--Nueva Consulta-->
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#HistorialMedico" class="card-panel #2196f3 blue white-text">Hitorial Médico</a></li>
            <li><a data-toggle="tab" href="#HistorialCitas" class="card-panel #ff6f00 amber darken-4 white-text">Historial Citas</a></li>
            <li>
                <asp:HyperLink ID="HyperLinkMedico" runat="server" Visible="false" data-toggle="tab" href="#LlenadoConsulta" class="card-panel #d81b60 pink darken-1 white-text">Consulta médica</asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="HyperLinkOdontograma" runat="server" Visible="false" data-toggle="tab" href="#odontograma" class="card-panel #33691e light-green darken-4 white-text">Odontograma</asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="HyperLinkPsicologo" runat="server" Visible="false" data-toggle="tab" href="#psicologo" class="card-panel #311b92 deep-purple darken-4 white-text">Psicologo</asp:HyperLink>
            </li>
        </ul>

        <!--Contenido de tabs-->
        <div class="tab-content">
            <!----Pestañana 1-->
            <div id="HistorialMedico" class="tab-pane fade in active">
                <nav class="" data-target="red" style="top: auto; z-index: auto">
                    <div class="nav-wrapper #2196f3 blue white-text">
                        <div class="container center-align">
                            <h3 class=""></h3>
                            <ul id="nav-mobile2" class="right hide-on-med-and-down">
                            </ul>
                        </div>
                    </div>
                </nav>
                <!----SubMenu-->
                <div>
                    <ul class="collapsible " data-collapsible="accordion" style="font-size: medium">
                        <li>
                            <div class="collapsible-header"><i class="material-icons">person_pin</i>Médico</div>
                            <div class="collapsible-body  jumbotron  card-panel teal white">

                                <%-- Banner de cuestionario Dentista y preguntas --%>
                                <%-- P1 M --%>
                                <div class="row ">
                                    <h4>1.-Alimentación diaria </h4>
                                    <div class=" col s12 ">
                                        <asp:TextBox ID="m1" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P2 M --%>
                                <div class="row">
                                    <h4>2.-Veces que realiza ejercicio por semana</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m2" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P3 M --%>
                                <div class="row">
                                    <h4>3.-Tipo de sangre</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m3" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P4 M --%>
                                <div class="row">
                                    <h4>4.-Frecuencia de consumo de bebidas alcóholicas</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m4" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P5 M --%>
                                <div class="row">
                                    <h4>5.-Frecuencia de consumo de tabaco</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m5" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P6 M --%>
                                <div class="row">
                                    <h4>6.-Consumo de drogas ilegales</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m6" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P7 M --%>
                                <div class="row">
                                    <h4>7.-Padecimiento de alergias</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m7" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P8 M --%>
                                <div class="row">
                                    <h4>8.-Enfermedades que padece</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m8" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P9 M --%>
                                <div class="row">
                                    <h4>9.-Frecuencia con que se baña</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m9" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P10 M --%>
                                <div class="row">
                                    <h4>10.-Tipo de baño que hay donde vive</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m10" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P11 M --%>
                                <div class="row">
                                    <h4>11.-Vive en lugares con enfermedades como el Dengue,Paludismo,etc</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m11" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P12 M --%>
                                <div class="row">
                                    <h4>12.-Está en tratamientos hormonales</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m12" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P13 M --%>
                                <div class="row">
                                    <h4>13.-Toma anticonceptivos</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m13" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"> </asp:TextBox>
                                    </div>
                                </div>
                                <%-- P14 M --%>
                                <div class="row">
                                    <h4>14.-¿Alguna vez le precticaron cirugía?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m14" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P15 M --%>
                                <div class="row">
                                    <h4>15.-¿Le han practicado una transfusión sanguínea?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m15" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P16 M --%>
                                <div class="row">
                                    <h4>16.-¿Está en contacto directo con pacientes diagnosticados con VIH o Tuberculosis?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m16" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P17 M --%>
                                <div class="row">
                                    <h4>17.-Estatura(metros)</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m17" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P18 M --%>
                                <div class="row">
                                    <h4>18.-Peso(kg)</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m18" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P19 M --%>
                                <div class="row">
                                    <h4>19.-Cálculo IMC</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m19" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"> </asp:TextBox>
                                    </div>
                                </div>
                                <%-- P20 M --%>
                                <div class="row">
                                    <h4>20.-¿Su regla es regular?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m20" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P21 M --%>
                                <div class="row">
                                    <h4>21.-¿Está embarazada?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="m21" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                                <%-- P22 M --%>
                                <div class="row">
                                    <h4>22.-¿Está lactando?</h4>
                                    <div class="col s12 ">
                                        <asp:TextBox ID="m22" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P23 M --%>
                                <div class="row">
                                    <h4>23.-Enfermedades que padecieron los abuelos</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="m23" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P24 M --%>
                                <div class="row">
                                    <h4>24.-Enfermedades que padecieron los padres</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="m24" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P25 M --%>
                                <div class="row">
                                    <h4>25.-Enfermedades que padecieron los hermanos. primios y tios</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="m25" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                        </li>
                    </ul>
                    <ul class="collapsible " data-collapsible="accordion" style="font-size: medium">
                        <li>
                            <div class="collapsible-header"><i class="material-icons">person_pin</i>Dental</div>
                            <div class="collapsible-body  jumbotron  card-panel teal white">
                                <%-- Banner de cuestionario Dentista y preguntas --%>

                                <%-- P1 D --%>
                                <div class="row">
                                    <h4>1.-Última vez que acudió al dentista</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d1" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P2 D --%>
                                <div class="row">
                                    <h4>2.-Motivo de su última consulta dental</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="d2" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P3 D --%>
                                <div class="row">
                                    <h4>3.-¿Cómo calificó su boca?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d3" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                                <%-- P4 D --%>
                                <div class="row">
                                    <h4>4.-¿Cuantas veces al día cepilla sus dientes?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d4" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P5 D --%>
                                <div class="row">
                                    <h4>5.-¿Le truena la mandíbula cuando abre mucho la boca?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d5" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P6 D --%>
                                <div class="row">
                                    <h4>6.-¿Le sangran las encias cuando se ceilla los dientes?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d6" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P7 D --%>
                                <div class="row">
                                    <h4>7.-¿Tiene diicultad para abrir la boca en algunas ocasiones?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d7" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P8 D --%>
                                <div class="row">
                                    <h4>8.-¿Se ha quedado alguna vez con la boca abierta y ha tenido incapacidad para cerrarla?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d8" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P9 D --%>
                                <div class="row">
                                    <h4>9.-¿Se ha quedado alguna vez con la boca abierta y ha tenido incapacidad para cerrarla?</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="d9" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P10 D --%>
                                <div class="row">
                                    <h4>10.-¿Ha presentado mal aliento?</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="d10" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P11 D --%>
                                <div class="row">
                                    <h4>11.-¿Tienes el hábito de morderte las uñas, tallarte  o morder objetos?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="d11" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <ul class="collapsible " data-collapsible="accordion" style="font-size: medium">
                        <li>
                            <div class="collapsible-header"><i class="material-icons">person_pin</i>Psicológico</div>
                            <div class="collapsible-body  jumbotron  card-panel teal white">
                                <%-- Banner de cuestionario Dentista y preguntas --%>

                                <%-- P1 P --%>
                                <div class="row">
                                    <h4>1.-¿La Universidad Politécnica de Tulancingo fue su primera opción?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p1" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P2 P --%>
                                <div class="row">
                                    <h4>2.-¿La carrera que eligió fue su primera opción?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p2" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P3 P --%>
                                <div class="row">
                                    <h4>3.-¿Qué tan satisfecho está con la elección de carrera?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p3" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P4 P --%>
                                <div class="row">
                                    <h4>4.-¿Sabe cuál es su perfil vocacional?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p4" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                                <%-- P5 P --%>
                                <div class="row">
                                    <h4>5.-¿Cómo es la relación con sus abuelos?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p5" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P6 P --%>
                                <div class="row">
                                    <h4>6.-¿Cómo es la relación con su mamá?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p6" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                                <%-- P7 P --%>
                                <div class="row">
                                    <h4>7.-¿Cómo es la relación con su papá?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p7" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P8 P --%>
                                <div class="row">
                                    <h4>8.-¿Cómo es la relación con sus hermanos?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p8" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P9 P --%>
                                <div class="row">
                                    <h4>9.-¿Cuál es el acontecimiento más relevante de su infancia?</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="p9" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P10 P --%>
                                <div class="row">
                                    <h4>10.-¿Cuál es el acontecimiento más relevante de su adolesencia?</h4>
                                    <div class=" col s12">
                                        <asp:TextBox ID="p10" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                                <%-- P11 P --%>
                                <div class="row">
                                    <h4>11.-¿Cómo que es su autoestima?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p11" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P12 P --%>
                                <div class="row">
                                    <h4>12.-¿Cómo considera su capacidad para relacionarse con otras personas?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p12" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P13 P --%>
                                <div class="row">
                                    <h4>13.-¿Tiene algún proyecto de vida?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p13" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P14 P --%>
                                <div class="row">
                                    <h4>14.-¿Le gustaría recibir orientación psicológica?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p14" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                                <%-- P15 P --%>
                                <div class="row">
                                    <h4>15.-¿Número de hijo que es?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p15" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P16 P --%>
                                <div class="row">
                                    <h4>16.-¿Con quién vive actualmente?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p16" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P17 P --%>
                                <div class="row">
                                    <h4>17.-¿Cuales son sus preferencias sexuales?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p17" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P18 P --%>
                                <div class="row">
                                    <h4>18.-¿Ha asistido a terapia psicológica?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p18" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>
                                <%-- P19 P --%>
                                <div class="row">
                                    <h4>19.-¿Cuantas horas duermes diariamente?</h4>
                                    <div class="input-field col s12" style="top: 0">
                                        <asp:TextBox ID="p19" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="black"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                        </li>
                    </ul>
                </div>
                <!----SubMenu-->
            </div>
            <!----Pestañana 2-->
            <div id="HistorialCitas" class="tab-pane fade">
                <nav class="" data-target="red" style="top: auto; z-index: auto">
                    <div class="nav-wrapper #ff6f00 amber darken-4 white-text">
                        <div class="container center-align">
                            <h3 class=""></h3>
                            <ul id="nav-mobile2" class="right hide-on-med-and-down">
                            </ul>
                        </div>
                    </div>
                </nav>
                <h3>Historial de citas</h3>
                <asp:GridView ID="GridViewHIstorialCitas" runat="server" Font-Size="Small" CssClass="highlight  responsive-table table table-striped table table-hover " AutoGenerateDeleteButton="False" AllowSorting="False"></asp:GridView>

            </div>
            <!----Pestañana 3-->
            <div id="LlenadoConsulta" class="tab-pane fade">
                <nav class="" data-target="red" style="top: auto; z-index: auto">
                    <div class="nav-wrapper #d81b60 pink darken-1 white-text">
                        <div class="container center-align">
                            <h3 class=""></h3>
                            <ul id="nav-mobile2" class="right hide-on-med-and-down">
                            </ul>
                        </div>
                    </div>
                </nav>
                <div style="color: cornflowerblue">
                    <h3>Datos del alumno</h3>
                </div>
                <%-- Datos del alumno --%>

                <div class="row">
                    <div class="col s2">
                        <asp:Label ID="Label1" runat="server" Text="Alumno:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s4">
                        <asp:Label ID="LabelNombreAlumno" runat="server" Text="Nombre" Font-Size="Medium"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="Label3" runat="server" Text="Matrícula:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="LabelMatriculaAlumno" runat="server" Text="Matricula" Font-Size="Medium"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label2" runat="server" Text="Tipo de consulta:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col-md-4">
                        <asp:Label ID="TipoDeConsulta" runat="server" Text="Nombre" Font-Size="Medium"></asp:Label>
                    </div>
                </div>
                <%-- Interrogatorio al paciente --%>
                <div style="color: cornflowerblue">
                    <h3>Interrogatorio al paciente</h3>
                </div>
                <div>
                    <asp:TextBox ID="ResumenAntecedente" runat="server" TextMode="MultiLine" CssClass="materialize-textarea" Font-Size="Medium"></asp:TextBox>
                </div>
                <%-- Datos fisicos --%>
                <div style="color: cornflowerblue">
                    <h3>Datos físicos</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-4">
                        <asp:TextBox ID="Talla" runat="server" Font-Size="Medium"></asp:TextBox>
                        <div>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Solo números, sin puntos" ForeColor="Red" BackColor="Yellow" ControlToValidate="Talla" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
                        </div>
                        <label for="Talla">Talla(cm)</label>
                    </div>
                    <div class="input-field  col-md-4 ">
                        <asp:TextBox ID="Temperatura" runat="server" Font-Size="Medium"></asp:TextBox>
                        <div class=" ">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="Solo números" ForeColor="Red" BackColor="Yellow" ControlToValidate="Temperatura" ValidationExpression="^\d+(?:[\.\,]\d+)?$"></asp:RegularExpressionValidator>
                        </div>
                        <label for="Talla">Temperatura</label>
                    </div>
                    <div class="input-field  col-md-4">
                        <asp:TextBox ID="Peso" runat="server" Font-Size="Medium"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Solo números" ForeColor="Red" BackColor="Yellow" ControlToValidate="Peso" ValidationExpression="\d*\.?\d*" Font-Size="Medium"></asp:RegularExpressionValidator>
                        <label for="Peso">Peso(Kg)</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col-md-4">
                        <asp:TextBox ID="RtimoCardiaco" runat="server" Font-Size="Medium"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Solo números" ForeColor="Red" BackColor="Yellow" ControlToValidate="RtimoCardiaco" ValidationExpression="\d*\.?\d*" Font-Size="Medium"></asp:RegularExpressionValidator>
                        <label for="Peso">Ritmo Cardiaco</label>
                    </div>
                    <div class="input-field col-md-2">
                        <asp:TextBox ID="Presion" runat="server" Font-Size="Medium"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Solo números" ForeColor="Red" BackColor="Yellow" ControlToValidate="Presion" ValidationExpression="^[0-9]*" Font-Size="Medium"></asp:RegularExpressionValidator>
                        <label for="Presion">Presión Arterial(mm)</label>
                    </div>
                    <div class="input-field col-md-2">
                        <asp:TextBox ID="Presion1" runat="server" Font-Size="Medium"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Solo números" ForeColor="Red" BackColor="Yellow" ControlToValidate="Presion1" ValidationExpression="^[0-9]*" Font-Size="Medium"></asp:RegularExpressionValidator>
                        <label for="Presion">Presión Arterial(Hg)</label>
                    </div>
                </div>
                <%-- Resumen Exploración Física --%>
                <div style="color: cornflowerblue">
                    <h3>Resumen Exploración Física</h3>
                </div>
                <div>
                    <asp:TextBox ID="ResumenExploracion" runat="server" TextMode="MultiLine" CssClass="materialize-textarea" Font-Size="Medium"></asp:TextBox>
                </div>
                <%-- Diagnóstico --%>
                <div style="color: cornflowerblue">
                    <h3>Diagnóstico</h3>
                </div>
                <div class="row">
                    <div class="col s12 materialize-textarea " >
                        <asp:TextBox runat="server" ID="autocompleteDiagnostico" class="autocomplete" Font-Size="Medium" CssClass="materialize-textarea"> </asp:TextBox>
                    </div>
                    <asp:Panel ID="PanelAgregarLista" runat="server" Visible="false">
                        <div class="col-md-2">
                            <asp:Button ID="ButtonAgregarLista" runat="server" Text="Agregar" />
                        </div>
                        <div class="col-md-4">
                            <asp:TextBox ID="TextBoxAgregarLista" runat="server"></asp:TextBox>
                        </div>
                    </asp:Panel>
                </div>
                <%-- PLan de tratamientro --%>
                <div style="color: cornflowerblue">
                    <h3>Plan de Tratamiento</h3>
                </div>
                <div>
                    <asp:TextBox ID="PlanTratamiento" runat="server" TextMode="MultiLine" CssClass="materialize-textarea" Font-Size="Medium"></asp:TextBox>
                </div>
                <div style="color: cornflowerblue">
                    <h3>Días de reposo</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-4">
                        <asp:TextBox ID="DiasReposo" runat="server" Font-Size="Medium"></asp:TextBox>
                        <div>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="Solo números, sin puntos" ForeColor="Red" BackColor="Yellow" ControlToValidate="Talla" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
                        </div>
                        <label for="Talla">Días</label>
                    </div>

                </div>
                <div class="row">
                    <div class="col-md-5"></div>
                    <div class="col-md-2">
                        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
                    </div>
                    <div class="col-md-3"></div>

                    <div class="col-md-2">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="\IMAG\Iconos\impresora.jpg" Height="100" Width="100" OnClick="Imprimir_Click" />
                        <%--   <asp:Button ID="Imprimir" runat="server" Text="Imprimir" OnClick="Imprimir_Click" />--%>
                    </div>
                </div>

                <%--<input type="button" value="Imprimir" class="no-print"  href="javascript:;" onclick="ImprimeDiv"  style="float: right"/>--%>
            </div>
            <!---Odontograma-->
            <div id="odontograma" class="tab-pane fade">
                <nav class="" data-target="red" style="top: auto; z-index: auto">
                    <div class="nav-wrapper #33691e light-green darken-4 white-text">
                        <div class="container center-align">
                        </div>
                    </div>
                </nav>
                <%--Odontograma --%>
                <div class="image-caption ">
                    <img class="materialboxed responsive-img" width="100" height="100" src="\IMAG\Iconos\odontograma.jpg">
                </div>
                <div style="color: cornflowerblue">
                    <h3>Llenado de odontograma</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-2">
                        <asp:TextBox ID="NumeroDiente" runat="server" Font-Size="Medium"></asp:TextBox>

                        <label for="Talla">Diente</label>
                    </div>
                    <div class="input-field  col-md-5 ">
                        <asp:TextBox ID="DiagnosticoDiente" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Talla">Diagnostico</label>
                    </div>
                    <div class="input-field  col-md-5">
                        <asp:TextBox ID="TratamientoDiente" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Peso">Tratamiento</label>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field  col-md-9">
                        <asp:TextBox ID="ComentarioDiente" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Talla">Comentario</label>
                    </div>

                    <div class="col-md-3">
                        <asp:Button ID="AgregarOdontograma" runat="server" Text="Agregar" OnClick="AgregarOdontograma_Click" />
                    </div>
                    <div class="col-md-5">
                        <asp:ImageButton ID="ImprimirDental" runat="server" ImageUrl="\IMAG\Iconos\impresora.jpg" Height="100" Width="100" OnClick="ImprimirDental_Click" />
                        <%--   <asp:Button ID="Imprimir" runat="server" Text="Imprimir" OnClick="Imprimir_Click" />--%>
                    </div>
                </div>

                <div class="row">
                    <asp:GridView ID="GridViewOdontogtrama" runat="server" CssClass="highlight centered responsive-table table table-striped table table-hover" Font-Size="Medium">
                    </asp:GridView>
                </div>

            </div>
            <!---Psicologo-->
            <div id="psicologo" class="tab-pane fade">
                <nav class="" data-target="red" style="top: auto; z-index: auto">
                    <div class="nav-wrapper #311b92 deep-purple darken-4 white-text">
                        <div class="container center-align">
                        </div>
                    </div>
                </nav>
                <div style="color: cornflowerblue">
                    <h3>Consulta psicologica</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-12 ">
                        <asp:TextBox ID="DiagnosticoPsicologo" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Talla">Diagnostico</label>
                    </div>
                    <div class="input-field  col-md-12">
                        <asp:TextBox ID="TratamientoPsicologo" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Peso">Tratamiento</label>
                    </div>
                    <div class="input-field  col-md-12">
                        <asp:TextBox ID="ComentarioPsicologo" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Talla">Comentario</label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3  ">
                    </div>
                    <div class="col-md-3">
                        <asp:Button ID="Button2" runat="server" Text="Agregar" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--FIN Contenido de tabs-->

    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            //Autocomplete
            $(function () {
                $.ajax({
                    type: 'GET',
                    url: 'https://raw.githubusercontent.com/octaviovs/CIE10/master/cie10.json',
                    success: function (response) {
                        var myArray = $.parseJSON(response);
                        var renglones = {};

                        for (var i = 0; i < myArray.length; i++) {
                            renglones[myArray[i].d] = null;
                        }

                        $('input.autocomplete').autocomplete({
                            data: renglones,
                            limit: 13, // The max amount of results that can be shown at once. Default: Infinity.
                        });
                    }
                });
            });
        });
    </script>


</asp:Content>

