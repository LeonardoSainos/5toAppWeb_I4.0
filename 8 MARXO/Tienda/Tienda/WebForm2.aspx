<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Tienda.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link type="text/css" rel="stylesheet" href="~/Content/bootstrap.min.css"/>
    <script type="text/javascript" src="~/Scripts/bootstrap.min.js"></script>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>


    <title>Inicio</title>
</head>
<body>
    <form  id="form1" runat="server">
        <div>
             
        
       <!--utp0138573@alumno.utpuebla.edu.mx
Gamino2001-->
             
            <nav  class="navbar navbar-inverse">
        <div class ="container-fluid">
            <div class="navbar-header">
                   
                <a class="navbar-brand " href="#">Tienda Gamino,Ornelas & Sainos  </a>
                  <asp:Image ID="Image1" runat="server" Height="95px" Width="86px" />
                   <a class="navbar-brand " href="#">Bienvenido   <asp:Label ID="NombreUsuario" runat="server" BackColor="Transparent" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <p>
                   
                   <a class="navbar-brand " href="#">
                   
                    </a>
                </p>
                <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p> </a>
                </div>
            <ul class="nav navbar-nav navbar-right"> 
                <asp:Label ID="UsuarioInicio" runat="server" Text=" "></asp:Label>
               
               <li>  <asp:Button class="btn btn-danger" ID="Button1" runat="server" Text="Inicio" OnClick="Button1_Click" /></li>
                   
                   
                 </ul>

                <ul class="nav navbar-nav navbar-right">
               <li><asp:Button ID="Button3" class="btn btn-danger" runat="server" Text="Agregar tarjeta" OnClick="Button3_Click" /></li>
              
                    </ul>

            
            <ul class="nav navbar-nav navbar-right">
                <li> <asp:Button class="btn btn-danger glyphicon-user" ID="Button4" runat="server" Text="Registrarse" OnClick="Button4_Click" /></li>
             
            </ul>
            <ul class="nav navbar-nav navbar-right">
             <li> <asp:Button class="btn btn-danger glyphicon-log-in" ID="Button2" runat="server" Text="Cerrar Sesión" OnClick="Button2_Click" /></li>
           </ul>
            </div>
        </nav>

                         
     

       
         
        
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            <div class="hoy">
                 
                <div class="uni">
                    <h1 class="h1" > ¡ Selecciona lo que sea de tu agrado, desde categorias, productos y más!</h1>
                   <asp:Button  class="btn btn-info" ID="Button5" runat="server" Text="Categorias" OnClick="Button5_Click" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button class="btn btn-info" ID="Button7" runat="server" Text="Tarjetas" OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  
            <asp:Button  class="btn btn-info" ID="Button9" runat="server" Text="Productos" OnClick="Button9_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button  class="btn btn-info" ID="Button10" runat="server" Text="Compra" OnClick="Button10_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                     <br />
                     <br />
                       <asp:Button  class="btn btn-outline-success" ID="Button6" runat="server" Text=" Si deseas comprar un producto da click aqui" OnClick="Button6_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;
           
                    </div>
            </div>

      
        
        </div>
        
    <style>
        .botones{
            background-color:white;
            justify-items:center;
            align-items:center;

        }
        h1{
            text-align:center;
            color:black;
            font-family:Arial ;
        }
        .uni
            {
              text-align: center;   
              background-color: gold;
 
              border: 10px  double #000000/* doted hace el margen puntiagudo*/;
              margin: 20px 50px;
              /*en general */
              padding: 30px ;
              color:black;

            }
       .hoy{
             background-image: url("Images/tienda1.jpeg");
    background-repeat: no-repeat;
    background-size: cover;
    width: 100vw;
    height: 100vh;
    display: flex;
    align-items: flex-end;
    justify-content: center;
       }
        .BotonAdmi
        {

            align-items:center;

        }
        .Bonito
        {
                 font-family: Arial;
                 font-size: 15px;
                padding: 30px;
                margin-right: auto;
                margin-left: 7px;
                text-align: center;
                 align-items:center;
              
        }

        .Grises{
               /* justify-content: center;
            justify-items:center;
            align-items:center;
              text-align: center;
           font-family:Arial ;*/
            width:600px;
    margin-left:auto;
    margin-right:auto;
        }

        .Grises2{
               justify-content: center;
            justify-items:center;
            align-items:center;
              text-align: center;
           font-family:Arial 
        }


    </style>
        
        <div class="Grises2">  &nbsp;<asp:GridView Cssclass="Bonito" ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1274px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField  DataField="Id_categoria" HeaderText="Id"  />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="fecha_registro" HeaderText="Fecha de registro" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <br />
        <asp:GridView Cssclass="Bonito" ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="1273px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="numero_tarjeta" HeaderText="Número de tarjeta" />
                <asp:BoundField DataField="cvc" HeaderText="Cvc" />
                <asp:BoundField DataField="cvv" HeaderText="Cvv" />
                <asp:BoundField DataField="saldo" HeaderText="Saldo" />
                <asp:BoundField DataField="fecha_vencimiento" HeaderText="Vigencia" />
                <asp:BoundField />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        
        <br />
        <asp:GridView Cssclass="Bonito" ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1276px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                <asp:BoundField DataField="status" HeaderText="Estado" />
                <asp:BoundField DataField="Origen" HeaderText="Origen" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="cantidades_existentes" HeaderText="Productos en existencia " />
                <asp:BoundField DataField="precio" HeaderText="Precio" />
                <asp:BoundField DataField="unidad_de_medidas" HeaderText="Unidad" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />
        <br />
            </div>
        <div class="Grises">
              <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <Columns>
                <asp:BoundField DataField="id_producto" HeaderText="Id Producto" />
                <asp:BoundField DataField="total_compra" HeaderText="Factura" />
                <asp:BoundField DataField="fecha_compra" HeaderText="Fecha" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        </div>
       
      
       
    </form>

    </body>
</html>
