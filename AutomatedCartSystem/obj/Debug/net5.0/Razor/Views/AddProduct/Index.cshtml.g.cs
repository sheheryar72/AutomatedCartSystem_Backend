#pragma checksum "C:\Users\Sheheryar Izhar\source\repos\AutomatedCartSystem\AutomatedCartSystem\Views\AddProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "194ac8588d0838f5be7687ff7df148323ad3eb8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddProduct_Index), @"mvc.1.0.view", @"/Views/AddProduct/Index.cshtml")]
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
#line 1 "C:\Users\Sheheryar Izhar\source\repos\AutomatedCartSystem\AutomatedCartSystem\Views\_ViewImports.cshtml"
using AutomatedCartSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"194ac8588d0838f5be7687ff7df148323ad3eb8a", @"/Views/AddProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a8d1be502460b1ecc40a9d75ffc4c648409049", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AddProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Api/InsertProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "194ac8588d0838f5be7687ff7df148323ad3eb8a5163", async() => {
                WriteLiteral(@"
	<title>Add Product</title>
	<meta charset=""utf-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

	<link href='https://fonts.googleapis.com/css?family=Roboto:400,100,300,700' rel='stylesheet' type='text/css'>

	<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">

	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

	<link rel=""stylesheet"" href=""css/style.css"">


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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "194ac8588d0838f5be7687ff7df148323ad3eb8a6665", async() => {
                WriteLiteral(@"
	<section class=""ftco-section"">
		<div class=""container"">
			<div class=""row justify-content-center"">
				<div class=""col-md-6 text-center mb-5"">
					<!-- <h2 class=""heading-section"">Add Product</h2> -->
				</div>
			</div>
			<div class=""row justify-content-center"">
				<div class=""col-md-12"">
					<div class=""wrapper"">

						<div class=""row"">
							<div class=""col-md-3"">
								<div id=""qrcode"" class=""mt-5 text-center"">

								</div>
							</div>
							<div class=""col-md-9"">
								<div class=""row no-gutters"">
									<div class=""col-lg-12 col-md-12 order-md-last d-flex align-items-stretch"">
										<div class=""contact-wrap w-100 p-md-5 p-4"">
											<h3 class=""mb-4"">Add Product</h3>
											<div id=""form-message-warning"" class=""mb-4""></div>
											<div id=""form-message-success"" class=""mb-4"">
												Product is added!
											</div>
											");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "194ac8588d0838f5be7687ff7df148323ad3eb8a7878", async() => {
                    WriteLiteral(@"
												<div class=""row"">
													<div class=""col-md-6"">
														<div class=""form-group"">
															<label class=""label"" for=""name"">Product Name</label>
															<input type=""text"" class=""form-control"" name=""Name""
																id=""name"" placeholder=""Product Title"" required>
														</div>
													</div>
													<div class=""col-md-6"">
														<div class=""form-group"">
															<label class=""label"" for=""email"">Product Category</label>
															<input type=""text"" class=""form-control"" name=""Category""
																id=""email"" placeholder=""Product Category"" required>
														</div>
													</div>
													<div class=""col-md-12"">
														<div class=""form-group"">
															<label class=""label"" for=""subject"">Product Price</label>
															<input type=""number"" class=""form-control"" name=""Price""
																id=""subject"" placeholder=""Product Price"" required>
														</div>
													</div>
	");
                    WriteLiteral(@"												<div class=""col-md-12"">
														<div class=""form-group"">
															<label class=""label"" for=""#"">Product Description</label>
															<textarea name=""Discription"" class=""form-control"" id=""message""
																cols=""30"" rows=""4"" placeholder=""Product Description"" required></textarea>
														</div>
													</div>
													<div class=""col-md-6"">
														<div class=""form-group"">
															<label class=""label"" for=""subject"">Product Quantity</label>
															<input type=""number"" class=""form-control"" name=""Quantity""
																id=""pquantity"" placeholder=""Product Quantity"" required>
														</div>
													</div>
													<div class=""col-md-6"">
														<div class=""form-group"">
															<label class=""label"" for=""subject"">Product Barcode</label>
															<input type=""text"" class=""form-control"" name=""Barcode""
																id=""pbarcode"" placeholder=""Product Barcode"" required>
														</div>
		");
                    WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-12\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n");
                    WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input type=\"button\" class=\"btn btn-primary\" value=\"Add Product\" id=\"btnsubmit\" />\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"submitting\"></div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>

	</section>
	
	<script>

window.addEventListener('load', function() {//cahala
	$(""#btnsubmit"").click(function () {

			console.log(""generateqr Called"");

				let data = $('#contactForm').serialize();

				$.ajax({
					type: 'Post',
					url: 'http://www.automatedcart.somee.com/api/InsertProduct',
					data: data,
					success: function (response) {
						alert(""Product Successfully Added"");
					},
					error: function () {
						alert(""Data Not Added"");
					}
				})

			var barcode = document.getElementById('pbarcode').value;
            var name = ""http://www.automatedcart.somee.com/api/Product/GetByBarcode?barcode="" + barcode.toString();

			var url = ""https://chart.googleapis.com/chart?cht=qr&chs=250x250&chl="" + name.toString();

			var ifr = `<iframe src=""${url}"" height=""300"" width=""300""></iframe>`;

			document.getElementById('qrcode').innerHTM");
                WriteLiteral(@"L = ifr;
		})
})

		//function generateqr() {
			
  //          console.log(""generateqr Called"");

		//		let data = $('#contactForm').serialize();

		//		$.ajax({
		//			type: 'Post',
		//			url: 'http://www.automatedcartsystem.somee.com/api/InsertProduct'
		//			data: data,
		//			success: function (responce) {
		//				alert(""Product Successfully Added"");
		//			},
		//			error: function () {
		//				alert(""Data Not Added"");
		//			}
		//		})

		//	var barcode = document.getElementById('pbarcode').value;
  //          var name = ""http://www.automatedcartsystem.somee.com/api/Product/GetByBarcode?barcode="" + barcode.toString();

		//	//console.log('ProductName: ' + name + "" "" + email + "" "" + subject + "" "" + message);

		//	//var url = ""https://chart.googleapis.com/chart?cht=qr&chs=250x250&chl=ProductName:"" +
		//	//name + ""%0a ProductCategory: "" + email + "" Price: "" + subject + "" Description: "" + message + "" Quantity: "" + quantity + "" Barcode: "" + barcode;

		//	var url = ""https:/");
                WriteLiteral(@"/chart.googleapis.com/chart?cht=qr&chs=250x250&chl="" + name.toString();


		//	var ifr = `<iframe src=""${url}"" height=""300"" width=""300""></iframe>`;

		//	document.getElementById('qrcode').innerHTML = ifr;
		//}

	</script>

	<script src=""js/jquery.min.js""></script>
	<script src=""js/popper.js""></script>
	<script src=""js/bootstrap.min.js""></script>
	<script src=""js/jquery.validate.min.js""></script>
	<script src=""js/main.js""></script>


");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
