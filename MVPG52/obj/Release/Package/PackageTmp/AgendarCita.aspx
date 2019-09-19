<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgendarCita.aspx.cs" Inherits="MVPG52.AgendarCita"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    <style type="text/css">
        select {
        font-size:medium;
        
        }

        label {
        font-size:medium;
        }
        input {
           font-size:medium;
        }
      


    </style>
    <div class="jumbotron  card-panel #fafafa grey lighten-5 ">
        <nav class="" data-target="red" style="top: auto; z-index: auto">
            <div class="nav-wrapper #2196f3 blue">
                <div class="container center-align">
                    <h3 class="">Agendar cita</h3>
                    <ul id="nav-mobile2" class="right hide-on-med-and-down">
                    </ul>
                </div>
            </div>
        </nav>

        <div class="jumbotron ">
            <ul class="collapsible " data-collapsible="accordion" style="font-size: x-large">
                <li>
                    <div class="collapsible-header"><i class="material-icons">person_pin</i>Selección de área</div>
                    <div class="collapsible-body  jumbotron  card-panel teal white">
                        <p style="font-size: medium">1.-Seleccione  una área. </p>
                        <p style="font-size: medium">2.-Para seleccionar un especialista primero realice el paso 1. </p>
                    </div>
                </li>
            </ul>
            <div class="row">
                <div class="col-md-4  " style="font-size: medium">
                    Selección de área
                    <div class="" style="font-size: medium">

                        <asp:DropDownList ID="DropDownListESpecialidades" AutoPostBack="true" runat="server" OnSelectedIndexChanged="Button1_Click1" Font-Size=" x-large">

                            <asp:ListItem Selected="False" Value="0" Text="Seleccione área" Enabled="true"></asp:ListItem>
                        </asp:DropDownList>



                    </div>
                </div>
                <div class="col-md-4 center">
                    <asp:Button ID="ButtonFiltrar" runat="server" Text="Filtrar" OnClick="Button1_Click1" CssClass="waves-effect waves-light btn-large small " Font-Size="Medium" Visible="false" />
                </div>
                <div class="col-md-4 " style="font-size: medium">
                    Selección de especialista
                    <asp:DropDownList ID="DropDownListEspecialista" runat="server" CssClass="left-align"></asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="jumbotron ">
            <ul class="collapsible " data-collapsible="accordion" style="font-size: x-large">
                <li>
                    <div class="collapsible-header"><i class="material-icons">av_timer</i>Agende una fecha</div>
                    <div class="collapsible-body  jumbotron  card-panel teal white">
                        <p style="font-size: medium">1.-Selecciona una fecha NO anterior a la de hoy. </p>
                        <p style="font-size: medium">2.-Verifique disponibilidad. </p>
                        <p style="font-size: medium">3.-Seleccina el tipo de usuario, Personal o Familiar(Mamá,Papá,Hermanos,etc). </p>
                    </div>
                </li>
            </ul>
             <ul class="collapsible " data-collapsible="accordion" style="font-size: x-large">
                <li>
                    <div class="collapsible-header"><i class="material-icons">av_timer</i>Horario</div>
                    <div class="collapsible-body  jumbotron  card-panel teal white">
                        <p style="font-size: medium">Médico:<strong> de 9:00 AM a 2:00 PM de 3:00 PM a 5:00 pm </strong></p>
                        <p style="font-size: medium">Dental: de<strong> 9:00 AM a 2:00 PM de 2:00 PM a 4:00 pm </strong> </p>
                        <p style="font-size: medium">Psicólogo: de<strong> 9:00 AM a 2:00 PM de 2:00 PM a 4:00 pm  </strong></p>
                    </div>
                </li>
            </ul>
            <br />
            <div class="row" style="font-size: medium">
                <div class="col-md-4">
                    Fecha
                    <asp:TextBox ID="TextBoxFecha" runat="server" class="datepicker" Font-Size="Medium"></asp:TextBox>
                </div>
                <div class="col-md-4 center">
                    <asp:Button ID="ButtonFechaDispobible" runat="server" Text="Disponibilidad" OnClick="Button2_Click2" CssClass="waves-effect waves-light btn " Font-Size="Medium" />
                </div>
                <div class="col-md-4">
                    Horario
                    <asp:DropDownList ID="DropDownListHorario" runat="server"></asp:DropDownList>
                </div>
            </div>
           

           
            ¿Para quién es la consulta? 

                <div class="row" style="font-size: medium">
                     
                    <div class="switch col s4">
                        Personal
                        <label>
                            <asp:CheckBox ID="TipoUsuario" runat="server" />
                            <span class="lever"></span>
                        </label>
                        Familiar
                    </div>

                    <div class="col-md-1">
                    </div>
                    <div class="col-md-7">
                        <asp:Button ID="ButtonReuistrarConsulta" runat="server" Text="                  Agendar                  " OnClick="ButtonReuistrarConsulta_Click" CssClass="waves-effect waves-light btn-large #ffc107 amber small " Font-Size="Medium"  />
                    </div>
                </div>

              
               
            </div>
        </div>
</asp:Content>
