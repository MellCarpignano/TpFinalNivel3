﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactoOk.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.ContactoOk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        
        <nav class="navbar bg-body-tertiary">
            <div class="container-fluid">
                <a class="navbar-brand" href="Home.aspx">
                    <img src="https://img.freepik.com/premium-vector/n-logo_477193-26.jpg" alt="Logo" width="40" height="34" class="d-inline-block align-text-top">
                    NovaTech                     
                </a>
        </nav>
        <div>
                <div class="jumbotron jumbotron-fluid">
        <div class="container text-center">
            <h1 class="display-4 m-3">Gracias!</h1>

            <p class="lead">Su sugerencia o comentario nos ayuda a mejorar</p>

        </div>
                    <div>
                        <asp:Button ID="btnvolverHome" runat="server" Text="Volver al Home" CssClass="btn btn-dark offset-6" OnClick="btnvolverHome_Click" />
                    </div>
        </div>
    </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
