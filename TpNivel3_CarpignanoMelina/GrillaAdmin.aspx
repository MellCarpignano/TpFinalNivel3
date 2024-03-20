 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GrillaAdmin.aspx.cs" Inherits="TpFinalNivel3_MelinaCarpignano.GrillaAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Listado de articulos</title>
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
            <h1>Espacio Administrador</h1>
            <hr />
            <div class="row">
                  <div class="col-6">
                <div class="mb-3">
                    <asp:Label ID="Lblfiltro" runat="server" Text="Filtrar"></asp:Label>
                    <asp:TextBox ID="filtro" runat="server" AutoPostBack="true" OnTextChanged="filtro_TextChanged" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
                <hr />
                   <asp:ScriptManager ID="ScriptManager1" runat="server" />
                   <asp:UpdatePanel ID="updatefiltro" runat="server">
                       <ContentTemplate>
                             <div class=" col-6" style="display:flex; flex-direction: column; justify-content: flex-end">
           <div class="mb-3">
               <asp:CheckBox ID="cheqboxFiltroAvanzado" runat="server" Text="Filtro Avanzado" AutoPostBack="true" OnCheckedChanged="cheqboxFiltroAvanzado_CheckedChanged" />

           </div>
                                 </div>
                <%if(cheqboxFiltroAvanzado.Checked)
                    {
                        %>
                <div class="row">
                    <div class=" col-3">
                        <div class="mb-3">
                            <asp:Label ID="LblCampo" runat="server" Text="Categoria:" ></asp:Label>
                            <asp:DropDownList runat="server" CssClass="form-control" id="ddlCategoria" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem Text="Tipo">
                                </asp:ListItem >
                                <asp:ListItem Text="Marca">
                               </asp:ListItem>
                                <asp:ListItem Text="Precio">
                                </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label id="lblSeleccion" runat="server" Text="Seleccion:">
                                <asp:DropDownList runat="server" ID="ddlSeleccion" CssClass="form-control"  >
                                  </asp:DropDownList>

                                 <div class="col-3">
                        <div class="mb-3">
                            <asp:Label ID="lblfiltrar" runat="server" ></asp:Label>
                            <asp:TextBox runat="server" ID="txtFiltroA" CssClass="form-control">

                                </asp:TextBox>
                            </asp:Label>
                        </div>
                    </div>
                   

                        <div class="row">
                            <div class="col-3">
                                <div class="mb-3">
                                    <asp:Button ID="btnBuscarFA" runat="server" Text="Buscar" CssClass="btn-primary" OnClick="btnBuscarFA_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
          <%} %>

        </div>
                       </ContentTemplate>


                   </asp:UpdatePanel>
     
       
        <div>
            <asp:GridView ID="GridAdmin" runat="server" CssClass="table-active" DataKeyNames="Id" OnSelectedIndexChanged="GridAdmin_SelectedIndexChanged1">
                <columns>
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />
                </columns>
            </asp:GridView>
        </div>
                <div>
                            <asp:Button ID="BtnAgregarArt" runat="server" Text="Agregar Nuevo Articulo" CssClass="btn btn-primary" OnClick="BtnAgregarArt_Click" />
                </div>

    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
