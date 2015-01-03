﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly AdminClass s_Admin = new AdminClass();
    public static AdminClass Admin { get { return s_Admin; } }
    public static SukkuShop.Controllers.ErrorController Error = new SukkuShop.Controllers.T4MVC_ErrorController();
    public static SukkuShop.Controllers.HomeController Home = new SukkuShop.Controllers.T4MVC_HomeController();
    public static SukkuShop.Controllers.KontoController Konto = new SukkuShop.Controllers.T4MVC_KontoController();
    public static SukkuShop.Controllers.KoszykController Koszyk = new SukkuShop.Controllers.T4MVC_KoszykController();
    public static SukkuShop.Controllers.NavController Nav = new SukkuShop.Controllers.T4MVC_NavController();
    public static SukkuShop.Controllers.SklepController Sklep = new SukkuShop.Controllers.T4MVC_SklepController();
    public static SukkuShop.Controllers.ZamowienieController Zamowienie = new SukkuShop.Controllers.T4MVC_ZamowienieController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class AdminClass
    {
        public readonly string Name = "Admin";
        public SukkuShop.Areas.Admin.Controllers.AdminHomeController AdminHome = new SukkuShop.Areas.Admin.Controllers.T4MVC_AdminHomeController();
        public SukkuShop.Areas.Admin.Controllers.AdminProductController AdminProduct = new SukkuShop.Areas.Admin.Controllers.T4MVC_AdminProductController();
        public SukkuShop.Areas.Admin.Controllers.AdminRoleController AdminRole = new SukkuShop.Areas.Admin.Controllers.T4MVC_AdminRoleController();
        public SukkuShop.Areas.Admin.Controllers.AdminUserController AdminUser = new SukkuShop.Areas.Admin.Controllers.T4MVC_AdminUserController();
        public T4MVC.Admin.SharedController Shared = new T4MVC.Admin.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ViewResult : System.Web.Mvc.ViewResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ViewResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_PartialViewResult : System.Web.Mvc.PartialViewResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_PartialViewResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string angular_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular.min.js") ? Url("angular.min.js") : Url("angular.js");
        public static readonly string angular_min_js = Url("angular.min.js");
        public static readonly string CartSummary_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartSummary.min.js") ? Url("CartSummary.min.js") : Url("CartSummary.js");
        public static readonly string jquery_2_1_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.intellisense.min.js") ? Url("jquery-2.1.1.intellisense.min.js") : Url("jquery-2.1.1.intellisense.js");
        public static readonly string jquery_2_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.min.js") ? Url("jquery-2.1.1.min.js") : Url("jquery-2.1.1.js");
        public static readonly string jquery_2_1_1_min_js = Url("jquery-2.1.1.min.js");
        public static readonly string jquery_2_1_1_min_map = Url("jquery-2.1.1.min.map");
        public static readonly string jquery_elevatezoom_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.elevatezoom.min.js") ? Url("jquery.elevatezoom.min.js") : Url("jquery.elevatezoom.js");
        public static readonly string jquery_unobtrusive_ajax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.unobtrusive-ajax.min.js") ? Url("jquery.unobtrusive-ajax.min.js") : Url("jquery.unobtrusive-ajax.js");
        public static readonly string jquery_unobtrusive_ajax_min_js = Url("jquery.unobtrusive-ajax.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string main_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/main.min.js") ? Url("main.min.js") : Url("main.js");
        public static readonly string modernizr_2_8_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.8.3.min.js") ? Url("modernizr-2.8.3.min.js") : Url("modernizr-2.8.3.js");
        public static readonly string OrderScripts_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/OrderScripts.min.js") ? Url("OrderScripts.min.js") : Url("OrderScripts.js");
        public static readonly string podsumowanie_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/podsumowanie.min.js") ? Url("podsumowanie.min.js") : Url("podsumowanie.js");
        public static readonly string shopAngular_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/shopAngular.min.js") ? Url("shopAngular.min.js") : Url("shopAngular.js");
        public static readonly string shopdetails_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/shopdetails.min.js") ? Url("shopdetails.min.js") : Url("shopdetails.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class css {
            private const string URLPATH = "~/Content/css";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Cart_scss = Url("Cart.scss");
            public static readonly string Cart_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Cart.min.css") ? Url("Cart.min.css") : Url("Cart.css");
                 
            public static readonly string Cart_css_map = Url("Cart.css.map");
            public static readonly string Cart_min_css = Url("Cart.min.css");
            public static readonly string ClientData_scss = Url("ClientData.scss");
            public static readonly string ClientData_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ClientData.min.css") ? Url("ClientData.min.css") : Url("ClientData.css");
                 
            public static readonly string ClientData_css_map = Url("ClientData.css.map");
            public static readonly string ClientData_min_css = Url("ClientData.min.css");
            public static readonly string Error_scss = Url("Error.scss");
            public static readonly string Error_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Error.min.css") ? Url("Error.min.css") : Url("Error.css");
                 
            public static readonly string Error_css_map = Url("Error.css.map");
            public static readonly string Error_min_css = Url("Error.min.css");
            public static readonly string Home_scss = Url("Home.scss");
            public static readonly string Home_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Home.min.css") ? Url("Home.min.css") : Url("Home.css");
                 
            public static readonly string Home_css_map = Url("Home.css.map");
            public static readonly string Home_min_css = Url("Home.min.css");
            public static readonly string main_scss = Url("main.scss");
            public static readonly string main_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/main.min.css") ? Url("main.min.css") : Url("main.css");
                 
            public static readonly string main_css_map = Url("main.css.map");
            public static readonly string main_min_css = Url("main.min.css");
            public static readonly string Order_scss = Url("Order.scss");
            public static readonly string Order_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Order.min.css") ? Url("Order.min.css") : Url("Order.css");
                 
            public static readonly string Order_css_map = Url("Order.css.map");
            public static readonly string Order_min_css = Url("Order.min.css");
            public static readonly string reset_scss = Url("reset.scss");
            public static readonly string reset_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/reset.min.css") ? Url("reset.min.css") : Url("reset.css");
                 
            public static readonly string reset_css_map = Url("reset.css.map");
            public static readonly string reset_min_css = Url("reset.min.css");
            public static readonly string Shop_scss = Url("Shop.scss");
            public static readonly string Shop_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Shop.min.css") ? Url("Shop.min.css") : Url("Shop.css");
                 
            public static readonly string Shop_css_map = Url("Shop.css.map");
            public static readonly string Shop_min_css = Url("Shop.min.css");
            public static readonly string Summary_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Summary.min.css") ? Url("Summary.min.css") : Url("Summary.css");
                 
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class fonts {
            private const string URLPATH = "~/Content/fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string FoglihtenPCS_otf = Url("FoglihtenPCS.otf");
            public static readonly string FTLTLT_TTF = Url("FTLTLT.TTF");
            public static readonly string lucida_bright_eot = Url("lucida_bright.eot");
            public static readonly string lucida_bright_svg = Url("lucida_bright.svg");
            public static readonly string lucida_bright_ttf = Url("lucida_bright.ttf");
            public static readonly string lucida_bright_woff = Url("lucida_bright.woff");
            public static readonly string lucida_console_eot = Url("lucida_console.eot");
            public static readonly string lucida_console_svg = Url("lucida_console.svg");
            public static readonly string lucida_console_ttf = Url("lucida_console.ttf");
            public static readonly string lucida_console_woff = Url("lucida_console.woff");
            public static readonly string SegoeSemibold_ttf = Url("SegoeSemibold.ttf");
            public static readonly string SegoeSemiboldIE_eot = Url("SegoeSemiboldIE.eot");
            public static readonly string segoeui_ttf = Url("segoeui.ttf");
            public static readonly string segoeuibold_ttf = Url("segoeuibold.ttf");
            public static readonly string segoeuil_ttf = Url("segoeuil.ttf");
            public static readonly string segoeuisl_ttf = Url("segoeuisl.ttf");
            public static readonly string seguiblack_ttf = Url("seguiblack.ttf");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Images {
            private const string URLPATH = "~/Content/Images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string checkbox_png = Url("checkbox.png");
            public static readonly string content_pic1_png = Url("content-pic1.png");
            public static readonly string content_pic2_png = Url("content-pic2.png");
            public static readonly string content_pic3_png = Url("content-pic3.png");
            public static readonly string footer_cart_png = Url("footer-cart.png");
            public static readonly string footer_sukku_png = Url("footer-sukku.png");
            public static readonly string footer_user_png = Url("footer-user.png");
            public static readonly string logo_header_png = Url("logo-header.png");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Shop {
                private const string URLPATH = "~/Content/Images/Shop";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string _1_jpg = Url("1.jpg");
                public static readonly string _1_png = Url("1.png");
                public static readonly string _2_jpg = Url("2.jpg");
                public static readonly string _2_png = Url("2.png");
                public static readonly string _4_jpg = Url("4.jpg");
                public static readonly string _4_png = Url("4.png");
                public static readonly string basket_png = Url("basket.png");
                public static readonly string carticon_png = Url("carticon.png");
                public static readonly string carticonwhite_png = Url("carticonwhite.png");
                public static readonly string info_icon_png = Url("info_icon.png");
                public static readonly string kosmetyki_jpg = Url("kosmetyki.jpg");
                public static readonly string lupa_png = Url("lupa.png");
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class web {
            private const string URLPATH = "~/Content/web";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string DaneKlientaKoszyk_html = Url("DaneKlientaKoszyk.html");
            public static readonly string OrderDetails_html = Url("OrderDetails.html");
            public static readonly string OrderSummary_html = Url("OrderSummary.html");
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009


