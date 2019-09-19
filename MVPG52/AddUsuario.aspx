<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUsuario.aspx.cs" Inherits="MVPG52.AddUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        textarea {
            max-width: none;
        }

        label {
            font-size: medium;
        }
    </style>
    <div class="jumbotron card-panel teal white ">

        <nav class="" data-target="red" style="top: auto; z-index: auto">
            <div class="nav-wrapper #311b92 deep-purple darken-1">
                <div class="container center-align">
                    <h3 class="">Agrear Usuarios</h3>
                    <ul id="nav-mobile2" class="right hide-on-med-and-down">
                    </ul>
                </div>
            </div>
        </nav>
        <br />
        <div class="row">
            <ul class="collapsible " data-collapsible="accordion" style="font-size: x-large">
                <li>
                    <div class="collapsible-header"><i class="material-icons">person_pin</i>Descripción.</div>
                    <div class="collapsible-body  jumbotron  card-panel teal white">
                        <p style="font-size: medium">Se podran agrear personal medico al sistema  </p>

                    </div>
                </li>
            </ul>
        </div>

        <ul class="nav nav-tabs">
            <li class="active">
                <a data-toggle="tab" href="#Consulta" class="card-panel #2196f3 blue white-text">Consulta/Baja</a>
            </li>
            <li>
                <a data-toggle="tab" href="#Alta" class="card-panel #ff6f00 amber darken-4 white-text">Alta</a>
            </li>
            <li>
                <asp:HyperLink ID="HyperLinkMedico" runat="server" data-toggle="tab" href="#Modificacion" class="card-panel #d81b60 pink darken-1 white-text">Modificación</asp:HyperLink>
            </li>
        </ul>

        <!--Contenido de tabs-->
        <div class="tab-content">
            <!----Pestañana 1-->
            <div id="Consulta" class="tab-pane fade in active">
                <nav class="" data-target="red" style="top: auto; z-index: auto">
                    <div class="nav-wrapper #2196f3 blue white-text">
                        <div class="container center-align">
                            <h3 class=""></h3>
                            <ul id="nav-mobile2" class="right hide-on-med-and-down">
                            </ul>
                        </div>
                    </div>
                </nav>
                <asp:GridView ID="GridViewEmpleados" runat="server" Font-Size="Small" CssClass="highlight  responsive-table table table-striped table table-hover " OnRowCommand="GridViewEmpleados_RowCommand">
                    <Columns>
                        <asp:TemplateField ShowHeader="False" HeaderText="Baja">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Eliminar">
                                    <i class="Tiny material-icons">error_outline</i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField ShowHeader="False" HeaderText="Modificacion">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Modificacion">
                                    <i class="Tiny material-icons">create</i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False" HeaderText=" " Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <!----Pestañana 2-->
            <div id="Alta" class="tab-pane fade">
                <nav class="" data-target="red" style="top: auto; z-index: auto">
                    <div class="nav-wrapper #ff6f00 amber darken-4 white-text">
                        <div class="container center-align">
                            <h3 class=""></h3>
                            <ul id="nav-mobile2" class="right hide-on-med-and-down">
                            </ul>
                        </div>
                    </div>
                </nav>


                <%-- Datos generales --%>
                <div style="color: cornflowerblue">
                    <h3>Datos Generales</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-4">
                        <asp:TextBox ID="Nombre" runat="server" Font-Size="Medium"></asp:TextBox>
                        <div>
                        </div>
                        <label for="Nombre">Nombre</label>
                    </div>
                    <div class="input-field  col-md-4 ">
                        <asp:TextBox ID="Apellido" runat="server" Font-Size="Medium"></asp:TextBox>
                        <div class=" ">
                        </div>
                        <label for="Apellido">Apellido</label>
                    </div>
                    <div class="col-md-4">
                        <label>Genero</label>
                        <asp:DropDownList ID="GeneroList" runat="server">
                            <asp:ListItem Text="Mujer" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Hombre" Value="1"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col-md-4">
                        <asp:TextBox ID="Direccion" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Direccion">Direccion</label>
                    </div>
                    <div class="input-field col-md-4">
                        <asp:TextBox ID="Correo" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Correo">Correo</label>
                    </div>
                    <div class="input-field col-md-4">
                        <asp:TextBox ID="Telefono" runat="server" Font-Size="Medium"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ControlToValidate="Telefono" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>

                        <label for="Correo">Telefono</label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4 ">
                        <label>Fecha</label>
                        <asp:TextBox ID="TextBoxFecha" runat="server" class="datepicker" Text="" required=" " Font-Size="Medium"></asp:TextBox>
                    </div>
                </div>
                <div style="color: cornflowerblue">
                    <h3>Datos Especificos</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-4">
                        <asp:TextBox ID="NumeroControl" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="NumeroControl">Numero de control</label>
                    </div>
                    <div class="input-field  col-md-4">
                        <asp:TextBox ID="NumeroControlReoetir" runat="server" Font-Size="Medium"></asp:TextBox>

                        <label for="NumeroControlReoetir">Repetir Numero Control </label>
                    </div>


                </div>
                <div class="row">
                    <div class="input-field  col-md-4 ">
                        <asp:TextBox ID="Clave" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Clave">Contraseña</label>
                    </div>
                    <div class="input-field  col-md-4 ">
                        <asp:TextBox ID="ClaveRepetir" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="ClaveRepetir">Repetir Contraseña</label>
                    </div>

                </div>
                <div class="row">
                    <div class="input-field  col-md-4">
                        <asp:TextBox ID="Cedula" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Cedula">Cedula</label>
                    </div>
                    <div class="col-md-4">
                        <label>Especialidad</label>
                        <asp:DropDownList ID="RolEspecialista" runat="server">
                            <asp:ListItem Text="Médico" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Dental" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Psicologico" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-4">
                        <label>Rol</label>
                        <asp:DropDownList ID="Rol" runat="server">
                            <asp:ListItem Text="Especialista" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Administrador" Value="3"></asp:ListItem>

                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field  col right-align">
                        <asp:Button ID="Guardar" runat="server" Text="Guardar" OnClick="Guardar_Click" />
                    </div>

                </div>


                <%--  --%>
            </div>
            <!----Pestañana 3-->
            <div id="Modificacion" class="tab-pane fade">
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
                    <h3>Datos Generales</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-3">
                        <asp:TextBox ID="Nombre1" runat="server" Font-Size="Medium"></asp:TextBox>
                        <div>
                        </div>
                        <label for="Nombre1">Nombre</label>
                    </div>
                    <div class="input-field  col-md-3">
                        <asp:TextBox ID="Apellido1" runat="server" Font-Size="Medium"></asp:TextBox>
                        <div class=" ">
                        </div>
                        <label for="Apellido1">Apellido</label>
                    </div>
                    <div class="input-field col-md-2">
                        <asp:TextBox ID="Genero1" runat="server" Font-Size="Medium" Enabled="false" ></asp:TextBox>
                      
                        <label for="Genero1">Genero</label>
                    </div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="DropDownListGenero" runat="server">
                            <asp:ListItem Text="Genero" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Masculino" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Femenino" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field col-md-4">
                        <asp:TextBox ID="Direccion1" runat="server" Font-Size="Medium"></asp:TextBox>

                        <label for="Direccion1">Direccion</label>
                    </div>
                    <div class="input-field col-md-4">
                        <asp:TextBox ID="Correo1" runat="server" Font-Size="Medium"></asp:TextBox>

                        <label for="Correo1">Correo</label>
                    </div>
                    <div class="input-field col-md-4">
                        <asp:TextBox ID="Telefono1" runat="server" Font-Size="Medium"></asp:TextBox>

                        <label for="Telefono1">Telefono</label>
                    </div>
                </div>

                <div style="color: cornflowerblue">
                    <h3>Datos Especificos</h3>
                </div>
                <div class="row">
                    <div class="input-field  col-md-3">
                        <asp:TextBox ID="NumeroControl1" runat="server" Font-Size="Medium"></asp:TextBox>

                        <label for="NumeroControl1">Numero de control</label>
                    </div>
                    <div class="input-field  col-md-3">
                        <asp:TextBox ID="Clave1" runat="server" Font-Size="Medium"></asp:TextBox>

                        <label for="Clave1">Contraseña</label>
                    </div>
                    <div class="input-field  col-md-3">
                        <asp:TextBox ID="EspecialidadCAmbio" runat="server" Font-Size="Medium" Enabled="false"></asp:TextBox>

                        <label for="EspecialidadCAmbio">Especialidad</label>
                    </div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="DropDownListEspecilaidadesCambio" runat="server">
                            <asp:ListItem Text="Especialidad" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Médico" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Dental" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Psicologico" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row">
                    <div class="input-field  col-md-3">
                        <asp:TextBox ID="Cedula1" runat="server" Font-Size="Medium"></asp:TextBox>
                        <label for="Cedula1">Cedula</label>
                    </div>

                </div>
                <div class="row">
                    <div class="input-field  col right-align">
                        <asp:Button ID="Cambiar" runat="server" Text="Cambiar" OnClick="Cambiar_Click" />
                    </div>

                </div>

            </div>


        </div>
    </div>
</asp:Content>
