﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using NewLife;
    
    #line 1 "..\..\Views\Shared\_Ace_Layout.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Ace_Layout.cshtml")]
    public partial class _Views_Shared__Ace_Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Ace_Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Ace_Layout.cshtml"
  
    var menu = ManageProvider.Menu.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(" />\r\n    <!-- 上述3个meta标签*必须*放在最前面，任何其他内容都*必须*跟随其后！ -->\r\n\r\n    <title>");

            
            #line 13 "..\..\Views\Shared\_Ace_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 13 "..\..\Views\Shared\_Ace_Layout.cshtml"
                       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 417), Tuple.Create("\"", 437)
, Tuple.Create(Tuple.Create("", 424), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 424), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(" />\r\n\r\n    <!-- 页面内联样式 -->\r\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("css", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 578), Tuple.Create("\"", 628)
, Tuple.Create(Tuple.Create("", 585), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/bootstrap-multiselect.css")
, 585), false)
);

WriteLiteral(" />\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 688), Tuple.Create("\"", 730)
, Tuple.Create(Tuple.Create("", 695), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-part2.min.css")
, 695), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" />\r\n    <![endif]-->\r\n    <!--[if lte IE 9]>\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 836), Tuple.Create("\"", 875)
, Tuple.Create(Tuple.Create("", 843), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-ie.min.css")
, 843), false)
);

WriteLiteral(" />\r\n    <![endif]-->\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 927), Tuple.Create("\"", 991)
, Tuple.Create(Tuple.Create("", 934), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.css")
, 934), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n\r\n    ");

WriteLiteral("\r\n\r\n    <!-- 最后引入基本样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1171), Tuple.Create("\"", 1219)
, Tuple.Create(Tuple.Create("", 1178), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 1178), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1251), Tuple.Create("\"", 1302)
, Tuple.Create(Tuple.Create("", 1258), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/font-awesome.min.css")
, 1258), false)
);

WriteLiteral(" />\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1336), Tuple.Create("\"", 1390)
, Tuple.Create(Tuple.Create("", 1343), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-theme.min.css")
, 1343), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1438), Tuple.Create("\"", 1497)
, Tuple.Create(Tuple.Create("", 1445), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-responsive.min.css")
, 1445), false)
);

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n\r\n    <!-- 文本字体 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1566), Tuple.Create("\"", 1608)
, Tuple.Create(Tuple.Create("", 1573), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-fonts.min.css")
, 1573), false)
);

WriteLiteral(" />\r\n    <!-- ace 样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1661), Tuple.Create("\"", 1697)
, Tuple.Create(Tuple.Create("", 1668), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace.min.css")
, 1668), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" id=\"main-ace-style\"");

WriteLiteral(" />\r\n    <!-- JQuery作为一等公民，页面内部随时可能使用 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1800), Tuple.Create("\"", 1838)
, Tuple.Create(Tuple.Create("", 1806), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 1806), false)
);

WriteLiteral("></script>\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"breadcrumbs\"");

WriteLiteral(" id=\"breadcrumbs\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(Html.Partial("_Layout_Nav"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </ul>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"page-content\"");

WriteLiteral(">\r\n            <section");

WriteLiteral(" class=\"content-wrapper main-content clear-fix\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 54 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(Html.Partial("_Layout_Header"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 55 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </section>\r\n        </div>\r\n");

            
            #line 58 "..\..\Views\Shared\_Ace_Layout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Shared\_Ace_Layout.cshtml"
         if (DbRunTimeModule.Enable)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 61 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(DbRunTimeModule.GetInfo());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 63 "..\..\Views\Shared\_Ace_Layout.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <!-- 最早引入基本脚本 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2513), Tuple.Create("\"", 2558)
, Tuple.Create(Tuple.Create("", 2519), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 2519), false)
);

WriteLiteral("></script>\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2727), Tuple.Create("\"", 2774)
, Tuple.Create(Tuple.Create("", 2733), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/bootstrap-multiselect.js")
, 2733), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- ace 设置 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2821), Tuple.Create("\"", 2854)
, Tuple.Create(Tuple.Create("", 2827), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace.min.js")
, 2827), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2878), Tuple.Create("\"", 2920)
, Tuple.Create(Tuple.Create("", 2884), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace-elements.min.js")
, 2884), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2944), Tuple.Create("\"", 2983)
, Tuple.Create(Tuple.Create("", 2950), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/js/ace-extra.min.js")
, 2950), false)
);

WriteLiteral("></script>\r\n\r\n    <!-- HTML5shiv and Respond.js for IE8 to support HTML5 elements" +
" and media queries -->\r\n    <!--[if lte IE 8]>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3124), Tuple.Create("\"", 3159)
, Tuple.Create(Tuple.Create("", 3130), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/html5shiv.min.js")
, 3130), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3183), Tuple.Create("\"", 3216)
, Tuple.Create(Tuple.Create("", 3189), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/respond.min.js")
, 3189), false)
);

