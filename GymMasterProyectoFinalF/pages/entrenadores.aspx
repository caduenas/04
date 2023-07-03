<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="entrenadores.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.entrenadores" %>

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
            <a class="nav-link" href="#">Servicios</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Acerca de</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Contacto</a>
          </li>
            <li class="nav-item">
            <a class="nav-link" href="central_usuarios.aspx">Volver</a>
          </li>
            <li class="nav-item">
            <a class="nav-link" href="#">Cerrar Sesión</a>
          </li>
        </ul>
      </div>
    </nav>
  </header>

  <div class="container">
    <h1 class="text-center">Conoce nuestros entrenadores</h1>
    <div class="row justify-content-center mt-5">
      <div class="col-lg-4">
        <a href="entrenador1.html" class="card-link">
          <div class="card">
            <img src="ruta_imagen_entrenador1.jpg" class="card-img-top" alt="Entrenador 1">
            <div class="card-body">
              <h5 class="card-title">Entrenador 1</h5>
              <p class="card-text">Descripción del entrenador 1.</p>
            </div>
          </div>
        </a>
      </div>
      <div class="col-lg-4">
        <a href="entrenador2.html" class="card-link">
          <div class="card">
            <img src="ruta_imagen_entrenador2.jpg" class="card-img-top" alt="Entrenador 2">
            <div class="card-body">
              <h5 class="card-title">Entrenador 2</h5>
              <p class="card-text">Descripción del entrenador 2.</p>
            </div>
          </div>
        </a>
      </div>
      <div class="col-lg-4">
        <a href="entrenador3.html" class="card-link">
          <div class="card">
            <img src="ruta_imagen_entrenador3.jpg" class="card-img-top" alt="Entrenador 3">
            <div class="card-body">
              <h5 class="card-title">Entrenador 3</h5>
              <p class="card-text">Descripción del entrenador 3.</p>
            </div>
          </div>
        </a>
      </div>
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