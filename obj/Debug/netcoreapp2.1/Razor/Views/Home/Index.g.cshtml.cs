#pragma checksum "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02fb54b351767fd372ecae00efe8bb10622fc4b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fb54b351767fd372ecae00efe8bb10622fc4b3", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ex.Estacionamento.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
            BeginContext(82, 288, true);
            WriteLiteral(@"<h1>Estacionamento TSUKAR</h1>
<form action=""Home/RegistrarEntrada"" method=""POST"">
    <label for=""name"">Nome</label>
    <input type=""text"" name=""nome"">

    <label for=""marca"">Marca</label>
    <select name=""marca"">
        <option value="""" disabled selected>Selecione</option>
");
            EndContext();
#line 13 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
         foreach(var item in Model.Marcas){

#line default
#line hidden
            BeginContext(415, 19, true);
            WriteLiteral("            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 434, "\"", 452, 1);
#line 14 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
WriteAttributeValue("", 442, item.Nome, 442, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(453, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(455, 9, false);
#line 14 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
                                  Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(464, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 15 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(486, 156, true);
            WriteLiteral("    </select>\r\n        \r\n    <label for=\"modelo\">Modelo</label>\r\n    <select name=\"modelo\">\r\n        <option value=\"\" disabled selected>Selecione</option>\r\n");
            EndContext();
#line 21 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
         foreach (var item in Model.Modelos){

#line default
#line hidden
            BeginContext(689, 19, true);
            WriteLiteral("            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 708, "\"", 726, 1);
#line 22 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
WriteAttributeValue("", 716, item.Nome, 716, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(727, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(729, 9, false);
#line 22 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
                                  Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(738, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 23 "C:\Users\47218167829\Desktop\Ex.Estacionamento\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(760, 147, true);
            WriteLiteral("    </select>\r\n\r\n    <label for=\"placa\">Placa</label>\r\n    <input type=\"text\" name=\"placa\">\r\n\r\n    <input type=\"submit\" value=\"Registrar\">\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ex.Estacionamento.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
