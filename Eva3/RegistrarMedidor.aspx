<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistrarMedidor.aspx.cs" Inherits="Eva3.RegistrarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Registrar Medidor</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" 
                         OnRowCommand="grillaMedidor_RowCommand"
                         AutoGenerateColumns="false" ID="grillaMedidor">
                        <Columns>
                            <asp:BoundField DataField="Boleta" HeaderText="Numero de boleta" />
                            <asp:BoundField DataField="Cliente" HeaderText="Rut del cliente" />
                            <asp:BoundField DataField="Medidor" HeaderText="Numero de medidor" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="AgregarMedidor" CommandArgument='<%# Eval("Medidor") %>' 
                                        
                                        runat="server" CssClass="btn btn-danger" Text="Agregar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
