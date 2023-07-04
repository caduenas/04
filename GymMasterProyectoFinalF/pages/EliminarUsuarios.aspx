<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarUsuarios.aspx.cs" Inherits="GymMasterProyectoFinalF.pages.EliminarUsuarios" %>

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
    <h1>Eliminación de Usuarios</h1>
    <form runat="server">
        <label for="nombre">ID Usuario:</label>
        <asp:TextBox ID="IDusuario" runat="server" type="text" name="ID Usuario"  placeholder="Ingrese su ID" ></asp:TextBox>
        <br>
        <label for="email">Contraseña:</label>
        <asp:TextBox ID="contrasena" runat="server" type="password" name="contraseña"  placeholder="Ingrese su contraseña" ></asp:TextBox>
        <br>
 
        <br>
        <asp:Button ID="Eliminar" runat="server" Text="Eliminar" OnClick="Eliminar_Click"/>
        <asp:Button ID="volver" runat="server" Text="Volver" BackColor="#FF0000" OnClick="volver_Click" />
      <div id="Resultado">
    <asp:Label ID="resultadoLabel" runat="server" Text=""></asp:Label>
</div>

     </form>
         

</body>
</html>
