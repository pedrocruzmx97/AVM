<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarCita.aspx.cs" Inherits="MVPG52.ConsultarCita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron ">
        <h3>Agenda de citas</h3>
        <br />
        <div class="row">

            <div>
                <asp:GridView ID="GridViewCitasPasiente" runat="server" CssClass="bordered  highlight responsive-table centered  z-depth-5"></asp:GridView>
            </div>

        </div>
    </div>
  

</asp:Content>
