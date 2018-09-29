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
    <style type="text/css">
        EstiloTitulo {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: x-large;
        }
        .EstiloTitulo {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: large;
        }
        .EstiloTitulo {
        }
        .EstiloTitulo {
        }
        .auto-style1 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: large;
        }
        .EstiloTitulo {
        }
        .EstiloTitulo {
        }
        .EstiloTitulo {
        }
        .EstiloTitulo {
        }
    </style>
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
		    <a class="dropdown-item" href="../../index.aspx"><i class="fas fa-sign-out-alt"></i>Cerrar Sesión</a>
		  </div>
		</div>
	</nav>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-2 bg-dark mside">
	          <div id="sidebar" class="bg-dark nav flex-column nav-pills"role="tablist" aria-orientation="vertical">
		          <ul class="list-unstyled components" >
                	    <li>
	                        <a href="#">Inicio<i class="fas fa-home"></i></a>
	                    </li>
	                    <li class="active">
	                        <a href="#EstudianteSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle-lm bg-dark">Estudiantes<i class="fas fa-caret-down"></i></a>
	                        <ul class="collapse list-unstyled bg-dark" id="EstudianteSubmenu">
	                            <li>
	                                <asp:Button ID="btnMostrarEstudiantes" runat="server" Text="Mostrar" class="btnMenuLtr" OnClick="btnMostrarEstudiantes_Click"/>
	                            </li>
	                            <li>
	                                <asp:Button ID="btnEliminarEstudiante" runat="server" Text="Eliminar" class="btnMenuLtr" OnClick="btnEliminarEstudiante_Click"/>
	                            </li>
	                        </ul>
	                    </li>
	                    <li>
	                        <a href="#DocenteSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle-lm bg-dark">Docentes<i class="fas fa-caret-down"></i></a>
	                        <ul class="collapse list-unstyled" id="DocenteSubmenu">
	                            <li>
	                                <asp:Button ID="btnAgregarDocente" runat="server" Text="Agregar" class="btnMenuLtr" OnClick="btnAgregarDocente_Click"/>
	                            </li>
	                            <li>
	                                <asp:Button ID="btnMostrarDocente" runat="server" Text="Mostrar" class="btnMenuLtr" OnClick="btnMostrarDocente_Click"/>
	                            </li>
	                            <li>
	                                <asp:Button ID="btnAgregarDocenteCurso" runat="server" Text="Agregar a curso" class="btnMenuLtr" OnClick="btnAgregarDocenteCurso_Click"/>
	                            </li>
	                            <li>
	                                <asp:Button ID="btnEliminarDocente" runat="server" Text="Eliminar" class="btnMenuLtr" OnClick="btnEliminarDocente_Click"/>
	                            </li>
	                        </ul>
	                    </li>
	                    <li>
	                        <a href="#CursosSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle-lm bg-dark">CursosCursos<i class="fas fa-caret-down"></i></a>
	                        <ul class="collapse list-unstyled" id="CursosSubmenu">
	                            <li>
	                                <asp:Button ID="btnAgregarCurso" runat="server" Text="Agregar" class="btnMenuLtr" OnClick="btnAgregarCurso_Click"/>
	                            </li>
	                            <li>
	                                <asp:Button ID="btnMostrarCurso" runat="server" Text="Mostrar" class="btnMenuLtr" OnClick="btnMostrarCurso_Click"/>
	                            </li>
	                            <li>
	                                <asp:Button ID="btnModificarCurso" runat="server" Text="Modificar" class="btnMenuLtr" OnClick="btnModificarCurso_Click"/>
	                            </li>
	                            <li>
	                                <asp:Button ID="btnEliminarCurso" runat="server" Text="Eliminar" class="btnMenuLtr" OnClick="btnEliminarCurso_Click"/>
	                            </li>
	                        </ul>
	                    </li>
	                </ul>
	            </div>
	        </div>
	      </div>
        <div class="col-10 contenedor">
            <div class="tab-content" id="v-pills-tabContent">
                <asp:Panel ID="pMostrarEstudiantes" runat="server" style="position: relative; text-align: center">
                    <strong>
                    <br />
                    </strong>&nbsp;<span class="EstiloTitulo">Mostrar Estudiantes</span><strong><br />
                    <br />
                    </strong>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" HeaderStyle-CssClass=" " HorizontalAlign="Center" ItemStyle="" ItemStyle-CssClass=" " VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellidos" SortExpression="Apellido" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo Electronico" SortExpression="Correo" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT [Nombre], [Apellido], [Correo], [Pass] FROM [Usuarios]"></asp:SqlDataSource>
                </asp:Panel>
                <asp:Panel ID="pEliminarEstudiante" runat="server" style="position: relative; text-align: center">
                    <br />
                    <span class="EstiloTitulo">Eliminar Estudiantes</span><br />
                    <br />
                    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" HeaderStyle-CssClass=" " HorizontalAlign="Center" ItemStyle="" ItemStyle-CssClass=" " VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellidos" SortExpression="Apellido" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo Electronico" SortExpression="Correo" />
                            <asp:ButtonField ButtonType="Image" HeaderImageUrl="~/img/Eliminar.png" ImageUrl="~/img/Eliminar.png" Text="Botón" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <br />
                    <br />
                </asp:Panel>
                <asp:Panel ID="pAgregarDocente" runat="server">Agregar Docente</asp:Panel>
                <asp:Panel ID="pMostrarDocente" runat="server" style="position: relative; text-align: center;">
                    <span class="EstiloTitulo">
                    <br />
                    &nbsp;Mostrar Docente<br />
                    <br />
                    </span>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" HeaderStyle-CssClass=" " HorizontalAlign="Center" ItemStyle="" ItemStyle-CssClass=" " VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellidos" SortExpression="Apellido" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo Electronico" SortExpression="Correo" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT [Nombre], [Apellido], [Correo] FROM [Usuarios]"></asp:SqlDataSource>
                </asp:Panel>
                <asp:Panel ID="pAgregarDocenteCurso" runat="server">Agregar Docente a curso</asp:Panel>
                <asp:Panel ID="pEliminarDocente" runat="server" style="position: relative; text-align: center">
                    <br />
                    <span class="EstiloTitulo">Eliminar Docente</span><br />
                    <br />
                    <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" HeaderStyle-CssClass=" " HorizontalAlign="Center" ItemStyle="" ItemStyle-CssClass=" " VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellidos" SortExpression="Apellido" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo Electronico" SortExpression="Correo" />
                            <asp:ButtonField ButtonType="Image" HeaderImageUrl="~/img/Eliminar.png" ImageUrl="~/img/Eliminar.png" Text="Botón" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <br />
                </asp:Panel>
                <asp:Panel ID="pAgregarCurso" runat="server">Agregar Curso</asp:Panel>
                <asp:Panel ID="pMostrarCurso" runat="server" style="position: relative; text-align: center;">
                    <span class="auto-style1"><strong>
                    <br />
                    </strong>Mostrar Curso<strong><br />
                    <br />
                    </strong></span>
                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource3" ForeColor="Black" GridLines="Horizontal" HeaderStyle-CssClass=" " HorizontalAlign="Center" ItemStyle="" ItemStyle-CssClass=" " VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion " SortExpression="Descripcion" />
                            <asp:BoundField DataField="FechaIn" HeaderText="Inicio" SortExpression="FechaIn" />
                            <asp:BoundField DataField="FechaFn" HeaderText="Fin" SortExpression="FechaFn" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT [Nombre], [Descripcion], [FechaIn], [FechaFn] FROM [Curso]"></asp:SqlDataSource>
                </asp:Panel>
                <asp:Panel ID="pModificarCurso" runat="server">
                    <div class="text-center">
                        <span class="EstiloTitulo">
                        <br />
                        Modificar Curso<strong><br />
                        <br />
                            </strong></span>
                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource3" ForeColor="Black" GridLines="Horizontal" HeaderStyle-CssClass=" " HorizontalAlign="Center" ItemStyle="" ItemStyle-CssClass=" " VerticalAlign="Middle">
                        <Columns>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                        <asp:BoundField DataField="FechaIn" HeaderText="Inicio" SortExpression="FechaIn" />
                        <asp:BoundField DataField="FechaFn" HeaderText="Fin" SortExpression="FechaFn" />
                        <asp:ButtonField ButtonType="Image" HeaderImageUrl="~/img/Modificar.png" ImageUrl="~/img/Modificar.png" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionBD %>" SelectCommand="SELECT [Nombre], [Descripcion], [FechaIn], [FechaFn] FROM [Curso]"></asp:SqlDataSource>
                        
                    </div>

                </asp:Panel>
                <asp:Panel ID="pEliminarCurso" runat="server" style="position: relative; text-align: center"><span class="EstiloTitulo">
                    <br />
                    Eliminar Curso<br />
                    <br />
                    </span>
                    <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource3" ForeColor="Black" GridLines="Horizontal" HeaderStyle-CssClass=" " HorizontalAlign="Center" ItemStyle="" ItemStyle-CssClass=" " VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                            <asp:BoundField DataField="FechaIn" HeaderText="Inicio" SortExpression="FechaIn" />
                            <asp:BoundField DataField="FechaFn" HeaderText="Fin" SortExpression="FechaFn" />
                            <asp:ButtonField ButtonType="Image" HeaderImageUrl="~/img/Eliminar.png" ImageUrl="~/img/Eliminar.png" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    <br />
                </asp:Panel>
            </div>
	    </div>
	      
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>