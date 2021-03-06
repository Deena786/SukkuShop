// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
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
    public partial class KoszykController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected KoszykController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult AddToCart()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddToCart);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RemoveFromCart()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemoveFromCart);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult IncreaseQuantity()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.IncreaseQuantity);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult DecreaseQuantity()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DecreaseQuantity);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult TotalPriceJson()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.TotalPriceJson);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult TotalValue()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TotalValue);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public KoszykController Actions { get { return MVC.Koszyk; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Koszyk";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Koszyk";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string AddToCart = "AddToCart";
            public readonly string RemoveFromCart = "RemoveFromCart";
            public readonly string IncreaseQuantity = "IncreaseQuantity";
            public readonly string DecreaseQuantity = "DecreaseQuantity";
            public readonly string TotalPriceJson = "TotalPriceJson";
            public readonly string TotalValue = "TotalValue";
            public readonly string Index = "Index";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string AddToCart = "AddToCart";
            public const string RemoveFromCart = "RemoveFromCart";
            public const string IncreaseQuantity = "IncreaseQuantity";
            public const string DecreaseQuantity = "DecreaseQuantity";
            public const string TotalPriceJson = "TotalPriceJson";
            public const string TotalValue = "TotalValue";
            public const string Index = "Index";
        }


        static readonly ActionParamsClass_AddToCart s_params_AddToCart = new ActionParamsClass_AddToCart();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddToCart AddToCartParams { get { return s_params_AddToCart; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddToCart
        {
            public readonly string id = "id";
            public readonly string shoppingCart = "shoppingCart";
            public readonly string quantity = "quantity";
        }
        static readonly ActionParamsClass_RemoveFromCart s_params_RemoveFromCart = new ActionParamsClass_RemoveFromCart();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RemoveFromCart RemoveFromCartParams { get { return s_params_RemoveFromCart; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RemoveFromCart
        {
            public readonly string id = "id";
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_IncreaseQuantity s_params_IncreaseQuantity = new ActionParamsClass_IncreaseQuantity();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_IncreaseQuantity IncreaseQuantityParams { get { return s_params_IncreaseQuantity; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_IncreaseQuantity
        {
            public readonly string id = "id";
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_DecreaseQuantity s_params_DecreaseQuantity = new ActionParamsClass_DecreaseQuantity();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DecreaseQuantity DecreaseQuantityParams { get { return s_params_DecreaseQuantity; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DecreaseQuantity
        {
            public readonly string id = "id";
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_TotalPriceJson s_params_TotalPriceJson = new ActionParamsClass_TotalPriceJson();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TotalPriceJson TotalPriceJsonParams { get { return s_params_TotalPriceJson; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TotalPriceJson
        {
            public readonly string cart = "cart";
        }
        static readonly ActionParamsClass_TotalValue s_params_TotalValue = new ActionParamsClass_TotalValue();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_TotalValue TotalValueParams { get { return s_params_TotalValue; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_TotalValue
        {
            public readonly string shoppingCart = "shoppingCart";
        }
        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
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
                public readonly string CartLine = "CartLine";
                public readonly string CartTable = "CartTable";
                public readonly string Index = "Index";
            }
            public readonly string CartLine = "~/Views/Koszyk/CartLine.cshtml";
            public readonly string CartTable = "~/Views/Koszyk/CartTable.cshtml";
            public readonly string Index = "~/Views/Koszyk/Index.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_KoszykController : SukkuShop.Controllers.KoszykController
    {
        public T4MVC_KoszykController() : base(Dummy.Instance) { }

        [NonAction]
        partial void AddToCartOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, SukkuShop.Models.Cart shoppingCart, int quantity);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddToCart(int id, SukkuShop.Models.Cart shoppingCart, int quantity)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddToCart);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "quantity", quantity);
            AddToCartOverride(callInfo, id, shoppingCart, quantity);
            return callInfo;
        }

        [NonAction]
        partial void RemoveFromCartOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.ActionResult RemoveFromCart(int id, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemoveFromCart);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            RemoveFromCartOverride(callInfo, id, shoppingCart);
            return callInfo;
        }

        [NonAction]
        partial void IncreaseQuantityOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, int id, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.JsonResult IncreaseQuantity(int id, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.IncreaseQuantity);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            IncreaseQuantityOverride(callInfo, id, shoppingCart);
            return callInfo;
        }

        [NonAction]
        partial void DecreaseQuantityOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, int id, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.JsonResult DecreaseQuantity(int id, SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DecreaseQuantity);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            DecreaseQuantityOverride(callInfo, id, shoppingCart);
            return callInfo;
        }

        [NonAction]
        partial void TotalPriceJsonOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, SukkuShop.Models.Cart cart);

        [NonAction]
        public override System.Web.Mvc.JsonResult TotalPriceJson(SukkuShop.Models.Cart cart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.TotalPriceJson);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cart", cart);
            TotalPriceJsonOverride(callInfo, cart);
            return callInfo;
        }

        [NonAction]
        partial void TotalValueOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.ActionResult TotalValue(SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TotalValue);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            TotalValueOverride(callInfo, shoppingCart);
            return callInfo;
        }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, SukkuShop.Models.Cart shoppingCart);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(SukkuShop.Models.Cart shoppingCart)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shoppingCart", shoppingCart);
            IndexOverride(callInfo, shoppingCart);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
