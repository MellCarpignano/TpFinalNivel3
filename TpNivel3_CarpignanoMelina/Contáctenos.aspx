<%@ Page Title=""  Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Contáctenos.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.Contáctenos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--------------------------------------->
    <div class="jumbotron jumbotron-fluid">
        <div class="container text-center">
            <h1 class="display-4 m-3">Contáctenos</h1>

            <p class="lead">Su sugerencia o comentarios nos ayuda a mejorar</p>

        </div>


<div class="modal fade text-center" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true" >
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">Contáctenos</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Cerrar"></button>
      </div>
      <div class="modal-body">
        <form>
          <div class="mb-3">
            <label for="recipient-name" class="col-form-label">Asunto:</label>
            <input type="text" class="form-control" id="recipient-name">
          </div>
          <div class="mb-3">
            <label for="message-text" class="col-form-label">Mensaje:</label>
            <textarea class="form-control" id="message-text"></textarea>
          </div>
        </form>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
       
        <asp:Button ID="BtnEnviarmsj" runat="server" Text="Enviar Mensaje" CssClass=" btn btn-primary" OnClick="BtnEnviarmsj_Click" />
      </div>
    </div>
  </div>
</div>
<button type="button" class="btn btn-primary offset-6 " data-bs-toggle="modal" data-bs-target="#exampleModal" data-bs-whatever="@mdo">Enviar Mensaje</button>


        </form>



</asp:Content>
