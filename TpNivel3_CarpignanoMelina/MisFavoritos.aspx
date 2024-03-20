<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MisFavoritos.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.MisFavoritos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Mis Favoritos</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <nav class="navbar bg-body-tertiary">
                <div class="container-fluid">
                    <a class="navbar-brand" href="Home.aspx">
                        <img src="https://img.freepik.com/premium-vector/n-logo_477193-26.jpg" alt="Logo" width="40" height="34" class="d-inline-block align-text-top"> NovaTech                     
                    </a>
                </div>
            </nav>
        </div>
       <div class="container">
           <h1>Mis favoritos </h1>
       </div>
        <div class="card" style="width: 18rem;">
  <img src="<%#Eval("ImagenUrl") %>" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title"><%#Eval("Nombre") %></h5>
      <h4 class="card-title"><%#Eval("Marca") %></h4>
      <h4 class="card-title"><%#Eval("Precio") %></h4>
    <p class="card-text"><%#Eval("Descripcion") %></p>
      <asp:Button ID="btnNoFav" runat="server"  Text="Quitar de mis favoritos" OnClick="btnNoFa_Click"/>
      <asp:Button ID="BtnVolverHome" runat="server" Text="Volver al Home" />
  </div>
</div>
    </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
