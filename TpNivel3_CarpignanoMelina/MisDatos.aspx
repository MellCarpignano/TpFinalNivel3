<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MisDatos.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.MisDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Mis Datos</title>
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

        <div class="container">
            <h2>Mis Datos</h2>
     <div class="row">
         <div class=" col-md-4">
             <div class="mb-3">
                 <label class="form-label">Email:</label>
                 <asp:TextBox ID="TxtEmaildatos" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <div class="mb-3">
                 <label class="form-label">Nombre:</label>
                 <asp:TextBox ID="TxtNombreDatos" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <div class="mb-3">
                 <label class="form-label">Apellido:</label>
                 <asp:TextBox ID="TxtApellidoDatos" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <div class="mb-3">
                 <label class="form-label">Fecha de nacimiento:</label>
                 <asp:TextBox ID="TxtnacDatos" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <div class="mb-3">
                 <label class="form-label">Telefono:</label>
                 <asp:TextBox ID="TxtTelDatos" runat="server" CssClass="form-control" ></asp:TextBox>
             </div>
         </div>
         <div class=" col-md-4">
             <div class="mb-3">
                 <label class=" form-label">Imagen Perfil</label>
                 <input type="file" id="txtImagen" runat="server" class="form-control" />
             </div>
             <asp:Image ID="imgNuevoPerfil" runat="server" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQErPk7KpZWRhIRDvHeKYF-AG23qBElZg2e1w&usqp=CAU" CssClass="img-fluid mb-3" />
         </div>
     </div>
            <div class="row">
                <div class=" col-md-4">
                    <asp:Button ID="btnguardarfoto" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnguardarfoto_Click" />
                    <a href="Miperfil.aspx">Regresar</a>
                </div>
            </div>

    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
