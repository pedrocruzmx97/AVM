<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="MVPG52.Sesion" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <!--Import materialize.css-->
    <link href="Content/materialize.min.css" rel="stylesheet" />
    <link href="Content/materialize.css" rel="stylesheet" />
    <%--<link href="Content/bootstrap.min.css" rel="stylesheet" />--%>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <style type="text/css">
        .modal {
            width: 35% !important;
            max-height: 55% !important;
        }

        .modal-form-row {
            margin-bottom: 0px;
        }

        img {
            width: 100%;
        }

        button {
            width: 100px;
            height: 100px;
        }

        .parallax-container {
            height: 270px;
        }


        .material-icons {
            font-size: 50px;
            text-align: left;
        }

        body {
            background-color: #e2e2e2;
        }
    </style>


    <title>Inicio de Sesión</title>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="width: auto">
            <%-- <%--menu--%>

            <%-- Paralax container  --%>
            <div class="parallax-container">
                <div class="parallax">
                    <img src="IMAG\universidad\baner.jpg" class="responsive-img" style="height: auto" />
                </div>
            </div>
            <%-- Carrusel sesion container   --%>
            <div class="section white" style="margin: auto; text-align: center">
                <h3 class="header" style="text-align: center">Bienvenido al Sistema de Servicios Compensatorios UPT </h3>
                <br />
                <p class="grey-text text-darken-3 lighten-3 center">En el siguiente apartado podrás encontrar los servicios como son: servicios médicos, tutoría y asesorías.</p>
                <br />
                <div class="row">
                    <div class="#0277bd light-blue darken-3 col s8 offset-s2  z-depth-5">
                        <div class="carousel ">
                            <a class="carousel-item tooltipped" data-position="top" data-tooltip="Servicios Médicos" href="#modal1">
                                <img src="imag\sesion\botiquin.png" /></a>
                            <a class="carousel-item tooltipped" data-position="top" data-tooltip="Asesorias" href="#login">
                                <img src="imag\sesion\conferencias.png" />
                            </a>
                            <a class="carousel-item tooltipped" data-position="top" data-tooltip="Tutorias" href="#modal1">
                                <img src="imag\sesion\charlar.png" /></a>
                        </div>
                    </div>
                </div>
                <br />
            </div>
            <%-- Carrusel sesion container End  --%>
          < <footer class="page-footer #b71c1c red darken-4">
                <div>




                    <div class="row">
                        <div class="col s2 center-align">
                            <img src="imag/universidad/logoUpt.png" style="width: 70%" />
                        </div>
                        <div class="col l4 s4">
                            <h4 class="white-text">Sistemas Compensatorios UPT</h4>
                            <p class="grey-text text-lighten-4">© Universidad Politécnica de Tulancingo.  Calle Ingenierías # 100. Col. Huapalcalco, Hidalgo, México C.P. 43629, Teléfono: 01(775) 75 5 82 02, Fax: 01(775) 75 5 83 21.</p>
                        </div>
                        <div class="col l2 offset-l1 s1">
                            <h4 class="white-text">Servicios.</h4>
                            <ul>
                                <li><a class="grey-text text-lighten-3" href="http://www.upt.edu.mx/">upt.edu.mx</a></li>
                                <li><a class="grey-text text-lighten-3" href="http://201.116.38.19/conect_uptvxxi/default.asp">Conect</a></li>
                                <li><a class="grey-text text-lighten-3" href="#!">Aviso legal</a></li>
                            </ul>
                        </div>
                        <div class="row">
                            <div class="col s2 center-align">
                                <img src="imag/universidad/logo.png" style="width: 90%" class="responsive-img" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="footer-copyright">
                    <div class="container">
                        © 2017 Universidad Politécnica de Tulancingo
            <a class="grey-text text-lighten-4 right" href="/Desarroladores.aspx">Webmasters</a>
                    </div>
                </div>
            </footer>
            <%--modal--%>
            <div id="modal1" class="modal">
                <div class="modal-content #1e88e5 blue darken-1">
                    <div class="#1e88e5 blue darken-1" style="color: white; text-align: center">
                        <h3 style="font-size: x-large">Inicio de Sesión</h3>
                    </div>
                    <div class="row #ffffff white">
                        <div class="col s12 m4 l2">
                        </div>
                        <div class="col s12 m4 l8">
                            <div class="input-field ">
                                <i class="material-icons prefix">person_pin</i>
                                <asp:TextBox ID="TextBoxNumeroDeControl" runat="server" required="" CssClass="form-control input-lg" value="" pattern="[0-9]{2,7}" title="Solo números. Tamaño :7 dijitos"></asp:TextBox>
                                <label for="icon_prefix2" style="font-size: medium">Id</label>
                            </div>
                            <div class="input-field">
                                <i class="material-icons prefix">vpn_key</i>
                                <asp:TextBox ID="TextBoxContrasena" runat="server" required="" CssClass="form-control input-lg" TextMode="Password" pattern="[A-Za-z0-9]{3,25}" title="Letras y números. Tamaño mínimo: 5. Tamaño máximo: 25"></asp:TextBox>
                                <label for="icon_prefix2" style="font-size: 15px">Contraseña</label>
                            </div>
                            <div class="row center-align">
                                <div class="col s12 m4 l2">
                                </div>
                                <div class="col s12 m4 l8 center-align">
                                    <asp:DropDownList ID="DropDownListRoles" runat="server"></asp:DropDownList>
                                    <br />
                                    <asp:Button ID="Button1" runat="server" Text="Iniciar" OnClick="Button1_Click" CssClass="btn btn-lg btn-primary btn-block btn-signin" />
                                </div>
                                <div class="col s12 m4 l2">
                                </div>
                            </div>
                        </div>
                        <div class="col s12 m4 l2">
                        </div>
                    </div>
                </div>
            </div>
            </div>
    </form>
    <!--Import jQuery before materialize.js-->
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/materialize.min.js"></script>
    <script>
        $(document).ready(function () {

            //código que queremos ejecutar
            $('.carousel').carousel();
            $('select').material_select();
            $('.parallax').parallax();
            $('.tooltipped').tooltip({ delay: 15 });
            $(".button-collapse").sideNav();
            $('.button-collapse').sideNav({
                menuWidth: 300, // Default is 300
                edge: 'left', // Choose the horizontal origin
                closeOnClick: true, // Closes side-nav on <a> clicks, useful for Angular/Meteor
                draggable: true, width: 40, height: 30
                // Choose whether you can drag to open on touch screens

            });
            $('.modal').modal();


        });

    </script>
    <script type="text/javascript">
        function quitarmensaje() {
            $('.tooltipped').tooltip('remove');

        }
    </script>
</body>
</html>