WriteLiteral("></script>\r\n    <![endif]-->\r\n    ");

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 82 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!--日历控件支持-->\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3443), Tuple.Create("\"", 3505)
, Tuple.Create(Tuple.Create("", 3449), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.js")
, 3449), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3529), Tuple.Create("\"", 3601)
, Tuple.Create(Tuple.Create("", 3535), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/locales/bootstrap-datetimepicker.zh-CN.js")
, 3535), false)
);

WriteLiteral("></script>\r\n    <script>\r\n        //$(function () {\r\n        //    // 给所有type=dat" +
"e的input加上事件\r\n        //    var dt = $(\'input[type=date]\');\r\n        //    if (!d" +
"t.data(\'datd-date-format\')) {\r\n        //        dt.data(\'datd-date-format\', \'yy" +
"yy-MM-dd HH:mm:ss\');\r\n        //    }\r\n        //    if (!dt.data(\'click\')) {\r\n " +
"       //        dt.click(function () { WdatePicker({ skin: \'whyGreen\', dateFmt:" +
" dt.data(\'datd-date-format\') }); });\r\n        //    }\r\n        //});\r\n        $(" +
"function () {\r\n            $(\'input[type=date]\').each(function () {\r\n           " +
"     var df = $(this).attr(\'dateformat\');\r\n                if (!df) {\r\n         " +
"           $(this).attr(\'dateformat\', \'yyyy-mm-dd hh:ii:ss\');\r\n                }" +
"\r\n                else {\r\n                    // 把C#标准格式化替换为控件格式\r\n              " +
"      df = df.replace(\'mm\', \'ii\').replace(\'MM\', \'mm\').replace(\'HH\', \'hh\');\r\n    " +
"                $(this).attr(\'dateformat\', df);\r\n                }\r\n            " +
"});\r\n            $(\"[dateformat]\").each(function () {\r\n                $(this).d" +
"atetimepicker({\r\n                    format: $(this).attr(\"dateformat\"),\r\n      " +
"              autoclose: true,\r\n                    language: \"zh-CN\",\r\n        " +
"            forceParse: false,\r\n                    startView: 2,\r\n             " +
"       minView: 2,\r\n                })\r\n                //console.trace($(this))" +
";\r\n            })\r\n            $(\'input[role=number]\').each(function () {\r\n     " +
"           $(this).removeAttr(\'class\');\r\n                $(this).addClass(\'spinb" +
"ox-input form-control text-center\');\r\n                $(this).ace_spinner({ on_s" +
"ides: true, icon_up: \'ace-icon fa fa-plus bigger-110\', icon_down: \'ace-icon fa f" +
"a-minus bigger-110\', btn_up_class: \'btn-success\', btn_down_class: \'btn-danger\' }" +
");\r\n            });\r\n            $(\'.multiselect\').multiselect({\r\n              " +
"  enableFiltering: true,\r\n                buttonClass: \'btn btn-white btn-primar" +
"y\',\r\n                templates: {\r\n                    button: \'<button type=\"bu" +
"tton\" class=\"multiselect dropdown-toggle\" data-toggle=\"dropdown\"></button>\',\r\n  " +
"                  ul: \'<ul class=\"multiselect-container dropdown-menu\"></ul>\',\r\n" +
"                    filter: \'<li class=\"multiselect-item filter\"><div class=\"inp" +
"ut-group\"><span class=\"input-group-addon\"><i class=\"fa fa-search\"></i></span><in" +
"put class=\"form-control multiselect-search\" type=\"text\"></div></li>\',\r\n         " +
"           filterClearBtn: \'<span class=\"input-group-btn\"><button class=\"btn btn" +
"-default btn-white btn-grey multiselect-clear-filter\" type=\"button\"><i class=\"fa" +
" fa-times-circle red2\"></i></button></span>\',\r\n                    li: \'<li><a h" +
"ref=\"javascript:void(0);\"><label></label></a></li>\',\r\n                    divide" +
"r: \'<li class=\"multiselect-item divider\"></li>\',\r\n                    liGroup: \'" +
"<li class=\"multiselect-item group\"><label class=\"multiselect-group\"></label></li" +
">\'\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n\r\n    <!--开关" +
"插件-->\r\n    ");

WriteLiteral("\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 6806), Tuple.Create("\"", 6850)
, Tuple.Create(Tuple.Create("", 6812), Tuple.Create<System.Object, System.Int32>(Href("~/Content/fuelux/fuelux.spinner.min.js")
, 6812), false)
);

WriteLiteral("></script>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
