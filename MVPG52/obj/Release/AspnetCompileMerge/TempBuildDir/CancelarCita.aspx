<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelarCita.aspx.cs" Inherits="MVPG52.CancelarCita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron card-panel #ffffff white">
        <nav class="" data-target="red" style="top: auto; z-index: auto">
            <div class="nav-wrapper #689f38 light-green darken-2">
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
                <div class="collapsible-header"><i class="material-icons">person_pin</i>Instrucciones para cancelar cita.</div>
                <div class="collapsible-body  jumbotron  card-panel teal white">
                    <p style="font-size: medium">1.-Localice la cita que cancelará. </p>
                    <p style="font-size: medium">2.-Presione el botón con el signo (!) </p>
                </div>
            </li>
        </ul>
        <br />

        <div class="row">
            <div>
                <asp:GridView ID="GridViewCitasPasiente" runat="server" CssClass="bordered  highlight responsive-table centered  z-depth-5 striped" OnSelectedIndexChanged="GridViewCitasPasiente_SelectedIndexChanged" OnPageIndexChanged="GridViewCitasPasiente_SelectedIndexChanged" OnRowCommand="GridView1_OnRowCommand">
                    <Columns>
                        <asp:TemplateField ShowHeader="False" HeaderText="Cancelar">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Eliminar">
                                    <i class="material-icons">error_outline</i>
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

        </div>
    </div>
    <div>
    </div>
</asp:Content>
