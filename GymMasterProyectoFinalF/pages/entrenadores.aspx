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
            <a class="nav-link" href="bienvenido.aspx">Inicio</a>
          </li>
          
            <li class="nav-item">
            <a class="nav-link" href="gestion_usuarios.aspx">Visualizar tablas</a>
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
    <h1 class="text-center">Conoce nuestros entrenadores</h1>
    <div class="row justify-content-center mt-5">
 
        
     

        
      <div class="col-lg-4">
       
          <div class="card">
            <img src="https://static.vecteezy.com/system/resources/previews/004/675/061/non_2x/personal-trainer-and-client-looking-at-her-progress-at-the-gym-photo.jpg" class="card-img-top" alt="Entrenador 3">
            <div class="card-body">
              <h5 class="card-title">Entrenador 1</h5>
            </div>
          </div>    
      </div>

         <div class="col-lg-4">
       
          <div class="card">
            <img src="https://media.gq.com.mx/photos/6174559e0274cf754fc26a87/16:9/w_2560%2Cc_limit/gimnasio.jpg" class="card-img-top" alt="Entrenador 3">
            <div class="card-body">
              <h5 class="card-title">Entrenador 2</h5>
            </div>
          </div>    
      </div>

      <div class="col-lg-4">
       
          <div class="card">
            <img src="https://previews.123rf.com/images/wavebreakmediamicro/wavebreakmediamicro1510/wavebreakmediamicro151012164/46688341-mujer-y-su-entrenador-por-las-m%C3%A1quinas-de-pesas-en-el-gimnasio.jpg" class="card-img-top" alt="Entrenador 3">
            <div class="card-body">
              <h5 class="card-title">Entrenador 3</h5>
            </div>
          </div>    
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