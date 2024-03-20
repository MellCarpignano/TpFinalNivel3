<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarioF.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.RegistoUsuarioF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="text-center m-5">
        <h1>Registro de Usuario</h1>
    </div>  
    <form class="row g-3">
         <div class="col-md-4 m-auto">
            <label for="lblEmailUsuario" class="form-label">Email:</label>
           <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
         <div class="col-md-4 m-auto">
            <label for="lblpassUsuario" class="form-label">Contraseña elegida:</label>
           <asp:TextBox ID="Txtpassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <div class="col-md-4 m-auto">
            <label for="lblNombreNUsuario" class="form-label">Nombre:</label>
           <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 m-auto">
            <label for="lblApellidoUsuario" class="form-label">Apellido:</label>
           <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 m-auto">
            <label for="lblUrlimagenUsuario" class="form-label">Imagen:</label>
           <asp:TextBox ID="TxtUrlImagen" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
         <div class="col-md-4 m-auto">
            <label for="lblEmailUsuario" class="form-label">Fecha de nacimiento:</label>
           <asp:TextBox ID="TxtFechaNac" runat="server" CssClass="form-control"  TextMode="Date" ></asp:TextBox>
        </div>
          <div class="col-md-4 m-auto">
            <label for="lblEmailUsuario" class="form-label">Telefono:</label>
           <asp:TextBox ID="TxtTel" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
        </div>
        <div class=" col-md-4 m-auto">
            <asp:Button ID="BtnRegistrarmeUser" CssClass="btn btn-primary" runat="server" Text="Registrarme" OnClick="BtnRegistrarmeUser_Click" />
            <asp:Button ID="BtnCancelarRegistro" runat="server" Text="Cancelar" CssClass=" btn btn-primary" OnClick="BtnCancelarRegistro_Click"  />
        </div>
    </form>
</asp:Content>
