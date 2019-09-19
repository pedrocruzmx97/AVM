<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CitaRapida.aspx.cs" Inherits="MVPG52.CitaRapida" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron  card-panel #fafafa grey lighten-5 ">
        <nav class="" data-target="red" style="top: auto; z-index: auto">
            <div class="nav-wrapper #ff6f00 amber darken-4">
                <div class="container center-align">
                    <h3 class="">Cita Rápida</h3>
                    <ul id="nav-mobile2" class="right hide-on-med-and-down">
                    </ul>
                </div>
            </div>
        </nav>

        <div class="jumbotron ">
            <div class="row">
                <h3>Datos del médico</h3>
                <div class="col-md-6 " style="font-size: x-large">
                    <asp:Label ID="LabelNombre" runat="server" Text="Nombre:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    <asp:Label ID="LabelNombreMedico" runat="server" Text=" " Font-Size="Medium"></asp:Label>
                </div>
                <div class="col-md-6 ">
                    <asp:Label ID="LabelEsp" runat="server" Text="Especialidad:" Font-Size="Medium" Font-Bold="True"></asp:Label>
                    <asp:Label ID="LabelEspecialidad" runat="server" Text="Especialidad" Font-Size="Medium"></asp:Label>
                </div>
            </div>
        </div>

        <div class="jumbotron ">
            <h3>Datos generales</h3>
            <div class="row">
                <div class="col-md-4 ">
                    <p>Fecha</p>
                    <asp:TextBox ID="TextBoxFecha" runat="server" class="datepicker" Text="" required=" " Font-Size="Medium"></asp:TextBox>
                </div>
                <div class="col-md-4 center-align">
                </div>
                <div class="col-md-4">
                    <p>Horarios</p>
                    <asp:DropDownList ID="DropDownListHorario" runat="server">
                        <asp:ListItem Value="1">9:00</asp:ListItem>
                        <asp:ListItem Value="2">10:00</asp:ListItem>
                        <asp:ListItem Value="3">11:00</asp:ListItem>
                        <asp:ListItem Value="4">12:00</asp:ListItem>
                        <asp:ListItem Value="5">1:00</asp:ListItem>
                        <asp:ListItem Value="6">2:00</asp:ListItem>
                        <asp:ListItem Value="7">3:00</asp:ListItem>
                        <asp:ListItem Value="8">4:00</asp:ListItem>
                        <asp:ListItem Value="9">5:00</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <h3>Buscar paciente</h3>
            <div class="row">
                <div class="col-md-2 ">
                    <asp:TextBox ID="TextBoxIdAlumno" runat="server" class="" Text="" required=" " Font-Size="Medium"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:RegularExpressionValidator ID="ValirdarIdAlumno" runat="server" ErrorMessage="Solo números" ForeColor="Red" BackColor="Yellow" ControlToValidate="TextBoxIdAlumno" ValidationExpression="^\d+(?:[\.\,]\d+)?$" Font-Size="X-Large"></asp:RegularExpressionValidator>

                </div>
                <div class="col-md-6">
                    <asp:Button ID="ButtonBUscarID" runat="server" Text="Buscar" OnClick="ButtonBUscarID_Click" CssClass="waves-effect waves-light btn-large #7cb342 light-green darken-1 small " Font-Size="Medium" />

                </div>


            </div>
            <div>
                <h3>Alumno:</h3>
                <asp:Label ID="LabelNombreAlumno" runat="server" Text="" Font-Italic="True" Font-Bold="True" Font-Overline="False" Font-Underline="True" ></asp:Label>
            </div>
            <h3>Tipo de paciente</h3>
            <div class="row" style="font-size: medium">

                <div class="switch col s4">
                    Personal
                        <label>
                            <asp:CheckBox ID="TipoUsuario" runat="server" />
                            <span class="lever"></span>
                        </label>
                    Familiar
                </div>
            </div>

            <div align="center">
                <asp:Button ID="ButtonSiguiente" runat="server" Text="Registrar" OnClick="ButtonSiguiente_Click" CssClass="waves-effect waves-light btn-large #fdd835 yellow darken-1 small " Font-Size="Medium" />

            </div>

        </div>

    </div>

</asp:Content>
