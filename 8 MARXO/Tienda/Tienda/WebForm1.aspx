<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Tienda.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    

  <link type="text/css" rel="stylesheet" href="~/Content/bootstrap.min.css"/>
    <script type="text/javascript" src="~/Scripts/bootstrap.min.js"></script>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

    <title>Sección de Tarjetas</title>
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
               
               <li>     <asp:Button class="btn btn-danger" ID="Button11" runat="server" Text="Regresar a inicio" OnClick="Button11_Click" />
                </li>
                   
                   
                 </ul>

                <ul class="nav navbar-nav navbar-right">
               <li>    <asp:Button class="btn btn-danger" ID="Button12" runat="server" Text="Comprar productos" OnClick="Button12_Click" />
                    </li>
              
                    </ul>

            
            <ul class="nav navbar-nav navbar-right">
               <li>      <asp:Button class="btn btn-danger" ID="Button13" runat="server" Text="Registrarse" OnClick="Button13_Click" />
                </li>
             
            </ul>
            <ul class="nav navbar-nav navbar-right">
           <li      >  <asp:Button class="btn btn-danger" ID="Button14" runat="server" Text="Cerrar sesión" OnClick="Button14_Click" />
                </li>
           </ul>
            </div>
        </nav>

                         
     

       
         
        
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            <div class="hoy">
                 
                <div class="uni">
                    <h1 class="h1" > ¡ Inserta una tarjeta para poder realizar compras!</h1>
            
                    <br />
                     <asp:Label ID="Label1" runat="server" Text="Número de tarjeta"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox   MaxLength="18"  ID="TextBox1" runat="server" ></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Cvv o Cvc"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox PlaceHolder="Clave" MaxLength="4" ID="TextBox2" runat="server"></asp:TextBox>
                     &nbsp;<br />
                     <br />
                    <asp:Label ID="Label3" runat="server" Text="Saldo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:TextBox MaxLenght="5" PlaceHolder="Máximo 50000" ID="TextBox3" runat="server"></asp:TextBox>
                    &nbsp;
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Fecha de vencimiento"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox PlaceHolder="DD/MM/YY" MaxLenght="8" ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<br />
                     <br />
                    <asp:Button class="btn btn-outline-danger" ID="Button1" runat="server" Text="Añadir si tu clave es Cvv" OnClick="Button1_Click" />
                   
           
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button class="btn btn-outline-danger" ID="Button15" runat="server" Text="Añadir si tu clave es Cvc" OnClick="Button15_Click" />
                   
           
                    </div>
            </div>

      
        
        </div>
        
    <style> .botones{
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
  background-color:darkgreen;
 
  border: 10px  double #000000/* doted hace el margen puntiagudo*/;
  margin: 20px 50px;
  /*en general */
  padding: 30px ;
  color:black;

}
       .hoy{
             background-image: url("Images/TarjetaPago.jpg");
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
        
        </div>
    </form>
</body>
</html>
