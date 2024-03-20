<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMadministrador.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.ABMadministrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Area administrador</title>
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
        </nav>
        <div class=" container text-center">


            <h1>Producto Seleccionado</h1>

            <div class="col-md-4 m-auto">
                <label for="lblId" class="form-label">Id:</label>
                <asp:TextBox ID="TxtIdArt" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-md-4 m-auto">
                <label for="lblNombreArt" class="form-label">Nombre:</label>
                <asp:TextBox ID="TxtNombreArt" runat="server" CssClass="form-control" ></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4 m-auto">
            <label for="lblCod" class="form-label">Codigo:</label>
            <asp:TextBox ID="TxtCodigoArt" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 m-auto">
            <label for="lblDescripcion" class="form-label">Descripcion:</label>
            <asp:TextBox ID="TxtDescripArt" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        

             <div class="col-md-4 m-auto">
            <label for="lblMarca" class="form-label">Marca:</label>
            <asp:DropDownList ID="DdlMarca" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
             <div class="col-md-4 m-auto">
            <label for="lblMarca" class="form-label">Categoria:</label>
                 <asp:DropDownList ID="DddlCategoria" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>


        <div class="col-md-4 m-auto">
            <label for="lblMarca" class="form-label">Marca:</label>
            <asp:TextBox ID="TxtMarca" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <div class="col-md-4 m-auto">
            <label for="lblPrecio" class="form-label">Precio:</label>
            <asp:TextBox ID="TxtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 m-auto">
            <label for="lblImagen" class="form-label">Imagen:</label>
            <asp:Image ID="imgArt" runat="server" />
        </div>
     <div class="container text-center">
         <div>
             
                    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar Articulo" CssClass=" btn btn-danger "  OnClick="BtnEliminar_Click"/>
            

                <% if (confirmaElimin) { %>
                         <div class="mb-3">
                    <asp:CheckBox ID="ChqboxEliminacion" runat="server" Text="¿ Confirmar eliminacion ?" />
                    <asp:Button ID="BtnConfirmaEliminar" runat="server" Text="Eliminar" CssClass="btn-outline-danger " OnClick="BtnConfirmaEliminar_Click" />
                </div>
       
                    
                  <% } %>
           
          
            <asp:Button ID="BtnModificar" runat="server" Text="Modificar Articulo" CssClass="btn btn-primary " OnClick="BtnModificar_Click" />
          
            <asp:Button ID="BtnHome" runat="server" Text="Volver a la grilla" CssClass=" btn btn-primary" OnClick="BtnHome_Click" />
            

         </div>
        </div>



    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
