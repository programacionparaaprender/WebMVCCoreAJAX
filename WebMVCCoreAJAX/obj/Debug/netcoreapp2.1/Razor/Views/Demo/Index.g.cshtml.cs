#pragma checksum "C:\Users\LuisCorrea\Documents\proyectos_net\proyectos_c#\web\WebMVCCoreAJAX\WebMVCCoreAJAX\Views\Demo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf64b5d235a4edb41413498b63698e9594c5c1c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Index), @"mvc.1.0.view", @"/Views/Demo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demo/Index.cshtml", typeof(AspNetCore.Views_Demo_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf64b5d235a4edb41413498b63698e9594c5c1c4", @"/Views/Demo/Index.cshtml")]
    public class Views_Demo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("mainController"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 61, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<html  ng-app=\'angularRoutingApp\'>\r\n");
            EndContext();
            BeginContext(61, 3074, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da76a335e334bc6999c3fa62e392192", async() => {
                BeginContext(67, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
                BeginContext(252, 2876, true);
                WriteLiteral(@"    <script src=""js/jquery-2.2.3.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $('#buttonLibro2').click(function () {
                var nombre = $('#nombre').val();
                var apellido = $('#apellido').val();
                $.ajax({
                    type: 'GET',
                    url: '/demo/create2/' + nombre + '&' + apellido,
                    success: function (result) {
                        $('#resultlibro').html(result);
                    }
                });
            });

            $('#buttonLibro').click(function () {
                var name = $('#name').val();
                $.ajax({
                    type: 'GET',
                    url: '/demo/create/' + name,
                    success: function (result) {
                        $('#resultlibro').html(result);
                    }
                });
            });

            $('#buttonDemo1').click(function () {
        ");
                WriteLiteral(@"        $.ajax({
                    type: 'GET',
                    url: '/demo/demo1',
                    success: function (result) {
                        $('#result1').html(result);
                    }
                });
            });

            $('#buttonDemo2').click(function () {
                var fullName = $('#fullName').val();
                $.ajax({
                    type: 'GET',
                    url: '/demo/demo2/' + fullName,
                    success: function (result) {
                        $('#result2').html(result);
                    }
                });
            });

            $('#buttonDemo3').click(function () {
                $.ajax({
                    type: 'GET',
                    url: '/demo/demo3',
                    success: function (result) {
                        var s = 'Id: ' + result.id;
                        s += '<br>Name: ' + result.name;
                        s += '<br>Price: ' + result.price;
        ");
                WriteLiteral(@"                $('#result3').html(s);
                    }
                });
            });

            $('#buttonDemo4').click(function () {
                $.ajax({
                    type: 'GET',
                    url: '/demo/demo4',
                    success: function (result) {
                        var s = '';
                        for (var i = 0; i < result.length; i++) {
                            s += '<br>Id: ' + result[i].id;
                            s += '<br>Name: ' + result[i].name;
                            s += '<br>Price: ' + result[i].price;
                            s += '<br>------------------';
                        }
                        $('#result4').html(s);
                    }
                });
            });

        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3137, 9386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0775acf836b440e49dbbe0ac11aa10bf", async() => {
                BeginContext(3174, 9342, true);
                WriteLiteral(@"

    <fieldset>
        <legend>Enviar imagen con AngularJS</legend>
        
            <input id=""filename"" name=""filename"" type=""file""  />
            <img src="""" height=""200"" alt=""Image preview..."">
            <div>
            </div>
            <button ng-click=""enviarImagen()"">
                Enviar Imagen
            </button>
        
        <div style=""display:block;""><h2>Canvas</h2></div>
        <canvas id=""micanvas"" width=""150"" height=""150"" style=""display:block""></canvas>

        <canvas id=""mipintado"" width=""150"" height=""150"" style=""display:block; border:10px #ccc solid;""></canvas>
        <img id=""otraimg"" src="""" width=""150"" height=""150"" style=""display:block; border:10px #ccc solid;"" />
    </fieldset>

    <fieldset>
        <legend>Crear Libro</legend>
        Nombre <input type=""text"" id=""nombre"" /> <br />
        Apellido <input type=""text"" id=""apellido"" />
        <input type=""button"" value=""Ingresar"" id=""buttonLibro2"" />
        <br />
        <span id=""res");
                WriteLiteral(@"ultlibro""></span>
    </fieldset>

    <fieldset>
        <legend>Crear Libro</legend>
        Nombre <input type=""text"" id=""name"" />
        <input type=""button"" value=""Nombre 1"" id=""buttonLibro"" />
        <br />
        <span id=""resultlibro""></span>
    </fieldset>


    <fieldset>
        <legend>Demo 1</legend>
        <input type=""button"" value=""Demo 1"" id=""buttonDemo1"" />
        <br />
        <span id=""result1""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 2</legend>
        Full Name <input type=""text"" id=""fullName"" />
        <input type=""button"" value=""Demo 2"" id=""buttonDemo2"" />
        <br />
        <span id=""result2""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 3</legend>
        <input type=""button"" value=""Demo 3"" id=""buttonDemo3"" />
        <br />
        <span id=""result3""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 4</legend>
        <input type=""button"" value=""Demo 4"" id=""buttonDemo4"" />
        <br />
");
                WriteLiteral(@"        <span id=""result4""></span>
    </fieldset>


    <script src=""//cdnjs.cloudflare.com/ajax/libs/angular.js/1.2.7/angular.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/angular.js/1.2.3/angular-route.js""></script>
    <script type=""text/javascript"">
        // Creación del módulo
        var angularRoutingApp = angular.module('angularRoutingApp', []);

        var urlServicio = ""http://www.programandoconrupert.com/ws/servicio-gatos.php"";

        var RegistroImagen = {};

        angularRoutingApp.controller(""mainController"", [""$scope"", ""$http"", function ($scope, $http) {
            $scope.gatos = [];
            
        
            $scope.enviarImagen = function () {
                //console.log(RegistroImagen.data);
                var cadena = RegistroImagen.data;
                //data = JSON.stringify(data);

                var data = cadena.substring(27, cadena.length -1);   
                //console.log(cadena);
                console.log(caden");
                WriteLiteral(@"a.substring(0, 27));
                console.log(cadena.substring(27, cadena.length -1));
                //$http({
                //    method: ""GET"",
                //    url: '/demo/guardarImagen?data=' + data
                    
                //}).then(function correcto(respuesta) {
                //    //resultlibro3.innerHTML = respuesta.data;
                //},
                //    function error(respuesta) {
                //        alert(respuesta.statusText);
                //    });

                $http({
                        url: ""localhost:44308/api/Values"",
                        type: ""POST"",
                        data: JSON.stringify(data),
                        dataType: ""json"",
                        contentType: ""application/json"",
                        success: function (result) {
                            //var json = JSON.stringify(result)
                            //alert(json);
                            
                            v");
                WriteLiteral(@"ar mipintado = document.getElementById(""mipintado"");
                            var nuevaimg = new Image();
                            nuevaimg.src = result;//json.data;//reader.result;//micanvas.toDataURL();
                            var ctx2 = mipintado.getContext(""2d"");
                            ctx2.drawImage(nuevaimg, 0, 0, 150, 150);

                            var otraimg = document.getElementById(""otraimg"");
                            otraimg.src = result;//reader.result;
                            //var id2 = new ImageData(150, 150);//{};//ctx2.getImageData(0, 0, 150, 150);
                            
                        },
                        error: function (request, status, error) {
                            alert(""Error: Could not delete"" + error);
                        }
                    });

                    //$.ajax({
                    //    url: ""GuardarImagen.ashx"",
                    //    type: ""POST"",
                    //    data: JSON.s");
                WriteLiteral(@"tringify(this.RegistroImagen.data),//JSON.stringify(RegistroImagen),
                    //    dataType: ""json"",
                    //    contentType: ""application/json"",
                    //    success: function (result) {
                    //        //var json = JSON.stringify(result)
                    //        //alert(json);
                            
                    //        var mipintado = document.getElementById(""mipintado"");
                    //        var nuevaimg = new Image();
                    //        nuevaimg.src = result;//json.data;//reader.result;//micanvas.toDataURL();
                    //        var ctx2 = mipintado.getContext(""2d"");
                    //        ctx2.drawImage(nuevaimg, 0, 0, 150, 150);

                    //        var otraimg = document.getElementById(""otraimg"");
                    //        otraimg.src = result;//reader.result;
                    //        //var id2 = new ImageData(150, 150);//{};//ctx2.getImageData(0, 0, 150, 150)");
                WriteLiteral(@";
                            
                    //    },
                    //    error: function (request, status, error) {
                    //        alert(""Error: Could not delete"" + error);
                    //    }
                    //});

            };
            
            $scope.obtenerGet = function ()
            {
                //alert('Funciona');
                var nombre = document.getElementById('nombre1').value;
                var apellido = document.getElementById('apellido1').value;
                $http({
                    method: ""GET"",
                    url: '/demo/create2/' + nombre + '&' + apellido
                    //url: '/demo/demo1'
                }).then(function correcto(respuesta) {
                    //$scope.gatos = respuesta.data;
                    var resultlibro3 = document.getElementById('resultlibro3');
                    resultlibro3.innerHTML = respuesta.data;
                },
                    function error(resp");
                WriteLiteral(@"uesta) {
                        alert(respuesta.statusText);
                    });
            };
        }]);

        function previewFile()
        {
            var preview = document.querySelector('img');
            var file = document.querySelector('input[type=file]').files[0];
            var reader = new FileReader();

            reader.onloadend = function () {
                preview.src = reader.result;
                var micanvas = document.getElementById(""micanvas"");
                var ctx = micanvas.getContext(""2d"");
                var miimagen = new Image();
                miimagen.src = reader.result;
                //console.log(reader.result);
                RegistroImagen.data = reader.result;
                miimagen.onload = function()
                {
                    /*
                     ImageData.data Read only
                    Is a Uint8ClampedArray representing a one-dimensional array containing the data in the RGBA order, with integer val");
                WriteLiteral(@"ues between 0 and 255 (inclusive).
                    ImageData.height Read only
                    Is an unsigned long representing the actual height, in pixels, of the ImageData.
                    ImageData.width Read only
                    Is an unsigned long representing the actual width, in pixels, of the ImageData.
                     */
                    //console.log(miimagen.decode());
                    ctx.drawImage(miimagen, 0, 0, 150, 150);
                    var ImageData = ctx.getImageData(0, 0, 150, 150);
                    //console.log(ImageData.data);
                    //console.log(micanvas.toDataURL());

                    //const img = new Image();
                    //img.src = 'nebula.jpg';
                    //img.decode();

                    
                    


                }

            }

            if (file) {
                reader.readAsDataURL(file);
            } else {
                preview.src = """";
            }
   ");
                WriteLiteral("         }\r\n\r\n\r\n\r\n        document.getElementById(\'filename\').addEventListener(\'change\', previewFile, false);\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12523, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
