<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checarProductoAdminVendedor.aspx.cs" Inherits="Tienda.checarProductoAdminVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="Style.css" rel="stylesheet" />
    <link href="Css/animate.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class ="question" >

            <br>

<asp:Label ID="Label1" CssClass="lbl1 lblstyle" runat="server" Text="Bienvenido al controlador de ventas"></asp:Label>        
            <br/>
            <br />
        
        <asp:Label ID="Label2" CssClass="lbl1 lblstyle" runat="server" Text="Nombre del producto"></asp:Label>

        <asp:TextBox ID="txtnomproducto"  CssClass="textbox"  runat="server"></asp:TextBox>
        
        <asp:Label ID="Label3" CssClass="lbl1 lblstyle" runat="server" Text="Marca"></asp:Label>
        <asp:TextBox ID="txtmarca"  CssClass="textbox" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" CssClass="lbl1 lblstyle" runat="server" Text="status:"></asp:Label>
        <asp:TextBox ID="txtstatus"  CssClass="textbox" runat="server"></asp:TextBox>
        <asp:Label ID="Label7" CssClass="lbl1 lblstyle" runat="server" Text="Existencia:"></asp:Label>
        <asp:TextBox ID="txtexistencia"  CssClass="textbox" runat="server"></asp:TextBox>
        

        <asp:Label ID="Label5" CssClass="lbl1 lblstyle" runat="server" Text="Origen:"></asp:Label>
        <asp:TextBox ID="txtOrigen"  CssClass="textbox" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" CssClass="lbl1 lblstyle" runat="server" Text="Descripcion:"></asp:Label>
        <asp:TextBox ID="txtdescripcion"  CssClass="textbox" runat="server" OnTextChanged="txtdescripcion_TextChanged"></asp:TextBox>
        <asp:Label ID="Label10" CssClass="lbl1 lblstyle" runat="server" Text="id usuario:"></asp:Label>
        <asp:TextBox ID="txtusuario"  CssClass="textbox" runat="server"></asp:TextBox>
        <asp:Label ID="Label14" CssClass="lbl1 lblstyle" runat="server" Text="Categoria:"></asp:Label>
        <asp:TextBox ID="txtcategoria"  CssClass="textbox" runat="server"></asp:TextBox>
        <asp:Label ID="Label12" CssClass="lbl1 lblstyle" runat="server" Text="Precio:"></asp:Label>
        <asp:TextBox ID="txtprecio"  CssClass="textbox" runat="server"></asp:TextBox>
        <asp:Label ID="Label13" CssClass="lbl1 lblstyle" runat="server" Text="Unidad de medida:"></asp:Label>
        <asp:TextBox ID="txtunidadmedida"  CssClass="textbox" runat="server"></asp:TextBox>

            <asp:Label ID="Label15" CssClass="lbl1 lblstyle" runat="server" Text="Id_producto"></asp:Label>
            <asp:TextBox ID="txtid_producto"  CssClass="textbox"  runat="server"></asp:TextBox>

            <p>
                <asp:Button ID="btnactualizar" CssClass="buttons" runat="server" Text="Actualizar" OnClick="btnactualizar_Click" />
        

        

        <asp:Button ID="btninsertarproducto" CssClass="buttons" runat="server" Text="Dar alta" OnClick="btninsertarproducto_Click" />
        
                <asp:Button ID="btneliminarproducto" CssClass="buttons" runat="server" Text="Eliminar producto" OnClick="btneliminarproducto_Click" />
        
        </p>
        

                <asp:Image ID="Image1" CssClass="addkey_btn" runat="server" Height="341px" Width="838px" />
        
        <asp:FileUpload ID="FileUpload2" CssClass="textbox"  runat="server" Width="448px" />
        

            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                        <ItemTemplate>
             <div class="catalogo" >
                 
                 <img class="img-responsive" src="data:image/jpg;base64,<%#Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"foto"))%>"/>
                 <%#DataBinder.Eval(Container.DataItem,"nombre")%>
                
                 
          
             
             <br/>          
         </ItemTemplate>
              </asp:Repeater>
            </div>
    </form>
</body>
</html>
