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

namespace Piranha.Manager.Permission
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Permission/Edit.cshtml")]
    public class Edit : Piranha.Manager.Templates.PermissionEdit
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



            
            #line 4 "..\..\Permission\Edit.cshtml"
  
    Layout = "~/Manager/Shared/_Layout.cshtml" ;


            
            #line default
            #line hidden

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");



WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"inner\">\r\n        <ul>\r\n            <li><" +
"a class=\"save submit\">");


            
            #line 12 "..\..\Permission\Edit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 13 "..\..\Permission\Edit.cshtml"
             if (Model.Permission.Id != Guid.Empty && !Model.Permission.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a href=\"");


            
            #line 14 "..\..\Permission\Edit.cshtml"
                    Write(Href("~/manager/permission/edit/delete/" + Model.Permission.Id));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"delete\">");


            
            #line 14 "..\..\Permission\Edit.cshtml"
                                                                                                     Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 15 "..\..\Permission\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li><a href=\"");


            
            #line 16 "..\..\Permission\Edit.cshtml"
                    Write(Href("~/manager/permission"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"back\">");


            
            #line 16 "..\..\Permission\Edit.cshtml"
                                                                Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 17 "..\..\Permission\Edit.cshtml"
             if (Model.Permission.Id != Guid.Empty) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a href=\"");


            
            #line 18 "..\..\Permission\Edit.cshtml"
                    Write(Href("~/manager/permission/edit/" + Model.Permission.Id));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"refresh\">");


            
            #line 18 "..\..\Permission\Edit.cshtml"
                                                                                               Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 19 "..\..\Permission\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</div>\r\n");


});

WriteLiteral("\r\n<form method=\"post\">\r\n");


            
            #line 26 "..\..\Permission\Edit.cshtml"
Write(UI.FormAction("Save"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 27 "..\..\Permission\Edit.cshtml"
Write(Form.HiddenFor(m => m.Permission.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"grid_12\">\r\n    <div class=\"box\">\r\n        <div class=\"title\"><h2>");


            
            #line 30 "..\..\Permission\Edit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div class=\"inner\">\r\n            <ul class=\"form\">\r\n        " +
"        <li>\r\n                    ");


            
            #line 34 "..\..\Permission\Edit.cshtml"
               Write(Form.LabelFor(m => m.Permission.Name, Piranha.Resources.Settings.AccessName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"input\">\r\n");


            
            #line 36 "..\..\Permission\Edit.cshtml"
                         if (!Model.Permission.IsLocked) {
                            
            
            #line default
            #line hidden
            
            #line 37 "..\..\Permission\Edit.cshtml"
                       Write(Form.TextBoxFor(m => m.Permission.Name));

            
            #line default
            #line hidden
            
            #line 37 "..\..\Permission\Edit.cshtml"
                                                                    
                        } else {
                            
            
            #line default
            #line hidden
            
            #line 39 "..\..\Permission\Edit.cshtml"
                       Write(Form.TextBoxFor(m => m.Permission.Name, new { disabled = "disabled" }));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Permission\Edit.cshtml"
                                                                                                   
                            
            
            #line default
            #line hidden
            
            #line 40 "..\..\Permission\Edit.cshtml"
                       Write(Form.HiddenFor(m => m.Permission.Name));

            
            #line default
            #line hidden
            
            #line 40 "..\..\Permission\Edit.cshtml"
                                                                   
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                    ");


            
            #line 43 "..\..\Permission\Edit.cshtml"
               Write(Form.ValidationMessageFor(m => m.Permission.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");


            
            #line 46 "..\..\Permission\Edit.cshtml"
               Write(Form.LabelFor(m => m.Permission.GroupId, Piranha.Resources.Settings.AccessGroup));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"input\">\r\n                        ");


            
            #line 48 "..\..\Permission\Edit.cshtml"
                   Write(Form.DropDownListFor(m => m.Permission.GroupId, Model.Groups));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    ");


            
            #line 49 "..\..\Permission\Edit.cshtml"
               Write(Form.ValidationMessageFor(m => m.Permission.GroupId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");


            
            #line 52 "..\..\Permission\Edit.cshtml"
               Write(Form.LabelFor(m => m.Permission.Description, Piranha.Resources.Settings.AccessDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"input\">\r\n");


            
            #line 54 "..\..\Permission\Edit.cshtml"
                         if (!Model.Permission.IsLocked) {
                            
            
            #line default
            #line hidden
            
            #line 55 "..\..\Permission\Edit.cshtml"
                       Write(Form.TextAreaFor(m => m.Permission.Description, 
                                new { @rows = 3, @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
            
            #line 56 "..\..\Permission\Edit.cshtml"
                                                                                                    
                        } else {
                            
            
            #line default
            #line hidden
            
            #line 58 "..\..\Permission\Edit.cshtml"
                       Write(Form.TextAreaFor(m => m.Permission.Description, 
                                new { @rows = 3, @disabled = "disabled", @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
            
            #line 59 "..\..\Permission\Edit.cshtml"
                                                                                                                            
                            
            
            #line default
            #line hidden
            
            #line 60 "..\..\Permission\Edit.cshtml"
                       Write(Form.HiddenFor(m => m.Permission.Description));

            
            #line default
            #line hidden
            
            #line 60 "..\..\Permission\Edit.cshtml"
                                                                          
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </li>\r\n            </ul>\r\n        </d" +
"iv>\r\n    </div>\r\n</div>\r\n</form>");


        }
    }
}
#pragma warning restore 1591
