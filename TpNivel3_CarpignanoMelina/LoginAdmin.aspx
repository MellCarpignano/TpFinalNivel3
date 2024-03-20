<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.LoginAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h1>Bienvenido, administrador!</h1>
        <h2>Ingreso:</h2>
    </div>
  <hr />
         <div class="form-group" >
          <div class="text-center m-5">
         <asp:Label ID="lblEmailUser" runat="server" Text="Email:" CssClass="text-center"></asp:Label>
         <asp:TextBox ID="txtEmailUser" runat="server" CssClass="text-center"></asp:TextBox>
         </div>

            <div class="form-group">
                <div class="text-center m-5">
             <asp:Label ID="lblPassUser" runat="server" Text="Contraseña:"></asp:Label>
            <asp:TextBox ID="txtPassUser" runat="server" TextMode="Password" ></asp:TextBox>
                </div>
          <div class="text-center">
              <asp:Button ID="btnLoginAdmin" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnLoginAdmin_Click"/>
          </div>
    </div>
   
</asp:Content>
