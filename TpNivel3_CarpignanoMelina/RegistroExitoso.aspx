<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroExitoso.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.RegistroExitoso" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">

    <title>Registro Usuario</title>
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
            <div>
                <br />
                <div class=" container">
                    <div class=" text-center  m-5">
                        <div class="jumbotron jumbotron-fluid">
                            <div class="container">
                                <h1 class="display-4">Registro Exitoso!</h1>
                                <br />
                                <p class="lead">Se ha enviado un correo de confirmacion a su casilla</p>
                               <div class="mb-3">

                               </div> <asp:Button ID="BtnIrAPerfil" runat="server" Text="Ir a mi perfi" CssClass="btn btn-primary" OnClick="BtnIrAPerfil_Click" />
                            </div>
                                <div class="mb-3">

                               </div> <asp:Button ID="BtnVolerHome" runat="server" Text="Volver al Home" CssClass=" btn btn-primary" OnClick="BtnVolerHome_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                <div>
                </div>
    </form>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</body>
</html>
