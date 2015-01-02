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
namespace SukkuShop.Controllers
{
    public partial class ZamowienieController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ZamowienieController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Krok1()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Krok1);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Krok2()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Krok2);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ZamowienieController Actions { get { return MVC.Zamowienie; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Zamowienie";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Zamowienie";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Krok1 = "Krok1";
            public readonly string Krok2 = "Krok2";
            public readonly string Podsumowanie = "Podsumowanie";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Krok1 = "Krok1";
            public const string Krok2 = "Krok2";
            public const string Podsumowanie = "Podsumowanie";
        }


        static readonly ActionParamsClass_Krok1 s_params_Krok1 = new ActionParamsClass_Krok1();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Krok1 Krok1Params { get { return s_params_Krok1; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Krok1
        {
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_Krok2 s_params_Krok2 = new ActionParamsClass_Krok2();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Krok2 Krok2Params { get { return s_params_Krok2; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Krok2
        {
            public readonly string shoppingCart = "shoppingCart";
        }
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
                public readonly string Krok1 = "Krok1";
                public readonly string Krok2 = "Krok2";
                public readonly string Podsumowanie = "Podsumowanie";
            }
            public readonly string Krok1 = "~/Views/Zamowienie/Krok1.cshtml";
            public readonly string Krok2 = "~/Views/Zamowienie/Krok2.cshtml";
            public readonly string Podsumowanie = "~/Views/Zamowienie/Podsumowanie.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ZamowienieController : SukkuShop.Controllers.ZamowienieController
    {
        public T4MVC_ZamowienieController() : base(Dummy.Instance) { }

        [NonAction]
        partial void Krok1Override(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.ActionResult Krok1(SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Krok1);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            Krok1Override(callInfo, shoppingCart);
            return callInfo;
        }

        [NonAction]
        partial void Krok2Override(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Krok2(SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Krok2);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            Krok2Override(callInfo, shoppingCart);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void PodsumowanieOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Podsumowanie()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Podsumowanie);
            PodsumowanieOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
