<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="MVPG52.Paginas.Alumno.Alumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    </div>
    <div class="container-fluid">
        <div class="row row-offcanvas row-offcanvas-left">
            <div class="row-offcanvas row-offcanvas-right">

                <div class="row-offcanvas row-offcanvas-left">

                    <!--Inicia Menu -->
                    <div class="col-xs-6 col-sm-2 sidebar-offcanvas" id="sidebarLeft" role="navigation">
                    </div>

                    <!--/span-->
                    <!--Inicia  el contenido-->
                    <div class="col-xs-12 col-sm-8">
                        <div class="jumbotron">
                            <h1 class="active">Sistemas Compensatorios Upt</h1>
                            <p>Bien venido al sistema compensatorios, para tener una mejor experiencia checa las instrucciones </p>
                        </div>
                        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                            <!-- Indicators -->
                            <ol class="carousel-indicators">
                                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                            </ol>

                            <!-- Wrapper for slides -->
                            <div class="carousel-inner" role="listbox">
                                <div class="item active">
                                    <img src="..." alt="...">
                                    <div class="carousel-caption">
                                        ...
                                    </div>
                                </div>
                                <div class="item">
                                    <img src="..." alt="...">
                                    <div class="carousel-caption">
                                        ...
                                    </div>
                                </div>
                                ...
                            </div>

                            <!-- Controls -->
                            <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                                <span class="sr-only">Previous</span>
                            </a>
                            <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                                <span class="sr-only">Next</span>
                            </a>
                        </div>



                        <div class="row">
                            <div class="col-6 col-sm-6 col-lg-4">
                                <h2>Heading</h2>
                                <p>
                                    Bootstrap is a front-end framework that uses CSS and JavaScript to facilitate responsive Web design. Bootply is a playground for Bootstrap that enables developers and designers to test, prototype and create mockups using Bootstrap
                            friendly HTML, CSS and Javascript.
                                </p>
                                <p><a class="btn btn-default" href="#">View details »</a></p>
                            </div>
                            <!--/span-->
                            <div class="col-sm-6 col-lg-4">
                                <h2>Heading</h2>
                                <p>
                                    Bootply is a playground for Bootstrap that enables developers and designers to test, prototype and create mockups using Bootstrap friendly HTML, CSS and Javascript. Bootstrap is a front-end framework that uses CSS and JavaScript
                            to facilitate responsive Web design.
                                </p>
                                <p><a class="btn btn-default" href="#">View details »</a></p>
                            </div>
                            <!--/span-->
                            <div class="col-sm-6 col-lg-4">
                                <h2>Heading</h2>
                                <p>
                                    Bootstrap is a front-end framework that uses CSS and JavaScript to facilitate responsive Web design. Bootply is a playground for Bootstrap that enables developers and designers to test, prototype and create mockups using Bootstrap
                            friendly HTML, CSS and Javascript.
                                </p>
                                <p><a class="btn btn-default" href="#">View details »</a></p>
                            </div>
                            <!--/span-->
                            <div class="col-lg-6 col-lg-6">
                                <h2>Heading</h2>
                                <p>
                                    Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio
                            dui.
                                </p>
                                <p><a class="btn btn-default" href="#">View details »</a></p>
                            </div>
                            <!--/span-->
                            <div class="col-lg-6 col-lg-6">
                                <h2>Heading</h2>
                                <p>
                                    Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio
                            dui.
                                </p>
                                <p><a class="btn btn-default" href="#">View details »</a></p>
                            </div>
                            <!--/span-->
                            <div class="col-lg-12">
                                <h2>Heading</h2>
                                <p>
                                    Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio
                            dui.
                                </p>
                                <p><a class="btn btn-default" href="#">View details »</a></p>
                            </div>
                            <!--/span-->
                        </div>
                        <!--/row-->
                    </div>
               

                </div>

            </div>
            <!--/row-->
            <hr>
        </div>
        <!--/.container-->
        <script>
            $('.carousel').carousel({
                interval: 15000
            })
            $('#offcanvasleft').click(function () {
                $('.row-offcanvas-left').toggleClass('active');
            });

            $('[data-toggle=offcanvasright]').click(function () {
                $('.row-offcanvas-right').toggleClass('active');
            });
        </script>
    </div>

</asp:Content>
