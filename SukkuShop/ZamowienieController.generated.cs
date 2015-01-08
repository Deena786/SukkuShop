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
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Podsumowanie()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Podsumowanie);
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
            public readonly string ZalogujOrder = "ZalogujOrder";
            public readonly string Krok1 = "Krok1";
            public readonly string Krok2 = "Krok2";
            public readonly string ChangeAddressPartial = "ChangeAddressPartial";
            public readonly string ChangeAddressFirmaPartial = "ChangeAddressFirmaPartial";
            public readonly string NewAddressOrderPartial = "NewAddressOrderPartial";
            public readonly string NewAddressOrderFirmaPartial = "NewAddressOrderFirmaPartial";
            public readonly string Wyloguj = "Wyloguj";
            public readonly string Podsumowanie = "Podsumowanie";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string ZalogujOrder = "ZalogujOrder";
            public const string Krok1 = "Krok1";
            public const string Krok2 = "Krok2";
            public const string ChangeAddressPartial = "ChangeAddressPartial";
            public const string ChangeAddressFirmaPartial = "ChangeAddressFirmaPartial";
            public const string NewAddressOrderPartial = "NewAddressOrderPartial";
            public const string NewAddressOrderFirmaPartial = "NewAddressOrderFirmaPartial";
            public const string Wyloguj = "Wyloguj";
            public const string Podsumowanie = "Podsumowanie";
        }


        static readonly ActionParamsClass_ZalogujOrder s_params_ZalogujOrder = new ActionParamsClass_ZalogujOrder();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ZalogujOrder ZalogujOrderParams { get { return s_params_ZalogujOrder; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ZalogujOrder
        {
            public readonly string model = "model";
            public readonly string returnUrl = "returnUrl";
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
        static readonly ActionParamsClass_ChangeAddressPartial s_params_ChangeAddressPartial = new ActionParamsClass_ChangeAddressPartial();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ChangeAddressPartial ChangeAddressPartialParams { get { return s_params_ChangeAddressPartial; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ChangeAddressPartial
        {
            public readonly string model = "model";
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_ChangeAddressFirmaPartial s_params_ChangeAddressFirmaPartial = new ActionParamsClass_ChangeAddressFirmaPartial();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ChangeAddressFirmaPartial ChangeAddressFirmaPartialParams { get { return s_params_ChangeAddressFirmaPartial; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ChangeAddressFirmaPartial
        {
            public readonly string model = "model";
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_NewAddressOrderPartial s_params_NewAddressOrderPartial = new ActionParamsClass_NewAddressOrderPartial();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_NewAddressOrderPartial NewAddressOrderPartialParams { get { return s_params_NewAddressOrderPartial; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_NewAddressOrderPartial
        {
            public readonly string model = "model";
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_NewAddressOrderFirmaPartial s_params_NewAddressOrderFirmaPartial = new ActionParamsClass_NewAddressOrderFirmaPartial();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_NewAddressOrderFirmaPartial NewAddressOrderFirmaPartialParams { get { return s_params_NewAddressOrderFirmaPartial; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_NewAddressOrderFirmaPartial
        {
            public readonly string model = "model";
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_Podsumowanie s_params_Podsumowanie = new ActionParamsClass_Podsumowanie();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Podsumowanie PodsumowanieParams { get { return s_params_Podsumowanie; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Podsumowanie
        {
            public readonly string shoppingCart = "shoppingCart";
            public readonly string userhints = "userhints";
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
                public readonly string _ChangeAddressFirmaPartial = "_ChangeAddressFirmaPartial";
                public readonly string _ChangeAddressPartial = "_ChangeAddressPartial";
                public readonly string _LoginOrderPartial = "_LoginOrderPartial";
                public readonly string _NewAddressOrderFirmaPartial = "_NewAddressOrderFirmaPartial";
                public readonly string _NewAddressOrderPartial = "_NewAddressOrderPartial";
                public readonly string Krok1 = "Krok1";
                public readonly string Krok2 = "Krok2";
                public readonly string OrderSubmitted = "OrderSubmitted";
                public readonly string Podsumowanie = "Podsumowanie";
            }
            public readonly string _ChangeAddressFirmaPartial = "~/Views/Zamowienie/_ChangeAddressFirmaPartial.cshtml";
            public readonly string _ChangeAddressPartial = "~/Views/Zamowienie/_ChangeAddressPartial.cshtml";
            public readonly string _LoginOrderPartial = "~/Views/Zamowienie/_LoginOrderPartial.cshtml";
            public readonly string _NewAddressOrderFirmaPartial = "~/Views/Zamowienie/_NewAddressOrderFirmaPartial.cshtml";
            public readonly string _NewAddressOrderPartial = "~/Views/Zamowienie/_NewAddressOrderPartial.cshtml";
            public readonly string Krok1 = "~/Views/Zamowienie/Krok1.cshtml";
            public readonly string Krok2 = "~/Views/Zamowienie/Krok2.cshtml";
            public readonly string OrderSubmitted = "~/Views/Zamowienie/OrderSubmitted.cshtml";
            public readonly string Podsumowanie = "~/Views/Zamowienie/Podsumowanie.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ZamowienieController : SukkuShop.Controllers.ZamowienieController
    {
        public T4MVC_ZamowienieController() : base(Dummy.Instance) { }

        [NonAction]
        partial void ZalogujOrderOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ZalogujOrder()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ZalogujOrder);
            ZalogujOrderOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ZalogujOrderOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.LoginViewModel model, string returnUrl);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ZalogujOrder(SukkuShop.Models.LoginViewModel model, string returnUrl)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ZalogujOrder);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ZalogujOrderOverride(callInfo, model, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

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
        partial void ChangeAddressPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ChangeAddressPartial()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangeAddressPartial);
            ChangeAddressPartialOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ChangeAddressPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.UserAddressModel model, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.ActionResult ChangeAddressPartial(SukkuShop.Models.UserAddressModel model, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangeAddressPartial);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            ChangeAddressPartialOverride(callInfo, model, shoppingCart);
            return callInfo;
        }

        [NonAction]
        partial void ChangeAddressFirmaPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ChangeAddressFirmaPartial()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangeAddressFirmaPartial);
            ChangeAddressFirmaPartialOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ChangeAddressFirmaPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.FirmaAddressModel model, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.ActionResult ChangeAddressFirmaPartial(SukkuShop.Models.FirmaAddressModel model, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangeAddressFirmaPartial);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            ChangeAddressFirmaPartialOverride(callInfo, model, shoppingCart);
            return callInfo;
        }

        [NonAction]
        partial void NewAddressOrderPartialOverride(T4MVC_System_Web_Mvc_PartialViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.PartialViewResult NewAddressOrderPartial()
        {
            var callInfo = new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames.NewAddressOrderPartial);
            NewAddressOrderPartialOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NewAddressOrderPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.NewOrderAddressModel model, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> NewAddressOrderPartial(SukkuShop.Models.NewOrderAddressModel model, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.NewAddressOrderPartial);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            NewAddressOrderPartialOverride(callInfo, model, shoppingCart);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void NewAddressOrderFirmaPartialOverride(T4MVC_System_Web_Mvc_PartialViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.PartialViewResult NewAddressOrderFirmaPartial()
        {
            var callInfo = new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames.NewAddressOrderFirmaPartial);
            NewAddressOrderFirmaPartialOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NewAddressOrderFirmaPartialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.NewOrderAddressFirmaModel model, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> NewAddressOrderFirmaPartial(SukkuShop.Models.NewOrderAddressFirmaModel model, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.NewAddressOrderFirmaPartial);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            NewAddressOrderFirmaPartialOverride(callInfo, model, shoppingCart);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void WylogujOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wyloguj()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wyloguj);
            WylogujOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PodsumowanieOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Podsumowanie(SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Podsumowanie);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            PodsumowanieOverride(callInfo, shoppingCart);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void PodsumowanieOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string userhints, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Podsumowanie(string userhints, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Podsumowanie);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userhints", userhints);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            PodsumowanieOverride(callInfo, userhints, shoppingCart);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
