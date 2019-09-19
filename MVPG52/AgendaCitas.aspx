<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgendaCitas.aspx.cs" Inherits="MVPG52.AgendaCitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron  card-panel  accent-1#ffffff white">

        <nav class="" data-target="red" style="top: auto; z-index: auto">
            <div class="nav-wrapper #2196f3 blue">
                <div class="container center-align">
                    <h3 class="">Agenda de citas</h3>
                    <ul id="nav-mobile2" class="right hide-on-med-and-down">
                    </ul>
                </div>
            </div>
        </nav>
        <br />
        <ul class="collapsible " data-collapsible="accordion" style="font-size: x-large">
            <li>
                <div class="collapsible-header"><i class="material-icons">person_pin</i>Ayuda (?)</div>
                <div class="collapsible-body  jumbotron  card-panel teal white">
                   
                    <p style="font-size: medium">Operaciones: </p>
                    <p style="font-size: medium ; padding-left:2em"> (!) Cancelar cita. </p>
                    <p style="font-size: medium ; padding-left:2em"> (✓) Dar consulta. </p>
                </div>
            </li>
        </ul>

        <asp:Panel ID="Panel1" runat="server" Visible="false">
            <h2>No hay citas agendadas</h2>
        </asp:Panel>
        <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand" CssClass="highlight centered responsive-table table table-striped table table-hover" Font-Size="Medium">
            <Columns>
                <asp:TemplateField ShowHeader="False" HeaderText="Cancelar">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Eliminar" CssClass="center-align">
                                    <span >   <i class="material-icons">report_problem</i></span>
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" HeaderText="Realizar">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Realizar">
                                   <span >   <i class="material-icons ">done</i></span>
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" HeaderText=" ">
                    <ItemTemplate>
                        <asp:Label ID="Label1" Visible="false" runat="server" Text='<%# Eval("Id")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" HeaderText=" ">
                    <ItemTemplate>
                        <asp:Label ID="Label2" Visible="false" runat="server" Text='<%# Eval("Matricula")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False" HeaderText=" ">
                    <ItemTemplate>
                        <asp:Label ID="Label3" Visible="false" runat="server" Text='<%# Eval("Nombre")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField ShowHeader="False" HeaderText=" ">
                    <ItemTemplate>
                        <asp:Label ID="Label4" Visible="false" runat="server" Text='<%# Eval("Usuario")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
