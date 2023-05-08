<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vista_administrador.aspx.cs" Inherits="Tienda.vista_administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 <link type="text/css" rel="stylesheet" href="~/Content/bootstrap.min.css"/>
    <script type="text/javascript" src="~/Scripts/bootstrap.min.js"></script>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
      <link href="Style.css" rel="stylesheet" />
    <link href="Css/animate.min.css" rel="stylesheet" />
  <style>
@import url('https://fonts.googleapis.com/css?family=Anton|Boogaloo|Passion+One|Righteous');
</style>
</head>
     
<body>
     
    <form id="form1" class="question"  runat="server">

        <div class="question">
            <asp:Label ID="Label13" CssClass="lbl1 lblstyle" runat="server" Text="Bienvenido "></asp:Label>
            <asp:Label ID="Label12"  CssClass="lbl1 lblstyle"  runat="server" Text="Label"></asp:Label>
                          <br />
              <asp:Button ID="btncontrol" runat="server"  CssClass="buttons" Height="133px" OnClick="btncontrol_Click" Text="Control de productos:" Width="567px" />
              <br />
                          <asp:Image ID="Image2" CssClass="addkey_btn" runat="server" Height="424px" Width="456px" />
                          <asp:Button class="btn btn-info"  btn="Button3" runat="server" Text="Ir al apartado de ganacias" OnClick="Unnamed1_Click" />
                          <br />
                          <asp:Button ID="Button2" CssClass="buttons"  runat="server" Text="cerrar sesion" OnClick="Button2_Click" Height="151px" />
                          <br />
             <br />

            <asp:Button ID="btnproductos" runat="server" CssClass="buttons"  OnClick="Button1_Click" Text="Mostrar productos:" Height="126px" Width="849px" />
 
              <br />
 
            <asp:Button ID="Button1"  runat="server" CssClass="buttons"  OnClick="Button1_Click" Text="Clientes" Height="136px" Width="999px" />
              <br />
       
        <asp:Image ID="Image1" runat="server" Height="348px" Width="1217px"></asp:Image>
              <br />
              <br />
            
            <asp:GridView ID="GridView1" CssClass="table" runat="server" Height="751px" Width="2010px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            
              <br />
            &nbsp;<br />
            <asp:Label ID="Label10" CssClass="lbl1 lblstyle" runat="server" Text="Id usuario:"></asp:Label>
            <asp:TextBox ID="txtid_usuario"  CssClass="textbox" runat="server" Width="47px" Height="48px"></asp:TextBox>
           
            <asp:Label ID="Label2" CssClass="lbl1 lblstyle"  runat="server" Text="Nombre;"></asp:Label>
       
         
            <asp:TextBox ID="txtnombre1" CssClass="textbox" runat="server" Height="50px" Width="209px"></asp:TextBox>
           
            <asp:Label ID="Label3" CssClass="lbl1 lblstyle"  runat="server" Text="Apellidos:"></asp:Label>
          
            <asp:TextBox ID="txtapellidos" CssClass="textbox" runat="server" Height="48px" Width="184px"></asp:TextBox>
           

            <asp:Label ID="Label4" CssClass="lbl1 lblstyle"  runat="server" Text="Id rol:"></asp:Label>
            
            <asp:TextBox ID="txtidrol" CssClass="textbox" runat="server" Width="44px" Height="48px"></asp:TextBox>
           
            <asp:Label ID="Label5" CssClass="lbl1 lblstyle"  runat="server" Text="Id permiso:"></asp:Label>
            
            <asp:TextBox ID="txtpermiso" CssClass="textbox" runat="server" Width="47px" Height="51px"></asp:TextBox>
              
            
            <asp:Label ID="Label7"  CssClass="lbl1 lblstyle" runat="server" Text="correo electronico:"></asp:Label>
              
             
            <asp:TextBox ID="txtcorreo" CssClass="textbox" runat="server" Height="50px" Width="349px"></asp:TextBox>
           
          
            <asp:Label ID="Label8" CssClass="lbl1 lblstyle" runat="server" Text="Contraseña:"></asp:Label>
             
              
            <asp:TextBox ID="txtcontraseña"  CssClass="textbox" runat="server" Width="146px" Height="47px"></asp:TextBox>
             
            <asp:Button ID="btnactualizar" CssClass="buttons" runat="server" Text="Actualizar:" OnClick="btnactualizar_Click" style="margin-top: 0px; top: -4px; left: 17px; height: 48px; width: 184px;" />
          <br />
        &nbsp;</p>
          <asp:Label ID="Label14" CssClass="lbl1 lblstyle" runat="server" Text="Seleccione su foto para actualizar:"></asp:Label>
          <br />
        <p>
              <br />
            <asp:FileUpload ID="FileUpload1" CssClass="addkey_btn" runat="server" Height="128px" Width="921px" />
              <br />
        </p>
          <br />
            <asp:Label ID="Label11" CssClass="lbl1 lblstyle" runat="server" Text="Nombre"></asp:Label>
          <br />

        <asp:TextBox ID="txtnombre" CssClass="textbox" runat="server" Height="43px" Width="390px"></asp:TextBox>
          <br />
      <br />

        <asp:Button ID="btnusuario"  CssClass="buttons"  runat="server" OnClick="btnusuario_Click" Text="Buscar usuario:" Height="165px" Width="880px" />
          <br />
        <br />
        <asp:Button ID="butneliminar" CssClass="buttons" runat="server" OnClick="butneliminar_Click" Text="Eliminar" />
        <p>
            &nbsp;</p>
                        </div>

    </form>

</body>
</html>
