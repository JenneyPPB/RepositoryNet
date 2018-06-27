<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="JSONNET.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Identificador" runat="server" Text="Identificador"/>    
            <asp:TextBox ID="txtIdentificador" runat="server" OnTextChanged="txtIdentificador_TextChanged" /><br/>

            <asp:Label ID="lblNombre" runat="server" Text="Nombre"/>
            <asp:TextBox ID="txtNombre" runat="server" /><br/>
            <asp:Label ID="lblApellidos" runat="server" Text="Apellidos"/>
            <asp:TextBox ID="txtApellidos" runat="server" /><br/>
            <asp:Label ID="lblDNI" runat="server" Text="DNI"/>    
            <asp:TextBox ID="txtDNI" runat="server" /><br/>
            <asp:Button ID="btnAgregarPersona" runat="server" Text="Agregar Alumno" OnClick="btnAgregarPersona_Click1" />
            <br/>
            <asp:LisTBox ID="ltbAlumno" runat="server" Width="423px" ></asp:LisTBox>
            <br/>
            <asp:Button ID="btnJSON" runat="server" Text="Generar JSON" OnClick="btnJSON_Click1"/>



        </div>
    </form>
</body>
</html>
