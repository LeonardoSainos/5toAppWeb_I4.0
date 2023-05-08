<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Mi_aplicacion_con_aspet.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" BackColor="Yellow"></asp:TextBox>
        <br />
        <br />
        Edad&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtedad" runat="server" BackColor="Yellow"></asp:TextBox>
        <br />
        <br />
        Matricula
        <asp:TextBox ID="txtId" runat="server" BackColor="Yellow"></asp:TextBox>
        <br />
&nbsp;<br />
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Red Social"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtRed" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Grupo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGrupo" runat="server"></asp:TextBox>
        <br />
        <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Conectar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Insertar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consultar" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Salir" />
&nbsp;&nbsp;
        <asp:Button ID="btnActualizar" runat="server" EnableViewState="False" OnClick="btnActualizar_Click" Text="Actualizar" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="no_control" HeaderText="no_control" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" />
                <asp:ImageField HeaderImageUrl="foto" HeaderText="foto" DataImageUrlField="foto">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insertar URL" />
        <asp:Label ID="lblRuta" runat="server" Text="Ruta"></asp:Label>
        <br />
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Grid view Image" Width="74px" />
        </p>
        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Image ID="Image1" runat="server" />
        <p>
            &nbsp;</p>
    </form>
    <style>
        body{
            background-color:darkcyan;
        }
    </style>
</body>
</html>
