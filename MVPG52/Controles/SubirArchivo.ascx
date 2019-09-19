<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SubirArchivo.ascx.cs" Inherits="MVPG52.Controles.SubirArchivo" %>
<form id="form1" runat="server">
    <asp:FileUpload id="FileUploadControl" runat="server" />
    <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
    <br /><br />
    <asp:Label runat="server" id="StatusLabel" text="Upload status: " />
</form>