<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Sis_Cursos.Interfaces.Administrador.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous"/>
	<link rel="stylesheet" type="text/css" href="../../css/style.css"/>
	<link rel="icon" type="image/png" href="../../img/favicon.png"/>
    <title>Administrador</title>
</head>
<body>
    <nav class="navbar navbar-dark bg-dark">
	  <a class="navbar-brand" href="#">
	    <img src="../../img/logo.png" width="35" height="35" class="d-inline-block align-top" alt=""/>
	    Cursos
	  </a>
	  <div class="dropdown">
		  <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
		    Nombre Usuario
		  </button>
		  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
		    <a class="dropdown-item" href="#"><i class="fas fa-edit"></i>Editar</a>
  			<div class="dropdown-divider"></div>
		    <a class="dropdown-item" href="#"><i class="fas fa-sign-out-alt"></i>Cerrar Sesión</a>
		  </div>
		</div>
	</nav>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-2 bg-dark mside">
	          <div id="sidebar" class="bg-dark" class="nav flex-column nav-pills"role="tablist" aria-orientation="vertical">
		          <ul class="list-unstyled components" >
                	    <li>
	                        <a href="#">Inicio<i class="fas fa-home"></i></a>
	                    </li>
	                    <li class="active">
	                        <a href="#EstudianteSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle-lm bg-dark">Estudiantes<i class="fas fa-caret-down"></i></a>
	                        <ul class="collapse list-unstyled bg-dark" id="EstudianteSubmenu">
	                            <li>
	                                <a href="#">Mostrar</a>	 
	                            </li>
	                            <li>
	                                <a href="#">Eliminar</a>
	                            </li>
	                        </ul>
	                    </li>
	                    <li>
	                        <a href="#DocenteSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle-lm bg-dark">Docentes<i class="fas fa-caret-down"></i></a>
	                        <ul class="collapse list-unstyled" id="DocenteSubmenu">
	                            <li>
	                                <a href="#">Agregar</a>	 
	                            </li>
	                            <li>
	                                <a href="#">Mostrar</a>
	                            </li>
	                            <li>
	                                <a href="#">Agregar a curso</a>
	                            </li>
	                            <li>
	                                <a href="#">Eliminar</a>
	                            </li>
	                        </ul>
	                    </li>
	                    <li>
	                        <a href="#CursosSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle-lm bg-dark">Cursos<i class="fas fa-caret-down"></i></a>
	                        <ul class="collapse list-unstyled" id="CursosSubmenu">
	                            <li>
	                                <a href="#">Agregar</a>	 
	                            </li>
	                            <li>
	                                <a href="#">Mostrar</a>
	                            </li>
	                            <li>
	                                <a href="#">Modificar</a>
	                            </li>
	                            <li>
	                                <a href="#">Eliminar</a>
	                            </li>
	                        </ul>
	                    </li>
	                </ul>
	            </div>
	        </div>
	      </div>
	      <div class="col-10 contenedor">

	      </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
