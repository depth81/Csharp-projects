﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestRuta.aspx.cs" Inherits="Vista.gestRuta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Concesionario</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
</head>
<body>
     <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Concesionario</a>
    </nav>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item active">
                    <a class="nav-link" href="gestTipoVehiculo.aspx">Tipo Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestVehiculo.aspx">Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestTipoConductor.aspx">Tipo Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestConductor.aspx">Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestContrato.aspx">Contrato</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestRuta.aspx">Ruta</a>
                </li>
            </ul>
        </div>
    </nav>

    <div class="container">
        <br />
        <h1>Gestión de rutas</h1>
        <br />

        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtidRuta">idRuta</label>
                <asp:TextBox ID="txtidRuta" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtEstacion">Estacion</label>
                <asp:TextBox ID="txtEstacion" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtidVehiculo">idVehiculo</label>
                <asp:TextBox ID="txtidVehiculo" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-row">
                <div class="col-8">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
                </div>
                <div class="col-4 text-right">
                    <asp:Button ID="btnList" runat="server" Text="List" class="btn btn-primary" OnClick="btnList_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click" />
                </div>
            </div>

            <div class="form-row">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false" />
            </div>

            <br />

            <table class="table">
                <tr>
                    <th>
                        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="idRuta" HeaderText="idRuta" />
                                <asp:BoundField DataField="estacion" HeaderText="estacion" />
                                <asp:BoundField DataField="idVehiculo" HeaderText="idVehiculo" />
                            </Columns>
                        </asp:GridView>
                    </th>
                </tr>
            </table>

        </form>

    </div>    



</body>
</html>
