﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabla_dieta.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.tabla_dieta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
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
    .floating-button {
      position: fixed;
      bottom: 20px;
      right: 20px;
      width: 50px;
      height: 50px;
      border-radius: 50%;
      background-color: #007bff;
      color: white;
      display: flex;
      align-items: center;
      justify-content: center;
      font-size: 24px;
      box-shadow: 0 2px 4px rgba(0, 0, 0, 0.4);
    }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Larger"></asp:Label>
                <div class="table-responsive mt-5">
                    <asp:GridView ID="GridView1" runat="server" CssClass="table">
                    </asp:GridView>
                </div>
            </div>
            <footer>
                <div class="text-center">
                    &copy; 2023 GYMaster. Todos los derechos reservados.
                </div>
            </footer>
        </div>
    </form>
</body>
</html>