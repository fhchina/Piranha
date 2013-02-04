﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Manager.Param
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Param/Edit.cshtml")]
    public class Edit : Piranha.Manager.Templates.ParamEdit
    {

                // Resolve package relative syntax
                // Also, if it comes from a static embedded resource, change the path accordingly
                public override string Href(string virtualPath, params object[] pathParts) {
                    virtualPath = ApplicationPart.ProcessVirtualPath(GetType().Assembly, VirtualPath, virtualPath);
                    return base.Href(virtualPath, pathParts);
                }
        public Edit()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n\r\n");



            
            #line 4 "..\..\Param\Edit.cshtml"
  
    Layout = "~/Manager/Shared/_Layout.cshtml" ;


            
            #line default
            #line hidden

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");



WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"inner\">\r\n        <ul>\r\n            <li><" +
"a class=\"save submit\">");


            
            #line 12 "..\..\Param\Edit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 13 "..\..\Param\Edit.cshtml"
             if (Model.Param.Id != Guid.Empty && !Model.Param.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a href=\"");


            
            #line 14 "..\..\Param\Edit.cshtml"
                    Write(Href("~/manager/param/edit/delete/" + Model.Param.Id));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"delete\">");


            
            #line 14 "..\..\Param\Edit.cshtml"
                                                                                           Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 15 "..\..\Param\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li><a href=\"");


            
            #line 16 "..\..\Param\Edit.cshtml"
                    Write(Href("~/manager/param"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"back\">");


            
            #line 16 "..\..\Param\Edit.cshtml"
                                                           Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 17 "..\..\Param\Edit.cshtml"
             if (Model.Param.Id != Guid.Empty) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a href=\"");


            
            #line 18 "..\..\Param\Edit.cshtml"
                    Write(Href("~/manager/param/edit/" + Model.Param.Id));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"refresh\">");


            
            #line 18 "..\..\Param\Edit.cshtml"
                                                                                     Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 19 "..\..\Param\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</div>\r\n");


});

WriteLiteral("\r\n<form method=\"post\">\r\n");


            
            #line 26 "..\..\Param\Edit.cshtml"
Write(Form.HiddenFor(m => m.Param.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"grid_12\">\r\n    <div class=\"box\">\r\n        <div class=\"title\"><h2>");


            
            #line 29 "..\..\Param\Edit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div class=\"inner\">\r\n            <ul class=\"form\">\r\n        " +
"        <li>\r\n                    ");


            
            #line 33 "..\..\Param\Edit.cshtml"
               Write(Form.LabelFor(m => m.Param.Name, Piranha.Resources.Settings.ParamName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"input\">\r\n");


            
            #line 35 "..\..\Param\Edit.cshtml"
                         if (!Model.Param.IsLocked) {
                            
            
            #line default
            #line hidden
            
            #line 36 "..\..\Param\Edit.cshtml"
                       Write(Form.TextBoxFor(m => m.Param.Name));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Param\Edit.cshtml"
                                                               
                        } else {
                            
            
            #line default
            #line hidden
            
            #line 38 "..\..\Param\Edit.cshtml"
                       Write(Form.TextBoxFor(m => m.Param.Name, new { @disabled = "disabled" }));

            
            #line default
            #line hidden
            
            #line 38 "..\..\Param\Edit.cshtml"
                                                                                               
                            
            
            #line default
            #line hidden
            
            #line 39 "..\..\Param\Edit.cshtml"
                       Write(Form.HiddenFor(m => m.Param.Name));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Param\Edit.cshtml"
                                                              
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                    ");


            
            #line 42 "..\..\Param\Edit.cshtml"
               Write(Form.ValidationMessageFor(m => m.Param.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");


            
            #line 45 "..\..\Param\Edit.cshtml"
               Write(Form.LabelFor(m => m.Param.Value, Piranha.Resources.Settings.ParamValue));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"input\">\r\n");


            
            #line 47 "..\..\Param\Edit.cshtml"
                         if (Model.Param.Name != "SITE_VERSION") {
                            
            
            #line default
            #line hidden
            
            #line 48 "..\..\Param\Edit.cshtml"
                       Write(Form.TextBoxFor(m => m.Param.Value));

            
            #line default
            #line hidden
            
            #line 48 "..\..\Param\Edit.cshtml"
                                                                
                        } else {
                            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Param\Edit.cshtml"
                       Write(Form.TextBoxFor(m => m.Param.Value, new { @disabled = "disabled" }));

            
            #line default
            #line hidden
            
            #line 50 "..\..\Param\Edit.cshtml"
                                                                                                
                            
            
            #line default
            #line hidden
            
            #line 51 "..\..\Param\Edit.cshtml"
                       Write(Form.HiddenFor(m => m.Param.Value));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Param\Edit.cshtml"
                                                               
                        } 

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </li>\r\n                <li>\r\n        " +
"            ");


            
            #line 56 "..\..\Param\Edit.cshtml"
               Write(Form.LabelFor(m => m.Param.Description, Piranha.Resources.Settings.ParamDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"input\">\r\n");


            
            #line 58 "..\..\Param\Edit.cshtml"
                         if (!Model.Param.IsLocked) {
                            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Param\Edit.cshtml"
                       Write(Form.TextAreaFor(m => m.Param.Description, 
                                new { @rows = 3, @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
            
            #line 60 "..\..\Param\Edit.cshtml"
                                                                                                    
                        } else {
                            
            
            #line default
            #line hidden
            
            #line 62 "..\..\Param\Edit.cshtml"
                       Write(Form.TextAreaFor(m => m.Param.Description, 
                                new { @rows = 3, @disabled = "disabled", @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
            
            #line 63 "..\..\Param\Edit.cshtml"
                                                                                                                            
                            
            
            #line default
            #line hidden
            
            #line 64 "..\..\Param\Edit.cshtml"
                       Write(Form.HiddenFor(m => m.Param.Description));

            
            #line default
            #line hidden
            
            #line 64 "..\..\Param\Edit.cshtml"
                                                                     
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </li>\r\n            </ul>\r\n        </d" +
"iv>\r\n    </div>\r\n</div>\r\n</form>\r\n");


        }
    }
}
#pragma warning restore 1591
