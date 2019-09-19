<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HistorialClinico.aspx.cs" Inherits="MVPG52.HistorialClinico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .row .col.s6 {
            left: 0;
        }

        input:not([type]):disabled, input:not([type])[readonly="readonly"], input[type=text]:disabled, input[type=text][readonly="readonly"], input[type=password]:disabled, input[type=password][readonly="readonly"], input[type=email]:disabled, input[type=email][readonly="readonly"], input[type=url]:disabled, input[type=url][readonly="readonly"], input[type=time]:disabled, input[type=time][readonly="readonly"], input[type=date]:disabled, input[type=date][readonly="readonly"], input[type=datetime]:disabled, input[type=datetime][readonly="readonly"], input[type=datetime-local]:disabled, input[type=datetime-local][readonly="readonly"], input[type=tel]:disabled, input[type=tel][readonly="readonly"], input[type=number]:disabled, input[type=number][readonly="readonly"], input[type=search]:disabled, input[type=search][readonly="readonly"], textarea.materialize-textarea:disabled, textarea.materialize-textarea[readonly="readonly"] {
            color: black;
        }
    </style>




    <div class="jumbotron  card-panel  accent-1#ffffff white">
        <nav class="" data-target="red" style="top: auto; z-index: auto">
            <div class="nav-wrapper #33691e light-green darken-4">
                <div class="container center-align">
                    <h3 class="">Historial Clínico</h3>

                </div>
            </div>
        </nav>
        <br />
        <div class="row ">
            <h4>Para buscar una historial clínico ingrese en la caja de texto la matrícula.</h4>
            <div class="col s2">
                <asp:Label ID="Label1" runat="server" Text="Matrícula :" Font-Size="Medium"></asp:Label>
            </div>
            <div class="col s2">
                <asp:TextBox ID="txtId" runat="server" Font-Size="Medium" required=""></asp:TextBox>
            </div>
            <div class="col s2">
                <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" AutoPostBack="true" />
            </div>
            <div class="col s6 " style="color: red">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Ingrese matrícula"> </asp:RequiredFieldValidator>
            </div>
        </div>
        <asp:Panel ID="PanelCuestionario" runat="server" Visible="true">
            <div id="HistorialMedico" class="tab-pane fade in active">

                <ul class="nav nav-tabs">
                    <li class="active"><a data-toggle="tab" href="#Medico" class="card-panel #2196f3 blue white-text">Médico</a></li>
                    <li><a data-toggle="tab" href="#Dental" class="card-panel #ff6f00 amber darken-4 white-text">Dental</a></li>
                    <li><a data-toggle="tab" href="#Psicologo" class="card-panel #d81b60 pink darken-1 white-text">Psicológico</a></li>

                </ul>
                <asp:Panel ID="PanelPreguntas" runat="server" Visible="false">
                    <div class="tab-content ">
                        <div id="Medico" class="tab-pane fade in active">
                            <%-- Banner de cuestionario Dentista y preguntas --%>

                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Resultados</div>
                                <div class="panel-body">
                                    <p>Respuestas del alumno</p>
                                </div>
                                <!-- Table -->
                                <div class="table-responsive">
                                    <table class="table table-bordered  table-striped table-hover">
                                        <tr>
                                            <th>Pregunta</th>
                                            <th>Respuesta(S)</th>
                                        </tr>
                                        <%-- P1 D --%>
                                        <tr>
                                            <td><h4>1.-Alimentación diaria </h4></td>
                                            <td><asp:TextBox ID="m1" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>2.-Veces que realiza ejercicio por semana</h4></td>
                                            <td> <asp:TextBox ID="m2" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td> <h4>3.-Tipo de sangre</h4></td>
                                            <td> <asp:TextBox ID="m3" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>4.-Frecuencia de consumo de bebidas alcóholicas</h4></td>
                                            <td><asp:TextBox ID="m4" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>5.-Frecuencia de consumo de tabaco</h4></td>
                                            <td><asp:TextBox ID="m5" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>6.-Consumo de drogas ilegales</h4></td>
                                            <td><asp:TextBox ID="m6" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td> <h4>7.-Padecimiento de alergias</h4></td>
                                            <td><asp:TextBox ID="m7" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>8.-Enfermedades que padece</h4></td>
                                            <td><asp:TextBox ID="m8" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>9.-Frecuencia con que se baña</h4></td>
                                            <td>  <asp:TextBox ID="m9" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>10.-Tipo de baño que hay donde vive</h4></td>
                                            <td><asp:TextBox ID="m10" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td> <h4>11.-Vive en lugares con enfermedades como el Dengue,Paludismo,etc</h4></td>
                                            <td><asp:TextBox ID="m11" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td> <h4>12.-Está en tratamientos hormonales</h4></td>
                                            <td><asp:TextBox ID="m12" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>13.-Toma anticonceptivos</h4></td>
                                            <td><asp:TextBox ID="m13" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>14.-¿Alguna vez le practicaron cirugía?</h4></td>
                                            <td> <asp:TextBox ID="m14" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td> <h4>15.-¿Le han practicado una transfusión sanguínea?</h4></td>
                                            <td> <asp:TextBox ID="m15" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>16.-¿Está en contacto directo con pacientes diagnosticados con VIH o Tuberculosis?</h4></td>
                                            <td>   <asp:TextBox ID="m16" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>17.-Estatura(cm)</h4></td>
                                            <td><asp:TextBox ID="m17" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>18.-Peso(kg)</h4></td>
                                            <td> <asp:TextBox ID="m18" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>19.-Cálculo IMC</h4></td>
                                            <td><asp:TextBox ID="m19" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>20.-¿Su regla es regular?</h4></td>
                                            <td><asp:TextBox ID="m20" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                         <tr>
                                            <td><h4>21.-¿Está embarazada?</h4></td>
                                            <td><asp:TextBox ID="m21" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>  <h4>22.-¿Está lactando?</h4></td>
                                            <td> <asp:TextBox ID="m22" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>23.-Enfermedades que padecieron los abuelos</h4></td>
                                            <td><asp:TextBox ID="m23" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td><h4>24.-Enfermedades que padecieron los padres</h4></td>
                                            <td> <asp:TextBox ID="m24" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox></td>
                                        </tr>
                                          <tr>
                                            <td><h4>25.-Enfermedades que padecieron los hermanos primos y tíos</h4></td>
                                            <td><asp:TextBox ID="m25" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>                       
                            <div class="center-align">
                                <asp:Button ID="Button2" runat="server" Text="Imprimir historial-Médico" OnClick="Button2_Click" />
                            </div>
                        </div>
                        <div id="Dental" class="tab-pane fade">
                            <%-- Banner de cuestionario Dentista y preguntas --%>


                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Resultados</div>
                                <div class="panel-body">
                                    <p>Respuestas del alumno</p>
                                </div>

                                <!-- Table -->
                                <div class="table-responsive">
                                    <table class="table table-bordered  table-striped table-hover">
                                        <tr>
                                            <th>Pregunta</th>
                                            <th>Respuesta(S)</th>
                                        </tr>
                                        <%-- P1 D --%>
                                        <tr>
                                            <td>
                                                <h4>1.-Última vez que acudió al dentista</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d1" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <%-- P2 D --%>
                                        <tr>
                                            <td>
                                                <h4>2.-Motivo de su última consulta dental</h4>

                                            </td>
                                            <td>
                                                <asp:TextBox ID="d2" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <%-- P3 D --%>
                                        <tr>
                                            <td>
                                                <h4>3.-¿Cómo calificó su boca?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d3" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <%-- P4 D --%>
                                        <tr>
                                            <td>
                                                <h4>4.-¿Cuantas veces al día cepilla sus dientes?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d4" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox>

                                            </td>

                                        </tr>
                                        <%-- P5 D --%>
                                        <tr>
                                            <td>
                                                <h4>5.-¿Le truena la mandíbula cuando abre mucho la boca?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d5" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox>
                                            </td>

                                        </tr>
                                        <%-- P6 D --%>
                                        <tr>
                                            <td>
                                                <h4>6.-¿Le sangran las encias cuando se cepilla los dientes?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d6" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <%-- P7 D --%>
                                        <tr>
                                            <td>
                                                <h4>7.-¿Tiene dificultad para abrir la boca en algunas ocasiones?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d7" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox>
                                            </td>

                                        </tr>
                                        <%-- P8 D --%>
                                        <tr>
                                            <td>
                                                <h4>8.-¿Se ha quedado alguna vez con la boca abierta y ha tenido incapacidad para cerrarla?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d8" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox>
                                            </td>

                                        </tr>
                                        <%-- P09 D --%>
                                        <tr>
                                            <td>
                                                <h4>9.-¿Has tenido perforaciones en la boca (piercings)?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="d9" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox>
                                            </td>

                                        </tr>
                                        <%-- P10 D --%>
                                        <tr>
                                            <td>
                                                <h4>10.-¿Ha presentado mal aliento?</h4>

                                            </td>
                                            <td>
                                                <asp:TextBox ID="d10" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox>
                                            </td>

                                        </tr>
                                        <%-- P11 D --%>
                                        <tr>
                                            <td>
                                                <h4>11.-¿Tienes el hábito de morderte las uñas, tallarte  o morder objetos?</h4>

                                            </td>
                                            <td>
                                                <asp:TextBox ID="d11" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox>

                                            </td>

                                        </tr>

                                    </table>
                                </div>
                            </div>






                            <div class="center-align">
                                <asp:Button ID="Button3" runat="server" Text="Imprimir historial-Dental" OnClick="Button3_Click" />
                            </div>
                        </div>
                        <div id="Psicologo" class="tab-pane fade">
                            <%-- Banner de cuestionario Dentista y preguntas --%>
                            <div class="panel panel-default">
                                <!-- Default panel contents -->
                                <div class="panel-heading">Resultados</div>
                                <div class="panel-body">
                                    <p>Respuestas del alumno</p>
                                </div>

                                <!-- Table -->
                                <div class="table-responsive">
                                    <table class="table table-bordered  table-striped table-hover">
                                        <tr>
                                            <th>Pregunta</th>
                                            <th>Respuesta</th>
                                        </tr>
                                        <%-- P1 P --%>
                                        <tr>
                                            <td>
                                                <h4>1.-¿La Universidad Politécnica de Tulancingo fue su primera opción?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p1" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>2.-¿La carrera que eligió fue su primera opción?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p2" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>3.-¿Qué tan satisfecho está con la elección de carrera?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p3" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>4.-¿Sabe cuál es su perfil vocacional?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p4" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>5.-¿Cómo es la relación con sus abuelos?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p5" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>6.-¿Cómo es la relación con su mamá?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p6" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>7.-¿Cómo es la relación con su papá?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p7" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>8.-¿Cómo es la relación con sus hermanos?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p8" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>9.-¿Cuál es el acontecimiento más relevante de su infancia?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p9" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>10.-¿Cuál es el acontecimiento más relevante de su adolesencia?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p10" TextMode="MultiLine" runat="server" ReadOnly="True" Font-Size="Medium" CssClass="materialize-textarea"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>11.-¿Cómo es su autoestima?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p11" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>12.-¿Cómo considera su capacidad para relacionarse con otras personas?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p12" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>13.-¿Tiene algún proyecto de vida?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p13" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>14.-¿Le gustaría recibir orientación psicológica?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p14" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>15.-¿Número de hijo que es?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p15" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>16.-¿Con quién vive actualmente?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p16" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>17.-¿Cuales son sus preferencias sexuales?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p17" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>18.-¿Ha asistido a terapia psicológica?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p18" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <h4>19.-¿Cuantas horas duermes diariamente?</h4>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="p19" runat="server" ReadOnly="True" Font-Size="Medium"></asp:TextBox></td>
                                        </tr>
                                    </table>

                                  
                                </div>
                                <div class="row">
                                    <div class="col-md-4"></div>
                                    <div class="col-md-2">
                                        
                                        <asp:Button ID="Button4" runat="server" Text="Imprimir Historial-Psicológico" OnClick="Button4_Click" />
                                    
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </asp:Panel>

            </div>
        </asp:Panel>
        <asp:Panel ID="PanelCuestionarioMensaje" runat="server" Visible="false" ForeColor="Red">
            <h2 class="center-align">No encontrado</h2>
        </asp:Panel>
    </div>


</asp:Content>
