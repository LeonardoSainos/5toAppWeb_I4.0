<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Tienda.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Log</title>

    <link href="Style.css" rel="stylesheet" />
    <link href="Css/animate.min.css" rel="stylesheet" />
  <style>
@import url('https://fonts.googleapis.com/css?family=Anton|Boogaloo|Passion+One|Righteous');
</style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <img src="images/billetera.jpg" class="animated fadeInUpBig" alt="" />
        </section>
        <div class="container">
            <div class="inner animated fadeInDown">
                <asp:Label ID="Label1" runat="server" Text="Registro"></asp:Label><br />
                <asp:Image ID="Image1"  CssClass="lbl2 lblstyle" runat="server" Height="144px" Width="354px" />
                <br />
                <asp:FileUpload ID="FileUpload1"  CssClass="txtstyle" runat="server" Height="44px" Width="392px" />
                <br />
                <asp:Label ID="Label2" CssClass="lbl1 lblstyle" runat="server" Text="Nombre"></asp:Label><br />
                <asp:TextBox ID="txtnombre" CssClass="txtstyle" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" CssClass="lbl1 lblstyle" runat="server" Text="Apellidos"></asp:Label><br />
                <asp:TextBox ID="Textapellidos" CssClass="txtstyle" runat="server"></asp:TextBox><br />
                <br />
                <br />
                <asp:Label ID="Label5" CssClass="lbl1 lblstyle" runat="server" Text="Correo"></asp:Label><br />
                <asp:TextBox ID="Textcorreo" CssClass="txtstyle" runat="server"></asp:TextBox><br />
                <br />
                <asp:Label ID="Label3" runat="server" CssClass="lbl2 lblstyle" Text="Contraseña"></asp:Label><br />
                <asp:TextBox type="password" ID="txtcontraseña" CssClass="txtstyle" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="btnregistrar" runat="server" Text="Registrar:" OnClick="btnregistrar_Click" />

                <br />
                <br />

                <asp:Button ID="Btniniciarseccion" runat="server" Text="Iniciar seccion:" OnClick="Btniniciarseccion_Click" />

            </div>
            </div>
    </form>
</body>
</html>