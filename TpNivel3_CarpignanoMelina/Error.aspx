<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error</title>
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
            </nav>
        </div>
        <br />

        <div class="text-center">
           
            <asp:Image ID="Image1" runat="server" ImageUrl="https://blogs.unsw.edu.au/nowideas/files/2018/11/error-no-es-fracaso.jpg" CssClass="col-11" />
        </div>
        <br />
        <div class=" text-center">
            <h1>Ha ocurrido un error...</h1>
          
            <div>
          <asp:Button ID="btnVolveralHome" runat="server" Text="Volver" CssClass="btn-primary" OnClick="btnVolveralHome_Click"/>
            </div>

        </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
        </form>
</body>
</html>
