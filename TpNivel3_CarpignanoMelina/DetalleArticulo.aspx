<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.DetalleArticulo" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Detalle Articulo</title>
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
                </div>
                <div class="container text-center">

                    <div class=" container-lg align-content-center offset-lg-4 ">
                        <div class="row">
                            <div class="col-4 card text-center">
                                <div class="mb-3">
                                    <asp:Label ID="lblIddelArt" runat="server" Text="Id del articulo:"></asp:Label>
                                    <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="LblNombre" runat="server" Text="Nombre del articulo:"></asp:Label>
                                    <asp:TextBox ID="TxtNombreArt" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="LbDescripcion" runat="server" Text="Descripcion:"></asp:Label>
                                    <asp:TextBox ID="TxtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="LblPrecio" runat="server" Text="Precio:"></asp:Label>
                                    <asp:TextBox ID="Txtprecio" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="mb-3">

                                <asp:Image ID="ImagenArt" runat="server" CssClass="card-img" />

                                               <asp:Button ID="BtnAgregarFav" runat="server" Text="Agregar a favoritos" CssClass="btn btn-primary" OnClick="BtnAgregarFav_Click" CommandArgument='<%#Eval("Id") %>' CommandName="IdFav" />
          
                                                 <asp:Button ID="BtnBackHome" runat="server" Text="Volver al Home" CssClass=" btn btn-primary" OnClick="BtnBackHome_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </form>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
</body>
</html>
