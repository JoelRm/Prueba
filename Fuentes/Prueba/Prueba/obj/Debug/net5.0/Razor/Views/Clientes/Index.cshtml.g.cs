#pragma checksum "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2623d02c2b0bf00be3abb54299507e8624472b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\_ViewImports.cshtml"
using Prueba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\_ViewImports.cshtml"
using Prueba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2623d02c2b0bf00be3abb54299507e8624472b35", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51658264bb9676655f4de4bc0355ca28be8fdbaf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prueba.Models.Cliente>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Estados Unidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Puerto Rico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Otros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\Clientes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
<script src=""https://code.jquery.com/jquery-3.5.1.js""></script>
<script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>

<div class=""form-group"">
    <h3>
        <svg xmlns=""http://www.w3.org/2000/s");
            WriteLiteral(@"vg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-info-circle"" viewBox=""0 0 16 16"">
            <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
            <path d=""m8.93 6.588-2.29.287-.082.38.45.083c.294.07.352.176.288.469l-.738 3.468c-.194.897.105 1.319.808 1.319.545 0 1.178-.252 1.465-.598l.088-.416c-.2.176-.492.246-.686.246-.275 0-.375-.193-.304-.533L8.93 6.588zM9 4.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"" />
        </svg>
        A??adir Cliente
    </h3>
</div>

<div>
    <div class=""form-group"">
        <small id=""emailHelp"" class=""form-text text-muted"">Please, add a Company to continue.</small>
    </div>
    <div class=""form-group"">
        <button type=""button"" class=""btn btn-danger"" onclick=""AbrirModal();"" ");
            WriteLiteral(@">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-plus"" viewBox=""0 0 16 16"">
                <path d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z""></path>
            </svg>
            A??adir Cliente
        </button>
    </div>
    <div class=""form-group"">
         <table class=""table"">
    <thead class=""table"">
        <tr class=""thead-dark"">
            <th scope=""col"">
                ");
#nullable restore
#line 47 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Compania));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 53 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\Clientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th scope=\"col\">\r\n");
            WriteLiteral("            <th scope=\"col\"></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"idBodyClientes\">\r\n\r\n");
            WriteLiteral(@"        </tbody>
    </table>
    </div>
</div>

<div class=""modal fade bd-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"" id=""modalAg"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5>
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-info-circle"" viewBox=""0 0 16 16"">
                        <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                        <path d=""m8.93 6.588-2.29.287-.082.38.45.083c.294.07.352.176.288.469l-.738 3.468c-.194.897.105 1.319.808 1.319.545 0 1.178-.252 1.465-.598l.088-.416c-.2.176-.492.246-.686.246-.275 0-.375-.193-.304-.533L8.93 6.588zM9 4.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"" />
                    </svg>
                    A??adir Cliente
                </h5>
            </div>
            <div class=""modal-body"">
      ");
            WriteLiteral(@"          <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <label for=""inputEmail4"">Nombre:*</label>
                            <input type=""text"" class=""form-control"" id=""idNombre"">
                        </div>
                        <div class=""col-md-4"">
                            <label for=""inputEmail4"">Pais:*</label>
                            <select id=""idPais"" class=""form-control"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2623d02c2b0bf00be3abb54299507e8624472b359792", async() => {
                WriteLiteral("--Seleccione--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2623d02c2b0bf00be3abb54299507e8624472b3511302", async() => {
                WriteLiteral("Estados Unidos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2623d02c2b0bf00be3abb54299507e8624472b3512502", async() => {
                WriteLiteral("Puerto Rico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2623d02c2b0bf00be3abb54299507e8624472b3513699", async() => {
                WriteLiteral("Otros");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                            <small id=""emailHelp"" class=""form-text text-muted"">Please, add a Company to continue.</small>
                        </div>
                        <div class=""col-md-4"">
                            <label for=""inputEmail4"">Tipo de entidad :*</label>
                            <br/>
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio1"" value=""Individuo"" checked>
                                <label class=""form-check-label"" for=""inlineRadio1"">Individuo</label>
                            </div>
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""Compa??ia"">
                                <label class=""form-check-label"" for=""inlineRadio2"">Compa????a</");
            WriteLiteral(@"label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""agregarCliente();"">Save</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" id=""btnCerrarModal"">Cancel</button>
            </div>
        </div>
    </div>
</div>

<script>
$(document).ready(function () {
        ListarClientes();
    })

    function AbrirModal(){
        $('#modalAg').modal('show');
    }
    function ListarClientes() {
        $.ajax({
            type: ""POST"",
            url: ""/Clientes/ListarClientes"",
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {
                if (data != null) {
                    var html = """";
                    if (data.length != 0) {
                        for");
            WriteLiteral(@" (var i = 0; i < data.length; i++) {
                            html += ""<tr>"";
                            html += ""<td>"" + data[i].nombre + ""</td>"";
                            html += ""<td>"" + data[i].compania + ""</td>"";
                            html += ""<td>"" + data[i].tipo + ""</td>"";
                            html += ""<td><button class = 'btn btn-danger' onclick='eliminarRegistro("" + data[i].idCliente + "");'> Eliminar </button></td>"";
                            html += ""</tr>"";
                        }
                    } else {
                        html += ""<tr><td colspan='7'>No existen registros</td></tr>"";
                    }
                    document.getElementById(""idBodyClientes"").innerHTML = html;
                }
                else {
                    document.getElementById(""idBodyClientes"").innerHTML = ""<tr><td colspan='7'>No existen registros</td></tr>"";
                }
            },
            error: function (ex) {
                alert(ex.respon");
            WriteLiteral("seText);\r\n                //ocultarLoader();\r\n            }\r\n        });\r\n    }\r\n\r\n    function eliminarRegistro(idCliente) {\r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \"");
#nullable restore
#line 187 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\Clientes\Index.cshtml"
             Write(Url.Action("EliminarCliente"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            dataType: ""json"",
            data: {idCliente: idCliente},
            success: function (data) {
                ListarClientes();
                toastr.success(""Pruyeba"");
            },
            error: function (ex) {
                alert(ex.responseText);
            }
        });
    }

    function agregarCliente() {
        var NombreCliente = document.getElementById(""idNombre"").value;
        var PaisCliente = document.getElementById(""idPais"").value;

        if (NombreCliente.length == 0) {
            alert(""Se debe digitar un nombre"");
            return;
        }
        if (PaisCliente == """") {
            alert(""Se debe seleccionar un pa??s"");
            return;
        }

        var TipoCliente = $('input:radio[name=inlineRadioOptions]:checked').val()
        var Cliente = {
            Nombre: NombreCliente,
            Compania: PaisCliente,
            Tipo: TipoCliente
        }
        $.ajax({
            type: ""POST"",
            u");
            WriteLiteral("rl: \"");
#nullable restore
#line 221 "C:\Users\Joel Rm\source\repos\Prueba\Prueba\Views\Clientes\Index.cshtml"
             Write(Url.Action("AgregarCliente"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            dataType: ""json"",
            data: {objCliente: Cliente},
            success: function (data) {
                ListarClientes();
                limpiarControles();
                $('#modalAg').modal('hide')
            },
            error: function (ex) {
                alert(ex.responseText);
            }
        });
    }

    function limpiarControles() {
        document.getElementById(""idNombre"").value = """";
        document.getElementById(""idPais"").value = """";
    }

</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prueba.Models.Cliente>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
