<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Sis_Cursos.index" %>

<!DOCTYPE html>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    <link rel="stylesheet" href="css/floating-labels.css" type="text/css"/>
    <link rel="stylesheet" href="css/style.css" type="text/css"/>
	<link rel="icon" type="image/png" href="img/favicon.png">
    <title>Iniciar Sesión</title>
</head>
<body>
    <form id="form1" runat="server" class="form-signin">
        <div class="shadow-lg p-3 mb-5 bg-white rounded">
            <div class="text-center mb-4">
                <img class="mb-4" src="img/logicon.png" alt="" width="72" height="72"/>
                <h1 class="h3 mb-3 font-weight-normal">Iniciar Sesión</h1>
             </div>

             <div class="form-label-group">
                <asp:TextBox ID="inputEmail" runat="server" class="form-control" placeholder="Correo"></asp:TextBox>
                <label for="inputEmail">Correo</label>
             </div>

             <div class="form-label-group">
                <asp:TextBox ID="inputPassword" runat="server" class="form-control" placeholder="Contraseña"></asp:TextBox>
                <label for="inputPassword">Contraseña</label>
             </div>
            <div id="enlaces">
                 <div class="enlaces"><asp:HyperLink ID="hplOlvideContrasena" runat="server" NavigateUrl="~/Interfaces/Olvide_Contrasena/OlvideContrasena.aspx">Olvide mi contraseña</asp:HyperLink></div>
                <div class="enlaces"><!--<button type="button" class="btn btn-outline-primary">Registrarse</button>--> <asp:Button ID="btnRegistrarse" runat="server" class="btn btn-outline-primary" Text="Registrarse" /></div>
            </div>
            <asp:Button ID="btnInicio" runat="server" class="btn btn-lg btn-primary btn-block" Text="Iniciar Sesión" />
        </div>
    </form>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
</body>
</html>
