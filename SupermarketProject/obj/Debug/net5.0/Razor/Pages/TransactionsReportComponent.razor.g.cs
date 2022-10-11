#pragma checksum "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a391b264c9f39baaf7c6649a17dd7d7e17d57e3"
// <auto-generated/>
#pragma warning disable 1591
namespace SupermarketProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using SupermarketProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using SupermarketProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using SupermarketProject.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactions")]
    public partial class TransactionsReportComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-2");
            __builder.AddMarkupContent(4, "<label for=\"cashier\">Nombre cajero</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "id", "cashier");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                                                                          cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cashierName = __value, cashierName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-3");
            __builder.AddMarkupContent(14, "<label for=\"stardate\">Fecha inicio</label>\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "date");
            __builder.AddAttribute(17, "id", "startdate");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                                                                            startDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startDate = __value, startDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-3");
            __builder.AddMarkupContent(24, "<label for=\"enddate\">Fecha final</label>\r\n        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "date");
            __builder.AddAttribute(27, "id", "enddate");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                                                                          endDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endDate = __value, endDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-2");
            __builder.AddMarkupContent(34, "<label>&nbsp;</label>\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn btn-primary form-control");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                                                                             LoadTransactions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Buscar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-2");
            __builder.AddMarkupContent(43, "<label>&nbsp;</label>\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-primary form-control");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                                                                             PrintReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Imprimir");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
 if (transactions != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "id", "printarea");
            __builder.OpenElement(51, "table");
            __builder.AddAttribute(52, "class", "table");
            __builder.AddMarkupContent(53, @"<thead><tr><th>Fecha</th>
                    <th>Nombre cajero</th>
                    <th>Nombre producto</th>
                    <th>Cantidad antes</th>
                    <th>Cantidad vendida</th>
                    <th>Cantidad despues</th>
                    <th>Total vendido</th></tr></thead>
            ");
            __builder.OpenElement(54, "tbody");
#nullable restore
#line 46 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                 foreach (var tran in transactions)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "tr");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 49 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                             tran.TimeStamp.ToString("yyyy-MM-dd hh:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 50 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                             tran.CashierName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 51 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                             tran.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 52 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                             tran.BeforeQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 53 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                             tran.SoldQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 54 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                              tran.BeforeQty - tran.SoldQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 55 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                              string.Format("{0:c}", tran.SoldQty * tran.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenElement(77, "tfoot");
            __builder.OpenElement(78, "tr");
            __builder.AddMarkupContent(79, "<td colspan=\"6\">&nbsp;</td>\r\n                    ");
            __builder.AddMarkupContent(80, "<td style=\"text-align:right\"><b>Total Completo: </b></td>\r\n                    ");
            __builder.OpenElement(81, "td");
            __builder.AddAttribute(82, "style", "text-align:right");
            __builder.OpenElement(83, "b");
            __builder.AddContent(84, 
#nullable restore
#line 66 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
                             string.Format("{0:c}", transactions.Sum(x => x.Price * x.SoldQty))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\TransactionsReportComponent.razor"
       
    private string cashierName;
    private DateTime startDate;
    private DateTime endDate;
    private IEnumerable<Transaction> transactions;

    private void LoadTransactions()
    {
        transactions = GetTransactionsUseCase.Execute(cashierName, startDate, endDate);
    }

    private void PrintReport()
    {
        JSRuntime.InvokeVoidAsync("print");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IGetTransactionsUseCase GetTransactionsUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
