<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HistorialCitas.aspx.cs" Inherits="MVPG52.HistorialCitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        textarea {
            max-width: none;
        }
    </style>
    <div class="jumbotron card-panel teal white ">

        <nav class="" data-target="red" style="top: auto; z-index: auto">
            <div class="nav-wrapper #311b92 deep-purple darken-1">
                <div class="container center-align">
                    <h3 class="">Historial de Citas</h3>
                    <ul id="nav-mobile2" class="right hide-on-med-and-down">
                    </ul>
                </div>
            </div>
        </nav>
        <br />
        <div class="row">
            <ul class="collapsible " data-collapsible="accordion" style="font-size: x-large">
                <li>
                    <div class="collapsible-header"><i class="material-icons">person_pin</i>Ayuda.</div>
                    <div class="collapsible-body  jumbotron  card-panel teal white">
                        <p style="font-size: medium">1.-Seleccione el tipo de área </p>
                        <p style="font-size: medium">2.-Ingrese un id </p>
                        <p style="font-size: medium">3.-En historial seleccion uno </p>
                        <p style="font-size: medium">4.-En la pestaña de detalle, se mostrara informacion mas detallada</p>
                    </div>
                </li>
            </ul>
        </div>

        <div class="row ">
            <div class="col-md-3">
                <asp:TextBox ID="txtMatricula" runat="server" Font-Size="Medium" placeholder="Matrícula" required=""></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:DropDownList ID="DropDownListOpciones" runat="server" CssClass="icons" AutoPostBack="true" OnSelectedIndexChanged="ActivarPestana">
                    <asp:ListItem Value="0" Text="Seleccione"> </asp:ListItem>
                    <asp:ListItem Value="1" Text="Médico"> </asp:ListItem>
                    <asp:ListItem Value="2" Text="Dental"> </asp:ListItem>
                    <asp:ListItem Value="4" Text="Odontograma"> </asp:ListItem>
                    <asp:ListItem Value="3" Text="Psicólogo"> </asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="col-md-2">
                <asp:Button ID="ButtonBUscar" runat="server" Text="Buscar" OnClick="ButtonBUscar_Click" CssClass=" " />
            </div>
            <div class="col-md-2" style="color: red">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtMatricula" runat="server" ErrorMessage="Vacio"></asp:RequiredFieldValidator>
            </div>

        </div>

        <ul class="nav nav-tabs ">
            <li class="active"><a data-toggle="tab" href="#Historial" class="card-panel #2196f3 blue white-text">Historial</a></li>

            <li>
                <asp:HyperLink ID="HyperLinkMedico" runat="server" Visible="false" data-toggle="tab" href="#medico" class="card-panel #d81b60 pink darken-1 white-text">Médico/Dental</asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="HyperLinkOdontograma" runat="server" Visible="false" data-toggle="tab" href="#odontograma" class="card-panel  #33691e light-green darken-4 white-text">Odontograma</asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="HyperLinkPsicologo" runat="server" Visible="false" data-toggle="tab" href="#medico" class="card-panel #311b92 deep-purple darken-4 white-text">Psicologico</asp:HyperLink>
            </li>
        </ul>
        <div class="tab-content">
            <%-- Historial --%>
            <div id="Historial" class="tab-pane fade in active">
                <asp:Panel ID="PanelMensaje" runat="server" Visible="false">
                    <h2 style="color: red">No encontrado
                    </h2>
                </asp:Panel>
                <asp:GridView ID="GridViewHistorialCitas" runat="server" OnRowCommand="GridView2_RowCommand" CssClass="highlight centered responsive-table table table-striped table table-hover">
                    <Columns>
                        <asp:TemplateField ShowHeader="False" HeaderText=" ">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandName="Ver">
                                    <span class=" label label-info">Detalle</span>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False" HeaderText=" ">
                            <ItemTemplate>
                                <asp:Label ID="Label1" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <div id="medico" class="tab-pane fade">

                <a>Datos del médico</a>
                <div class="row">
                    <div class="col s2">
                        <asp:Label ID="Label2" runat="server" Text="Nombre:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="labelNombreMedico" runat="server" Text="Nombre" Font-Size="Medium"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="Label5" runat="server" Text="Matrícula:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="labelIdMedico" runat="server" Text="Matrícula" Font-Size="Medium"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="Label4" runat="server" Text="Especialidad:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="LabelEspecialidad" runat="server" Text="Especialidad" Font-Size="Medium"></asp:Label>
                    </div>
                </div>
                <a>Datos del alumno</a>
                <div class="row">
                    <div class="col s2">
                        <asp:Label ID="Label1" runat="server" Text="Alumno :" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s4">
                        <asp:Label ID="LabelNombreAlumno" runat="server" Text="Nombre" Font-Size="Medium"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="Label3" runat="server" Text="Matrícula:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="LabelMatriculaAlumno" runat="server" Text="Matrícula" Font-Size="Medium"></asp:Label>
                    </div>
                    <div class="col s2 ">
                        <asp:Label ID="LabelIdCita" runat="server" Text="Id:" Font-Size="Medium" Visible="false"></asp:Label>
                    </div>
                </div>
                <a>Fecha</a>
                <div class="row">
                    <div class="col s2">
                        <asp:Label ID="Label6" runat="server" Text="Fecha" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="LabelFecha" runat="server" Text="Fecha" Font-Size="Medium"></asp:Label>
                    </div>
                    <div class="col s2">
                        <asp:Label ID="Label7" runat="server" Text="Hora:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    </div>
                    <div class="col s4">
                        <asp:Label ID="labelHora" runat="server" Text="hora" Font-Size="Medium"></asp:Label>
                    </div>

                </div>
                <a>Interrogatorio al paciente</a>
                <div class="row">
                    <div class="col s12">
                        <asp:TextBox ID="ResumenAntecedente" runat="server" TextMode="MultiLine" ReadOnly="True" Font-Size="Medium" ForeColor="Black" class="materialize-textarea"></asp:TextBox>
                    </div>
                </div>

                <a>Datos físicos</a>
                <%-- Talla y peso --%>
                <asp:Panel ID="DatosFisicos" runat="server" Visible="true">
                      <div class="row">
                    <div class="col-md-2">
                        <asp:Label ID="Label8" runat="server" Text="Talla:"></asp:Label>
                    </div>
                    <div class="col-md-2">
                        <asp:TextBox ID="Talla" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                    </div>
                    <div class="col-md-2">
                        <asp:Label ID="Label9" runat="server" Text="Peso:"></asp:Label>
                    </div>
                    <div class="col-md-2">
                        <asp:TextBox ID="Peso" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                    </div>

                    <div class="col-md-2">
                        <asp:Label ID="Label11" runat="server" Text="Temperatura:  "></asp:Label>
                    </div>
                    <div class="col-md-2">
                        <asp:TextBox ID="Temperatura" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                    </div>


                </div>
                <div class="row">
                    <div class="col-md-2">
                        <asp:Label ID="Label10" runat="server" Text="Presion:"></asp:Label>
                    </div>
                    <div class="col-md-2">
                        <asp:TextBox ID="Presion" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="Label12" runat="server" Text="Ritmo cardiaco:"></asp:Label>
                    </div>
                    <div class="col-md-1">
                        <asp:TextBox ID="Ritmocaridaco" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                    </div>
                </div>


                </asp:Panel>
              



                <a>Resumen Exploración Física</a>
                <div>
                    <asp:TextBox ID="ResumenExploracion" runat="server" TextMode="MultiLine" CssClass="materialize-textarea" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                </div>
                <a>Diagnóstico</a>
                <div>
                    <asp:TextBox ID="TextBoxDiagnostico" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                </div>
                <a>Plan de Tratamiento</a>
                <div>
                    <asp:TextBox ID="PlanTratamiento" runat="server" TextMode="MultiLine" CssClass="materialize-textarea" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                </div>
                <a>Días de reposo</a>
                <div>
                    <asp:TextBox ID="Diasreposo" runat="server" ReadOnly="True" Font-Size="Medium" ForeColor="Black"></asp:TextBox>
                </div>
                <div class="center-align">
                    <asp:Button ID="Button1" runat="server" Text="Imprimir Historial" OnClick="Button1_Click" />
                </div>
            </div>

            <div id="odontograma" class="tab-pane fade">
                <div style="color: cornflowerblue">
                    <h3>Llenado de odontograma</h3>
                </div>
                <div class="row">
                    <a>Diente</a>
                    <div class="input-field  col-md-12">
                        <asp:TextBox ID="NumeroDiente" runat="server" Font-Size="Medium"  ReadOnly="true" ForeColor="Black" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
                    </div>
                     <a>Diagnóstico</a>
                    <div class="input-field  col-md-12 ">
                        <asp:TextBox ID="DiagnosticoDiente" runat="server" Font-Size="Medium" ReadOnly="true" ForeColor="Black" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
                    </div>

                    <a>Tratamiento</a>
                    <div class="input-field  col-md-12">
                        <asp:TextBox ID="TratamientoDiente" runat="server" Font-Size="Medium" ReadOnly="true" ForeColor="Black" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
                       
                    </div>
                     <a>Comentario</a>
                    
                    <div class="input-field  col-md-12">
                        <asp:TextBox ID="ComentarioDiente" runat="server" Font-Size="Medium" ReadOnly="true" ForeColor="Black" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
