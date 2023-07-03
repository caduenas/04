<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="antropometrica_usuario.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.antropometrica_usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <title>GYMaster</title>
        <style>
        body {
            margin: 0;
            padding-bottom: 100px; /* Espacio para el contenido */
        }

        header {
            background-color: black;
            color: white;
        }

        footer {
            background-color: black;
            color: white;
            position: fixed;
            bottom: 0;
            left: 0;
            width: 100%;
            padding: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
                <a class="navbar-brand" href="#">GYMaster</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item active">
                            <a class="nav-link" href="#">Inicio</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="entrenadores.aspx">Ver entrenadores</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="central_usuarios.aspx">Visualizar Tablas</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="preferencias.aspx">Preferencias</a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
                <div class="container">
            <h1 class="number-center">Ajustes tabla Antropométrica</h1>
            <div class="form-group">
                <label for="altura">Altura:</label>
                <asp:TextBox ID="altura" runat="server" class="form-control" type="number" placeholder="Ingrese su Altura"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="peso">Peso:</label>
                <asp:TextBox ID="peso" runat="server" class="form-control" type="number" placeholder="Ingrese su Peso"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="edad">Edad:</label>
                <asp:TextBox ID="edad" runat="server" class="form-control" type="number" placeholder="Ingrese su edad"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="bicep-d">Bíceps Derecho:</label>
                <asp:TextBox ID="Bicep_D" runat="server" class="form-control" type="number" placeholder="Ingrese su tamaño de bicep_D"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="bicep-i">Bíceps Izquierdo:</label>
                <asp:TextBox ID="Bicep_I" runat="server" class="form-control" type="number" placeholder="Ingrese su tamaño de bicep_I"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="cadera">Cadera:</label>
                <asp:TextBox ID="cadera" runat="server" class="form-control" type="number" placeholder="Ingrese su cadera"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="muslo-d">Muslo Derecho:</label>
                <asp:TextBox ID="muslo_derecho" runat="server" class="form-control" type="number" placeholder="Ingrese su Muslo Derecho"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="muslo-i">Muslo Izquierdo:</label>
                <asp:TextBox ID="muslo_izquierdo" runat="server" class="form-control" type="number" placeholder="Ingrese su Muslo Derecho"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="abdomen_bajo">Abdomen Bajo:</label>
                <asp:TextBox ID="abdomen_bajo" runat="server" class="form-control" type="number" placeholder="Ingrese su Muslo Derecho"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="abdomen_alto">Abdomen Alto:</label>
                <asp:TextBox ID="abdomen_alto" runat="server" class="form-control" type="number" placeholder="Ingrese su Muslo Derecho"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="abdomen_medio">Abdomen Medio:</label>
                <asp:TextBox ID="abdomen_medio" runat="server" class="form-control" type="number" placeholder="Ingrese su Muslo Derecho"></asp:TextBox>
            </div>
            <asp:Button ID="btnCambiar" runat="server" Text="Cambiar valores" CssClass="btn btn-primary btn-block" OnClick="btnCambiar_Click"/>
        </div>
        <footer>
            <div class="text-center">
                &copy; <%: DateTime.Now.Year %> GYMaster. Todos los derechos reservados.
            </div>
        </footer>
    </form>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</body>
</html>
