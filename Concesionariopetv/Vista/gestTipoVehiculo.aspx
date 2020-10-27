<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestTipoVehiculo.aspx.cs" Inherits="Vista.gestTipoVehiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Concesionario</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
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
                    <a class="nav-link" href="#">Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Tipo Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Contrato</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Ruta</a>
                </li>
            </ul>
        </div>
    </nav>

    <div class="container">
        <br />
        <h1>Gestión Tipos de Vehiculos</h1>
        <br />

        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtId">Id</label>
                <asp:TextBox ID="txtId" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtName">Name</label>
                <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-row">
                <div class="col-8">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click1"/>
                </div>
            </div>

            <div class="form-row">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false" />
            </div>

        </form>

    </div>    
</body>
</html>