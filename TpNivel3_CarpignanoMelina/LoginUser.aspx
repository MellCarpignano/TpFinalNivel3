<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.LoginUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
        <h1>Bienvenido,usuario!</h1>
        <h2>Ingreso:</h2>
    </div>
    <hr />
    <div class="form-group">
        <div class="text-center m-5">
            <asp:Label ID="lblEmailUser" runat="server" Text="Usuario:" CssClass="text-center"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server" CssClass="text-center"></asp:TextBox>
        </div>

        <div class="form-group">
            <div class="text-center m-5">
                <asp:Label ID="lblPassUser" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txtPassUser" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="btnLoginUser" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnLoginUser_Click" />
            </div>
            <div class="text-center m-5" >
                <p>No está registrado? <a href="RegistroUsuarioF.aspx">Registrarse</a></p>
                 


            </div>
</asp:Content>
