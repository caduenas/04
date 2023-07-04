<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarUsuarios.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.InsertarUsuarios" %>

<!DOCTYPE html>
<html>
<head>
    <title>Consulta de Usuarios</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            padding: 20px;
        }

        h1 {
            color: #333;
        }

        form {
            background-color: #fff;
            padding: 20px;
            border-radius: 4px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

        label {
            display: block;
            margin-bottom: 10px;
            color: #555;
        }

        input[type="text"],
        input[type="email"],
        input[type="number"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin-bottom: 20px;
        }

        input[type="submit"] {
            background-color: #4CAF50;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 4px;
            cursor: pointer;
        }

            input[type="submit"]:hover {
                background-color: #45a049;
            }

        #Resultado {
            margin-top: 20px;
            border: 1px solid #ccc;
            border-radius: 4px;
            padding: 10px;
            background-color: #fff;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

            /* Estilo para la tabla */
            #Resultado table {
                width: 100%;
                border-collapse: collapse;
            }

            /* Estilo para las celdas de encabezado de la tabla */
            #Resultado th {
                background-color: #f2f2f2;
                border: 1px solid #ccc;
                padding: 8px;
                text-align: left;
            }

            /* Estilo para las celdas de datos de la tabla */
            #Resultado td {
                border: 1px solid #ccc;
                padding: 8px;
            }
    </style>
</head>
<body>
    <h1>Insertar Usuarios</h1>
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
            <asp:TextBox ID="Edad" runat="server" name="username" placeholder="Ingrese su usuario"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="username">Peso:</label>
            <asp:TextBox ID="Peso" runat="server" name="username" placeholder="Ingrese su usuario"></asp:TextBox>
        </div>


        <div class="form-group">
            <label for="username">Altura:</label>
            <asp:TextBox ID="Altura" runat="server" name="username" placeholder="Ingrese su usuario"></asp:TextBox>
        </div>

         <label for="username">Meta:</label>
        <asp:DropDownList ID="meta" runat="server">
            <asp:ListItem Text="Bajar de peso" Value="1"></asp:ListItem>
            <asp:ListItem Text="Aumento de masa muscular" Value="2"></asp:ListItem>
            <asp:ListItem Text="Nutricion" Value="3"></asp:ListItem>
            <asp:ListItem Text="Equilibrado" Value="3"></asp:ListItem>
        </asp:DropDownList>

        <div class="form-group">
            <label for="password">Contraseña:</label>
            <asp:TextBox ID="password" runat="server" type="password" name="password" placeholder="Ingrese su contraseña"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="confirmarPassword">Confirmar Contraseña:</label>
            <asp:TextBox ID="confirmarPassword" runat="server" type="password" name="username" placeholder="comfirmar contraseña"></asp:TextBox>

        </div>



        <asp:Table ID="Table1" runat="server"></asp:Table>
        <asp:Button ID="botoninsertar" runat="server" Text="Insertar" type="submit" class="btn-login" OnClick="botoninsertar_Click" />
        <asp:Button ID="volver" runat="server" Text="Volver" BackColor="#FF0000" OnClick="volver_Click" />
        <div id="Resultado">
            <asp:Label ID="resultadoLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>


</body>
</html>
