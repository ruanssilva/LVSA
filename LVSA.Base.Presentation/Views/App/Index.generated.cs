﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using LVSA.Base.Presentation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/App/Index.cshtml")]
    public partial class _Views_App_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_App_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\App\Index.cshtml"
  
    string serverCDN = System.Web.Configuration.WebConfigurationManager.AppSettings["Address_LVSA.CDN.Presentation"];

    ViewBag.Title = "Aplicações disponíveis";
    Layout = "~/Views/Shared/_Layout2.cshtml";

    LVSA.Security.Application.Models.Seguranca Seguranca = ((LVSA.Security.Application.Models.Seguranca)TempData["Seguranca"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<br /><br />\r\n\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\Views\App\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\App\Index.cshtml"
     foreach (var a in ((IEnumerable<LVSA.Security.Application.ViewModels.AplicacaoViewModel>)ViewBag.AplicacaoSet).Where(w => w.Ativo && !w.Abstrata && !w.Desktop))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-lg-2 col-md-3 col-sm-6 text-center action-buttons\"");

WriteLiteral(" style=\"margin-bottom:20px;\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..\Views\App\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\App\Index.cshtml"
             using (Html.BeginForm("Index", "App", new { id = a.Id }, FormMethod.Post))
            {
                if (a.Blank)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 873), Tuple.Create("\"", 887)
            
            #line 25 "..\..\Views\App\Index.cshtml"
, Tuple.Create(Tuple.Create("", 880), Tuple.Create<System.Object, System.Int32>(a.Link
            
            #line default
            #line hidden
, 880), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"btn btn-link \"");

WriteAttribute("title", Tuple.Create(" title=\"", 926), Tuple.Create("\"", 946)
            
            #line 25 "..\..\Views\App\Index.cshtml"
    , Tuple.Create(Tuple.Create("", 934), Tuple.Create<System.Object, System.Int32>(a.Descricao
            
            #line default
            #line hidden
, 934), false)
);

WriteLiteral(" style=\"text-decoration:none;\"");

WriteLiteral(">\r\n                        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 1006), Tuple.Create("\"", 1030)
, Tuple.Create(Tuple.Create("", 1014), Tuple.Create("ace-icon", 1014), true)
            
            #line 26 "..\..\Views\App\Index.cshtml"
, Tuple.Create(Tuple.Create(" ", 1022), Tuple.Create<System.Object, System.Int32>(a.Icon
            
            #line default
            #line hidden
, 1023), false)
);

WriteLiteral(" style=\"font-size:115px;color:#fff;\"");

WriteLiteral("></i>\r\n                        <h1");

WriteLiteral(" style=\"margin-top:0px;font-size:15px;color:#fff;\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\App\Index.cshtml"
                                                                         Write(a.Exibicao);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                    </a>\r\n");

            
            #line 29 "..\..\Views\App\Index.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"submit btn btn-link\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1325), Tuple.Create("\"", 1345)
            
            #line 32 "..\..\Views\App\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1333), Tuple.Create<System.Object, System.Int32>(a.Descricao
            
            #line default
            #line hidden
, 1333), false)
);

WriteLiteral(" style=\"text-decoration:none;width:200px; height:200px;\"");

WriteLiteral(">\r\n                        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 1431), Tuple.Create("\"", 1455)
, Tuple.Create(Tuple.Create("", 1439), Tuple.Create("ace-icon", 1439), true)
            
            #line 33 "..\..\Views\App\Index.cshtml"
, Tuple.Create(Tuple.Create(" ", 1447), Tuple.Create<System.Object, System.Int32>(a.Icon
            
            #line default
            #line hidden
, 1448), false)
);

WriteLiteral(" style=\"font-size:115px;color:#fff;\"");

WriteLiteral("></i>\r\n                        <h1");

WriteLiteral(" style=\"margin-top:0px;font-size:15px;color:#fff;\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\App\Index.cshtml"
                                                                         Write(a.Exibicao);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                    </button>\r\n");

            
            #line 36 "..\..\Views\App\Index.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 39 "..\..\Views\App\Index.cshtml"
        
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

DefineSection("footer", () => {

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"footer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"footer-inner\"");

WriteLiteral(">\r\n            <!-- #section:basics/footer -->\r\n            <div");

WriteLiteral(" class=\"footer-content\"");

WriteLiteral(" style=\"border:none!important; color:#000!important;\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"smaller-90\"");

WriteLiteral(">\r\n                    © ");

            
            #line 49 "..\..\Views\App\Index.cshtml"
                 Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" - Housing ");

WriteLiteral("@ Leonelleo\r\n                </span>\r\n            </div>\r\n\r\n            <!-- /sec" +
"tion:basics/footer -->\r\n        </div>\r\n    </div>\r\n");

});

WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"navbar-fixed-top align-right\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n        <br />\r\n        &nbsp;\r\n        <span");

WriteLiteral(" style=\"color:#fff;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2297), Tuple.Create("\"", 2327)
            
            #line 63 "..\..\Views\App\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2305), Tuple.Create<System.Object, System.Int32>(Seguranca.Filial.Nome
            
            #line default
            #line hidden
, 2305), false)
);

WriteLiteral("> Filial: ");

            
            #line 63 "..\..\Views\App\Index.cshtml"
                                                                     Write(Seguranca.Filial.Id);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        &nbsp;\r\n        <span");

WriteLiteral(" class=\"white\"");

WriteLiteral("></span>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">\r\n        <br />\r\n");

            
            #line 70 "..\..\Views\App\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\App\Index.cshtml"
         if (Seguranca.FilialSet.Count() > 1)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" style=\"color:#fff;\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2572), Tuple.Create("\"", 2610)
            
            #line 72 "..\..\Views\App\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2579), Tuple.Create<System.Object, System.Int32>(Url.Action("Index","Contexto")
            
            #line default
            #line hidden
, 2579), false)
);

WriteLiteral(">alterar contexto</a>\r\n");

            
            #line 73 "..\..\Views\App\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        &nbsp;\r\n        &nbsp;\r\n\r\n        <a");

WriteLiteral(" style=\"color:#fff;\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2709), Tuple.Create("\"", 2745)
            
            #line 77 "..\..\Views\App\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2716), Tuple.Create<System.Object, System.Int32>(Url.Action("Logout","Login")
            
            #line default
            #line hidden
, 2716), false)
);

WriteLiteral(">sair</a>\r\n        &nbsp;\r\n        &nbsp;\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            $(\'a.submit\').click(function" +
" () {\r\n\r\n                alert(\'teste\');\r\n\r\n                $(this).parents(\'for" +
"m\').submit();\r\n            });\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591