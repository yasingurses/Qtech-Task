#pragma checksum "C:\Users\Yasin\Desktop\Qtech\QtechWeb\QTechMVC\Views\Date\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "228ef221ec590cbcb83be5b0b448742dc24fa25e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Date_Index), @"mvc.1.0.view", @"/Views/Date/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Yasin\Desktop\Qtech\QtechWeb\QTechMVC\Views\_ViewImports.cshtml"
using QTechMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasin\Desktop\Qtech\QtechWeb\QTechMVC\Views\_ViewImports.cshtml"
using QTechMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yasin\Desktop\Qtech\QtechWeb\QTechMVC\Views\Date\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"228ef221ec590cbcb83be5b0b448742dc24fa25e", @"/Views/Date/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c297f2b67e143d52a5023ba6f2abd2711cec5720", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Date_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Users>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Yasin\Desktop\Qtech\QtechWeb\QTechMVC\Views\Date\Index.cshtml"
  
    ViewData["Title"] = "izin";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "228ef221ec590cbcb83be5b0b448742dc24fa25e3645", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />
    <link rel=""stylesheet""
          href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css""
          integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh""
          crossorigin=""anonymous"" />
    <title>Tarih Se??me</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "228ef221ec590cbcb83be5b0b448742dc24fa25e5014", async() => {
                WriteLiteral(@"
    <div class=""container mt-5"">
        <div class=""form-group"">
            <label for=""baslangicTarihi"">Ba??lang???? Tarihi</label>
            <input type=""date"" class=""form-control"" id=""baslangicTarihi"" />
        </div>
        <div class=""form-group"">
            <label for=""bitisTarihi"">Biti?? Tarihi</label>

            <input type=""date"" class=""form-control"" id=""bitisTarihi"" />
        </div>
        <button type=""button"" class=""btn btn-primary"" id=""tarihHesapla"">Tarih Hesapla</button>
    </div>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""  crossorigin=""anonymous""></script>
    <script
  src=""https://code.jquery.com/ui/1.13.1/jquery-ui.min.js""
  integrity=""sha256-eTyxS0rkjpLEo16uXTS0uVCS4815lc40K2iVpWDvdSY=""
  crossorigin=""anonymous""></script>     
     
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous");
                WriteLiteral("\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n            var model = ");
#nullable restore
#line 41 "C:\Users\Yasin\Desktop\Qtech\QtechWeb\QTechMVC\Views\Date\Index.cshtml"
                   Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            console.log(model)
            $(""#tarihHesapla"").click(function () {
                var baslangicTarihi = new Date($(""#baslangicTarihi"").val());
                var bitisTarihi =
                    new Date($(""#bitisTarihi"").val());
                var isGunuSayisi = 0;

                while (baslangicTarihi <= bitisTarihi) {
                    if (baslangicTarihi.getDay() !== 0 && baslangicTarihi.getDay() !== 6) {
                        isGunuSayisi++;
                    }
                    baslangicTarihi.setDate(baslangicTarihi.getDate() + 1);
                }
                        var modelData = model.userLimit;
                if (isGunuSayisi >= modelData) {
                    alert(""Yeterli izin bakiyeniz bulunmamaktad??r"");
                 }else{
                    alert(""??zin talebiniz iletilmi??tir"");

                 }
               
                 
            });
        });



    </script>

    ");
#nullable restore
#line 71 "C:\Users\Yasin\Desktop\Qtech\QtechWeb\QTechMVC\Views\Date\Index.cshtml"
Write(await Component.InvokeAsync("NToastNotify"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Users> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
