<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistrarMedidor.aspx.cs" Inherits="Eva3.RegistrarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Registrar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="boleta">Boleta</label>
                        <asp:TextBox ID="boletaTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="numCliente">Numero de Cliente</label>
                        <asp:TextBox ID="numClienteTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="numMedidor">Numero de Medidor</label>
                        <asp:TextBox ID="numMedidorTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-primary" ID="ingresaBtn" Text="Ingresar" />

                </div>
            </div>

        </div>
    </div>
</asp:Content>
