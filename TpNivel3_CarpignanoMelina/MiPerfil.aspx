<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.EspacioUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Mi Perfil</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar bg-body-tertiary">
                <div class="container-fluid">
                    <a class="navbar-brand" href="Home.aspx">
                        <img src="https://img.freepik.com/premium-vector/n-logo_477193-26.jpg" alt="Logo" width="40" height="34" class="d-inline-block align-text-top">
                        NovaTech                     
                    </a>
                </div>
            </nav>
        </div>
        <div class="text-center m-5">
            <div class="jumbotron  m-5 text-center p-4">
                <div class="container">
                    <h1 class="display-4">Espacio Usuario</h1>
                    <p class="lead">¡Bienvenido a tu perfil!</p>
                </div>
            </div>
        </div>
        <div class="input-group">
        </div>
        <div>

            <div class="row">
                <div class=" col-6 text-center">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title">Mis Datos</h5>
                            <p class="card-text">Haga click aqui para ver/modificar sus datos</p>
                            <a href="MisDatos.aspx" class="btn btn-primary bg-black">Ingresar</a>
                        </div>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title">Mis Favoritos ♥ </h5>
                            <p class="card-text">Listado de productos favoritos</p>
                            <a href="MisFavoritos.aspx" class="btn btn-primary bg-black">Ingresar</a>
                        </div>
                    </div>
                </div>
            </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
