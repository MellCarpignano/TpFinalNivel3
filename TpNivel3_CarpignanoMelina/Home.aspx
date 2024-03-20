<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.Home1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Home</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
  <br />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            <button class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasNavbar" aria-controls="offcanvasNavbar" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasNavbar" aria-labelledby="offcanvasNavbarLabel">
                <div class="offcanvas-header">
                    <h5 class="offcanvas-title" id="offcanvasNavbarLabel">Menu</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
                </div>
                <div class="offcanvas-body">
                    <ul class="navbar-nav justify-content-end flex-grow-1 pe-3">

                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">Login
                            </a>
                            <ul class="dropdown-menu">
                                <li><a class="dropdown-item" href="LoginUser.aspx">Login Usuario</a></li>
                                <li><a class="dropdown-item" href="LoginAdmin.aspx">Login Administrador</a></li>
                                <li>
                                    <hr class="dropdown-divider">
                                </li>
                                
                            </ul>
                        </li>
                            <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="RegistroUsuarioF.aspx">Registrarse</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="Contáctenos.aspx">Formulario de contacto</a>
                        </li>
                    </ul>

                </div>
            </div>
        </div>
    </nav>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>


    <div class="jumbotron  m-5 text-center p-4">
  <div class="container">
    <h1 class="display-4">¡Bienvenidos!</h1>
    <p class="lead">Encontra las mejores tendencias en tecnologia</p>
  </div>
</div>


    <asp:Repeater runat="server" ID="repetidordelhome">
        <ItemTemplate>

<div class="card d-inline-flex card-footer col-3" style="width: 15rem;">
  <img src="<%#Eval("ImagenUrl") %>" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title"><%#Eval("Nombre")%></h5>
    <p class="card-text"><%#Eval("Codigo") %></p>
         <asp:Button ID="BtnDetalle" runat="server" Text="Ver Detalle" CssClass="btn btn-secondary" CommandArgument='<%#Eval("Codigo") %>' CommandName="CodigoArt" OnClick="BtnDetalle_Click1"  />
  </div>
</div>
    </div>

<%--           
               <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col">
                        <div class="card">
                            <img src="<%#Eval("ImagenUrl") %>" class="card-img-top w-25 border-bottom text-center" alt="">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre")%></h5>
                                <h5 class="card-title"><%#Eval("Codigo") %> </h5>
                                <asp:Button ID="BtnDetalle" runat="server" Text="Ver Detalle" CssClass="btn btn-secondary" CommandArgument='<%#Eval("Codigo") %>' CommandName="CodigoArt" OnClick="BtnDetalle_Click1"  />
                               
                --%>
             </ItemTemplate>
    </asp:Repeater>



</asp:Content>
