<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="Tienda.Compras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link type="text/css" rel="stylesheet" href="~/Content/bootstrap.min.css"/>
    <script type="text/javascript" src="~/Scripts/bootstrap.min.js"></script>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <title>Sección de compras</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

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
               
               <li>  <asp:Button class="btn btn-danger" ID="I" runat="server" Text="Inicio" OnClick="Button1_Click" /></li>
                 
                   
                 </ul>
            

                <ul class="nav navbar-nav navbar-right">
               <li><asp:Button ID="S" class="btn btn-danger" runat="server" Text="Agregar tarjeta" OnClick="Button3_Click" /></li>
              
                    </ul>

            
            <ul class="nav navbar-nav navbar-right">
                <li> <asp:Button class="btn btn-danger glyphicon-user" ID="R" runat="server" Text="Cerrar sesión" OnClick="Button4_Click" Height="30px" /></li>
             
            </ul>
            <ul class="nav navbar-nav navbar-right">
             <li> <asp:Button class="btn btn-danger glyphicon-log-in" ID="IS" runat="server" Text="Iniciar sesión " OnClick="Button2_Click" Height="26px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Label ID="Confirma" runat="server" Text=" "></asp:Label>
                </li>
           </ul>
            </div>
        </nav>

                         
                         
     

       
         
        
        
           
         
             <div class="hoy">
                 
                <div class="uni">
                    <h1 class="h1" > Aqui puedes pagar tus productos y buscarlos </h1>
                    <h1 class="h1" > 
                  <asp:Image ID="Image3" runat="server" Height="95px" Width="86px" />
                             <asp:Label ID="CONFIRMAAA" runat="server" BackColor="#00CC00"></asp:Label>
                             </h1>
                    
                        <div>
            
            <asp:GridView ID="GridView1" runat="server" Height="176px" Width="499px">
            </asp:GridView>
                             <asp:Button ID="btnBuscar" runat="server" Text="Buscar producto " OnClick="btnBuscar_Click" />
                            <asp:Label ID="labelno" runat="server" Text="Cantidad de producto a comprar:"></asp:Label>
                            <asp:TextBox ID="txtpagar" runat="server"></asp:TextBox>
                  <asp:Button ID="BtnComprar" runat="server" Text="Comprar" OnClick="BtnComprar_Click" />
              <asp:Label ID="Label1" runat="server"  Text="Nombre del producto:"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" Width="264px"></asp:TextBox>
                    
                     
                            </div>
                    </div>
                   
        </div>
                    </div>

        <div class="uni">
             <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
             <div class="catalogo alin" >
                 
                 <img class="img-responsive alin" src="data:image/jpg;base64,<%#Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"foto"))%>"/>
                 <%#DataBinder.Eval(Container.DataItem,"nombre")%>
                
                 
          
             
             <br/>          
         </ItemTemplate>
              </asp:Repeater>
        </div>
     
    </form>
</body>
</html>
<style>
    .alin{
        justify-content:center;
        align-items:center;
    }
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
  background-color:aquamarine;
 
  border: 10px  double #000000/* doted hace el margen puntiagudo*/;
  margin: 20px 50px;
  /*en general */
  padding: 30px ;
  color:black;

}
       .hoy{
             background-image: url("Images/tienda2.jpeg");
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

</style>