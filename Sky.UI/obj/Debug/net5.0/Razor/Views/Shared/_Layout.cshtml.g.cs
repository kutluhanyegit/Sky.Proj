#pragma checksum "C:\Users\kutlu\OneDrive\Masaüstü\SkyProj\Sky.UI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6b084c24a40d33bfb47dfd746aee41244b69a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Shared.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace MyApp.Namespace.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6b084c24a40d33bfb47dfd746aee41244b69a0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e6b084c24a40d33bfb47dfd746aee41244b69a03300", async() => {
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n  <title>Sky Ticaret ve Sanayi - ");
#nullable restore
#line 6 "C:\Users\kutlu\OneDrive\Masaüstü\SkyProj\Sky.UI\Views\Shared\_Layout.cshtml"
                            Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>

  <link rel=""stylesheet"" href=""css\main.css"">

  <!-- Google Font: Source Sans Pro -->
  <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
  <!-- Font Awesome -->
  <link rel=""stylesheet"" href=""/plugins/fontawesome-free/css/all.min.css"">
  <!-- Ionicons -->
  <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
  <!-- Tempusdominus Bootstrap 4 -->
  <link rel=""stylesheet"" href=""/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"">
  <!-- iCheck -->
  <link rel=""stylesheet"" href=""/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
  <!-- JQVMap -->
  <link rel=""stylesheet"" href=""/plugins/jqvmap/jqvmap.min.css"">
    <!-- DataTables -->
  <link rel=""stylesheet"" href=""../../plugins/datatables-bs4/css/dataTables.bootstrap4.min.css"">
  <link rel=""stylesheet"" href=""../../plugins/datatables-responsive/css/responsive.bootstrap4.min.css"">
  <link rel=""st");
                WriteLiteral(@"ylesheet"" href=""../../plugins/datatables-buttons/css/buttons.bootstrap4.min.css"">
  <!-- Theme style -->
  <link rel=""stylesheet"" href=""/dist/css/adminlte.min.css"">
  <!-- overlayScrollbars -->
  <link rel=""stylesheet"" href=""/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
  <!-- Daterange picker -->
  <link rel=""stylesheet"" href=""/plugins/daterangepicker/daterangepicker.css"">
  <!-- summernote -->
  <link rel=""stylesheet"" href=""/plugins/summernote/summernote-bs4.min.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e6b084c24a40d33bfb47dfd746aee41244b69a06263", async() => {
                WriteLiteral(@"
<div class=""wrapper"">

  <!-- Preloader -->
  <div class=""preloader flex-column justify-content-center align-items-center"">
    <img class=""animation__shake"" src=""/dist/img/AdminLTELogo.png"" alt=""AdminLTELogo"" height=""60"" width=""60"">
  </div>

  <!-- Navbar -->
  <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
      <li class=""nav-item"">
        <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
      </li>
    </ul>

    <!-- Right navbar links -->
    <ul class=""navbar-nav ml-auto"">
      <!-- Navbar Search -->
     </ul>
  </nav>
  <!-- /.navbar -->

  <!-- Main Sidebar Container -->
  <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
    <!-- Brand Logo -->
    <a href=""index3.html"" class=""brand-link"">
      <img src=""/dist/img/AdminLTELogo.png"" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3"" style=""opacity: .8"">
      <");
                WriteLiteral(@"span class=""brand-text font-weight-light"">AdminLTE 3</span>
    </a>

    <!-- Sidebar -->
    <div class=""sidebar"">
      <!-- Sidebar user panel (optional) -->
      <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
        <div class=""image"">
          <img src=""/dist/img/user2-160x160.jpg"" class=""img-circle elevation-2"" alt=""User Image"">
        </div>
        <div class=""info"">
          <a href=""#"" class=""d-block"">Alexander Pierce</a>
        </div>
      </div>

      
      <!-- Sidebar Menu -->
      <nav class=""mt-2"">
        <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
          
          <li class=""nav-item menu-open"">
            <a href=""/"" class=""nav-link active"">
              
              <i class=""nav-icon fas fa-home""></i>
              <p>
                Anasayfa
                
              </p>
            </a>
            
          </li>

          <li class=""nav-item menu-open"">
       ");
                WriteLiteral(@"     <a href=""/model-yonetimi"" class=""nav-link"">
              <i class=""nav-icon fas fa-list-ol""></i>
              <p>
                Model Yönetimi
              </p>
            </a>
          </li>
         </ul>
      </nav>
      <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
  </aside>

  <!-- Content Wrapper. Contains page content -->
  
  <div class=""content-wrapper"">
      ");
#nullable restore
#line 114 "C:\Users\kutlu\OneDrive\Masaüstü\SkyProj\Sky.UI\Views\Shared\_Layout.cshtml"
 Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
  </div>

  <!-- /.content-wrapper -->
  

  <!-- Control Sidebar -->
  <aside class=""control-sidebar control-sidebar-dark"">
    <!-- Control sidebar content goes here -->
  </aside>
  <!-- /.control-sidebar -->
</div>
<!-- ./wrapper -->

<!-- jQuery -->
<script src=""/plugins/jquery/jquery.min.js""></script>
<!-- jQuery UI 1.11.4 -->
<script src=""/plugins/jquery-ui/jquery-ui.min.js""></script>
<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
<script>
  $.widget.bridge('uibutton', $.ui.button)
</script>
<!-- Bootstrap 4 -->
<script src=""/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
<!-- ChartJS -->
<script src=""/plugins/chart.js/Chart.min.js""></script>
<!-- Sparkline -->
<script src=""/plugins/sparklines/sparkline.js""></script>
<!-- JQVMap -->
<script src=""/plugins/jqvmap/jquery.vmap.min.js""></script>
<script src=""/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
<!-- jQuery Knob Chart -->
<script src=""/plugins/jquery-knob/jquery.knob.min.js""></scr");
                WriteLiteral(@"ipt>
<!-- daterangepicker -->
<script src=""/plugins/moment/moment.min.js""></script>
<script src=""/plugins/daterangepicker/daterangepicker.js""></script>
<!-- Tempusdominus Bootstrap 4 -->
<script src=""/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
<!-- Summernote -->
<script src=""/plugins/summernote/summernote-bs4.min.js""></script>
<!-- overlayScrollbars -->
<script src=""/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>

<!-- DataTables  & Plugins -->
<script src=""/plugins/datatables/jquery.dataTables.min.js""></script>
<script src=""/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
<script src=""/plugins/datatables-responsive/js/dataTables.responsive.min.js""></script>
<script src=""/plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
<script src=""/plugins/datatables-buttons/js/dataTables.buttons.min.js""></script>
<script src=""/plugins/datatables-buttons/js/buttons.bootstrap4.min.js""></script>
<script ");
                WriteLiteral(@"src=""/plugins/jszip/jszip.min.js""></script>
<script src=""/plugins/pdfmake/pdfmake.min.js""></script>
<script src=""/plugins/pdfmake/vfs_fonts.js""></script>
<script src=""/plugins/datatables-buttons/js/buttons.html5.min.js""></script>
<script src=""/plugins/datatables-buttons/js/buttons.print.min.js""></script>
<script src=""/plugins/datatables-buttons/js/buttons.colVis.min.js""></script>

<!-- AdminLTE App -->
<script src=""/dist/js/adminlte.js""></script>
<!-- AdminLTE for demo purposes -->
<script src=""/dist/js/demo.js""></script>
<!-- AdminLTE dashboard demo (This is only for demo purposes) -->
<script src=""/dist/js/pages/dashboard.js""></script>
<script>
  $(function () {
    $(""#example1"").DataTable({
      ""responsive"": true, ""lengthChange"": false, ""autoWidth"": false,
      ""buttons"": [""copy"", ""csv"", ""excel"", ""pdf"", ""print"", ""colvis""]
    }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');
    $('#example2').DataTable({
      ""paging"": true,
      ""lengthChange"": false,
   ");
                WriteLiteral("   \"searching\": false,\r\n      \"ordering\": true,\r\n      \"info\": true,\r\n      \"autoWidth\": false,\r\n      \"responsive\": true,\r\n    });\r\n  });\r\n</script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591