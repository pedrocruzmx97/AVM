<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChatOnline.aspx.cs" Inherits="MVPG52.ChatOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1>Chat Online</h1>
    <h4>Ingrese la Matricula del Alumno</h4>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
    
    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>
                         <asp:TemplateField ShowHeader="False" HeaderText="Cancelar">
                            <ItemTemplate >
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Eliminar"  >
                                    <span class="">Iniciar Chat</span>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                 <asp:TemplateField ShowHeader="False" HeaderText=" ">
                            <ItemTemplate>
                                <asp:Label ID="Label1" Visible="false"  runat="server" Text='<%# Eval("Matricula")%>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                </Columns>
    </asp:GridView>
    <h2>Chat Activo</h2>
    <asp:Label ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnDataBinding="UpdatePanel1_DataBinding">
         <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="1000"></asp:Timer>
            <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand">
            
            </asp:GridView>
            
        </ContentTemplate>
    
    </asp:UpdatePanel>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Width="578px"></asp:TextBox>
    <br />
    <asp:Button ID="Enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" />

</asp:Content>
