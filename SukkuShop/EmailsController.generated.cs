// <auto-generated />
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
namespace T4MVC
{
    public class EmailsController
    {

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _ViewStart = "_ViewStart";
                public readonly string Activation = "Activation";
                public readonly string Activation_Html = "Activation.Html";
                public readonly string Activation_Text = "Activation.Text";
                public readonly string Order = "Order";
                public readonly string Order_Html = "Order.Html";
                public readonly string Order_Text = "Order.Text";
                public readonly string Reset = "Reset";
                public readonly string Reset_Html = "Reset.Html";
                public readonly string Reset_Text = "Reset.Text";
                public readonly string T4MVC = "T4MVC";
                public readonly string Web = "Web";
            }
            public readonly string _ViewStart = "~/Views/Emails/_ViewStart.cshtml";
            public readonly string Activation = "~/Views/Emails/Activation.cshtml";
            public readonly string Activation_Html = "~/Views/Emails/Activation.Html.cshtml";
            public readonly string Activation_Text = "~/Views/Emails/Activation.Text.cshtml";
            public readonly string Order = "~/Views/Emails/Order.cshtml";
            public readonly string Order_Html = "~/Views/Emails/Order.Html.cshtml";
            public readonly string Order_Text = "~/Views/Emails/Order.Text.cshtml";
            public readonly string Reset = "~/Views/Emails/Reset.cshtml";
            public readonly string Reset_Html = "~/Views/Emails/Reset.Html.cshtml";
            public readonly string Reset_Text = "~/Views/Emails/Reset.Text.cshtml";
            public readonly string T4MVC = "~/Views/Emails/T4MVC.tt";
            public readonly string Web = "~/Views/Emails/Web.config";
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009