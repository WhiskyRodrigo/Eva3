<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistrarLectura.aspx.cs" Inherits="Eva3.RegistrarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Registrar Lecturas</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" 
                         OnRowCommand="grillaLectura_RowCommand"
                         AutoGenerateColumns="false" ID="grillaLectura">
                        <Columns>
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha Lectura" />
                            <asp:BoundField DataField="Consumo" HeaderText="Cantidad de Consumo" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="elimina" CommandArgument='<%# Eval("Nombre") %>' 
                                        
                                        runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
