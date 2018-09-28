<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OlvideContrasena.aspx.cs" Inherits="Sis_Cursos.Interfaces.Olvide_Contrasena.OlvideContrasena" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    <link rel="stylesheet" href="../../css/floating-labels.css" type="text/css"/>
	<link rel="icon" type="image/png" href="../../img/favicon.png">
    <title>Recuperar contraseña</title>
</head>
<body>
    <form id="form1" runat="server"  class="form-signin">
        <asp:Panel ID="pFase1" runat="server">
            <div class="text-center mb-4">
                <img class="mb-4" src="../../img/sadface.jpg" alt="" width="72" height="72"/>
                <h1 class="h3 mb-3 font-weight-normal">Recuperar Contraseña</h1>
                <p>Se enviara un código de seguridad a su correo para restablecer<br /> su contraseña</p>
            </div>
            <div class="form-label-group">
                <asp:TextBox ID="inputEmail" runat="server" class="form-control" placeholder="Correo"></asp:TextBox>
                <label for="inputEmail">Correo</label>
            </div>
            <asp:Button ID="btnEnviarCodigo" runat="server" class="btn btn-lg btn-primary btn-block" Text="Enviar" OnClick="btnEnviarCodigo_Click" />
        </asp:Panel>

        <asp:Panel ID="pFase2" runat="server">
            <div class="text-center mb-4">
                <img class="mb-4" src="../../img/sorprise.jpg" alt="" width="72" height="72"/>
                <h1 class="h3 mb-3 font-weight-normal">Recuperar Contraseña</h1>
                <p>Escribe el código de seguridad</p>
            </div>
            <div class="form-label-group">
                <asp:TextBox ID="tbCodigo" runat="server" class="form-control" placeholder="Codigo de Seguridad"></asp:TextBox>
                <label for="tbCodigo">Codigo de Seguridad</label>
            </div>
            <asp:Button ID="btnConfirmar" runat="server" class="btn btn-lg btn-primary btn-block" Text="Confirmar" OnClick="btnConfirmar_Click" />
        </asp:Panel>

        <asp:Panel ID="pFase3" runat="server">
            <div class="text-center mb-4">
                <img class="mb-4" src="../../img/happyface.jpg" alt="" width="72" height="72"/>
                <h1 class="h3 mb-3 font-weight-normal">Recuperar Contraseña</h1>
                <p>Elige una nueva contraseña</p>
            </div>
            <div class="form-label-group">
                <asp:TextBox ID="inputPassword" runat="server" class="form-control" placeholder="Nueva Contraseña"></asp:TextBox>
                <label for="inputPassword">Nueva Contraseña</label>
            </div>
            <div class="form-label-group">
                <asp:TextBox ID="tbConfirmarContra" runat="server" class="form-control" placeholder="Confirmar"></asp:TextBox>
                <label for="tbConfirmarContra">Confirmar</label>
            </div>
            <asp:Button ID="btnCambiar" runat="server" class="btn btn-lg btn-primary btn-block" Text="Cambiar" OnClick="btnCambiar_Click" />
        </asp:Panel>
    </form>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
</body>
</html>
