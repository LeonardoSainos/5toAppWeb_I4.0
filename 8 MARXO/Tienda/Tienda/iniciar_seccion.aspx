<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iniciar_seccion.aspx.cs" Inherits="Tienda.iniciar_seccion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar seccion</title>
      <link href="Style.css" rel="stylesheet" />
    <link href="Css/animate.min.css" rel="stylesheet" />
  <style>
@import url('https://fonts.googleapis.com/css?family=Anton|Boogaloo|Passion+One|Righteous');
    </style>
</head>
<body>
<form id="form1" runat="server">
        <section>
            <img src="images/Blur_Background_Image.jpg" class="animated fadeInUpBig" alt="" />
        </section>
        <div class="container">
            <div class="inner animated fadeInDown">
                <asp:Label ID="Label1" runat="server" Text="Iniciar sesión"></asp:Label><br />
                <br />
                <asp:Label ID="Label2" CssClass="lbl1 lblstyle" runat="server" Text="Correo"></asp:Label><br />
                <asp:TextBox ID="txtnombre" CssClass="txtstyle" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" CssClass="lbl2 lblstyle" Text="Contraseña"></asp:Label><br />
                <asp:TextBox type="password" ID="txtcontraseña" CssClass="txtstyle" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="Btniniciarseccion" runat="server" Text="Iniciar sesión:" OnClick="Btniniciarseccion_Click" />
                      <asp:Button ID="btnregistrar" runat="server" Text="Registrarte:" OnClick="btnregistrar_Click" />
                <br />
                <br />
                <asp:GridView ID="GridView2" runat="server" Height="549px" style="margin-top: 654px" Width="220px">
                </asp:GridView>
            </div>
            </div>
    </form>
</body>
</html>
