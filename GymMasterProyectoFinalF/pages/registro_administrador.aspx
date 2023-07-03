<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro_administrador.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.registro_administrador" %>

<!DOCTYPE html>
<html lang="en">
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
        <h3>Administrador</h3>
        <form runat="server">
            <div class="form-group">
                <label for="username">Ingresar nombre:</label>
                <asp:TextBox ID="nombreCompleto" runat="server" type="text" name="username" placeholder="Ingrese sus nombres completos"></asp:TextBox>

            </div>

            <div class="form-group">
                <label for="username">Ingrese su apellido completo:</label>
                <asp:TextBox ID="ApellidoCompleto" runat="server" type="text" name="username" placeholder="Ingrese sus apellidos completos"></asp:TextBox>

            </div>

            <div class="form-group">
                <label for="username">Ingrese su correo: </label>
                <asp:TextBox ID="correoElectro" runat="server" type="email" name="username" placeholder="Ingrese su correo"></asp:TextBox>

            </div>

            <div class="form-group">
                <label for="username">Ingrese su telefono:</label>
                <asp:TextBox ID="numCelular" runat="server" type="text" name="username" placeholder="Ingrese su numero de celular"></asp:TextBox>

            </div>


            <div class="form-group">
                <label for="password">Contraseña:</label>
                <asp:TextBox ID="password" runat="server" TextMode="Password" placeholder="Ingrese su contraseña"></asp:TextBox>

            </div>

            <div class="form-group">
                <label for="confirmarPassword">Confirmar Contraseña:</label>
                <asp:TextBox ID="confirmarPassword" runat="server" type="password" name="username" placeholder="comfirmar contraseña"></asp:TextBox>

            </div>
  
        <asp:Button ID="botonIngresarR" runat="server" Text="Ingresar" type="submit" class="btn-login" OnClick="botonIngresarR_Click"/>

    </form>
    <a href="Opciones_registro.aspx" class="btn-volver">Volver</a>
    </div>
</body>
</html>
