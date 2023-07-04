<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bienvenido.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.bienvenido" %>

<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
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
           <a class="nav-link" href="javascript:history.back()">Volver</a>
          </li>
            
            <li class="nav-item">
            <a class="nav-link" href="index.aspx">Cerrar Sesión</a>
          </li>
         
        </ul>
      </div>
    </nav>
  </header>

  <div class="container">
    <div class="text-center mt-5">
      <h2>Bienvenid@</h2>
    </div>
    <div class="text-center mt-4">
      <img src="https://media.istockphoto.com/id/675179390/es/foto/entrenador-muscular-en-portapapeles.jpg?s=612x612&w=0&k=20&c=eFDuNzHQJfNzOpZGxCPi8pM8bC18EeIm6lgVlmjPuhw=" alt="Imagen motivadora" width="400">
    </div>
    <div class="text-center mt-4">
      <p>Hazlo tú. No esperes a que alguien más lo haga por ti. Tú tienes el poder de alcanzar tus metas y superar tus límites. ¡Atrévete y logra lo que te propones!</p>
    </div>
  </div>

  <footer>
    <div class="text-center">
      &copy; 2023 GYMaster. Todos los derechos reservados.
    </div>
  </footer>

  <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</body>
</html>
