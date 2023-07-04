<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro_usuarios.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.registro_usuarios" %>

<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Formulario de Inicio de Sesión</title>
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
    
    .form-group {
      margin-bottom: 20px;
    }
    
    .form-group label {
      display: block;
      text-align: left;
      margin-bottom: 5px;
      color: #333;
    }
    
    .form-group input {
      width: 100%;
      padding: 8px;
      font-size: 14px;
      border: 1px solid #ccc;
      border-radius: 4px;
      box-sizing: border-box;
    }
    
    .btn-login {
      display: block;
      width: 100%;
      padding: 10px;
      background-color: #00c0c7;
      color: #fff;
      font-size: 16px;
      text-decoration: none;
      border: none;
      border-radius: 5px;
      transition: background-color 0.3s;
    }
    
    .btn-login:hover {
      background-color: #008a93;
    }
    
    .btn-volver {
      display: block;
      width: 80px;
      padding: 3px 6px;
      margin: 10px auto;
      background-color: crimson;
      color: #fff;
      font-size: 16px;
      text-decoration: none;
      border-radius: 5px;
      transition: background-color 0.3s;
    }
    
    .btn-volver:hover {
      background-color: #c70000;
    }
  </style>
</head>
<body>
  <div class="container">
    <h1>Registrar</h1>
    <h3>Usuario</h3>
    <form runat="server">

      <div class="form-group">
        <label for="username">Nombres Completos:</label>
          <asp:TextBox ID="nombresComple" runat="server" type="text" name="username" placeholder="Ingrese su nombre completo"></asp:TextBox>
      </div>

      <div class="form-group">
        <label for="username">Apellidos Completos:</label>
          <asp:TextBox ID="apellidosComple" runat="server" type="text" name="username" placeholder="Ingrese su apellido completo"></asp:TextBox>
      </div>


            <div class="form-group">

        <label for="username">Correo:</label>
          <asp:TextBox ID="correoElect" runat="server" type="email" name="username" placeholder="Ingrese su correo electronico"></asp:TextBox>
      </div>

         <div class="form-group">
        <label for="username">Numero:</label>
          <asp:TextBox ID="numero" runat="server" type="text" name="username" placeholder="Ingrese su numero celular"></asp:TextBox>
      </div>

                <div class="form-group">
        <label for="username">Edad:</label>
          <asp:TextBox ID="Edad" runat="server"  name="username" placeholder="Ingrese su usuario"></asp:TextBox>
      </div>

              <div class="form-group">
        <label for="username">Peso:</label>
          <asp:TextBox ID="Peso" runat="server"  name="username" placeholder="Ingrese su usuario"></asp:TextBox>
      </div>

           
      <div class="form-group">
        <label for="username">Altura:</label>
          <asp:TextBox ID="Altura" runat="server"  name="username" placeholder="Ingrese su usuario"></asp:TextBox>
      </div>
         <label for="username">Meta:</label>
            <asp:DropDownList ID="meta" runat="server">
            <asp:ListItem Text="Bajar de peso" Value="Bajar de peso"></asp:ListItem>
            <asp:ListItem Text="Aumento de masa muscular" Value="Aumento masa"></asp:ListItem>
            <asp:ListItem Text="Nutricion" Value="Nutricion"></asp:ListItem>
            <asp:ListItem Text="Equilibrado" Value="Equilibrado"></asp:ListItem>
        </asp:DropDownList>

      <div class="form-group">
        <label for="password">Contraseña:</label>
          <asp:TextBox ID="password" runat="server"  type="password" name="password" placeholder="Ingrese su contraseña" ></asp:TextBox>
      </div>

      <div class="form-group">
        <label for="confirmarPassword">Confirmar Contraseña:</label>
            <asp:TextBox ID="confirmarPassword" runat="server" type="password" name="username" placeholder="comfirmar contraseña"></asp:TextBox>
       
      </div>
    
      
      
        <asp:Table ID="Table1" runat="server"></asp:Table>
        <asp:Button ID="botonIngresar" runat="server" Text="Ingresar" type="submit" class="btn-login" OnClick="botonIngresar_Click1"/>
    </form>
    <a href="Opciones_registro.aspx" class="btn-volver">Volver</a>
  </div>
</body>
</html>
