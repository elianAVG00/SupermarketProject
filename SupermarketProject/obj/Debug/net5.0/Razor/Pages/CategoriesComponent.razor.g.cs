#pragma checksum "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d796592050f813884cb4101a5529f3891da10c7"
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
using CoreBusiness;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class CategoriesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CRUD Categorias</h3>");
#nullable restore
#line 7 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
 if (categories != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><th>Name</th>\r\n        <th>Description</th>\r\n        <th></th></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 16 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
             foreach (var category in categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 19 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
                         category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 20 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
                         category.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
                                                          () => EditCategory(category)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-link");
            __builder.AddContent(17, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<br>\r\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
                                OnClickAddCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddContent(23, "Agregar categoria");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\CategoriesComponent.razor"
       
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        categories = viewCategoryUseCase.Execute();
    }

    private void OnClickAddCategory()
    {
        navigationManager.NavigateTo("/addcategory");
    }

    private void EditCategory(Category category)
    {
        navigationManager.NavigateTo($"/editCategory/{category.CategoryId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewCategoriesUseCase viewCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
