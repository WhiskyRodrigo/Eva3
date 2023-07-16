<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Eva3.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"> </asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="boletaTxt">Numero de boleta</label>
                        <asp:TextBox ID="boletatxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="numClienteTxt">Numero de cliente</label>
                        <asp:TextBox ID="numclientetxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="numMedidorTxt">Numero del medidor</label>
                        <asp:TextBox ID="nummedidortxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                      </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar" CssClass="btn btn-primary btn-lg" />

                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
