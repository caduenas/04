<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.index1" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Index</title>
  <style>
    body {
      background-color: #f2f2f2;
      font-family: Arial, sans-serif;
    }
    
    .container {
      max-width: 400px;
      margin: 0 auto;
      padding: 40px;
      background-color: #fff;
      border-radius: 5px;
      box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
      text-align: center;
      position: absolute;
      top: 50%;
      left: 50%;
      transform: translate(-50%, -50%);
    }
    
    h1 {
      margin-top: 0;
      color: #333;
    }
    
    .btn {
      display: block;
      width: 200px;
      padding: 10px 20px;
      margin: 10px auto;
      background-color:aquamarine;
      color: #fff;
      font-size: 16px;
      text-decoration: none;
      border-radius: 5px;
      transition: background-color 0.3s;
    }
    
    .btn:hover {
      background-color: #00c0c7;
    }
  </style>
</head>
<body>
  <div class="container">
    <h1>Bienvenido a GymMaster</h1>
    <h3>Elige una opcion</h3>
    <a href="Opciones_login.aspx" class="btn">Iniciar sesión</a>
    <a href="Opciones_registro.aspx" class="btn">Registrarse</a>

  </div>
</body>
</html>
