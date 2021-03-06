#pragma checksum "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b10145e70ce5ee62041480f3237357bb9de6b45b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Post), @"mvc.1.0.view", @"/Views/Blog/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Post.cshtml", typeof(AspNetCore.Views_Blog_Post))]
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
#line 1 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\_ViewImports.cshtml"
using LinkaBlog;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\_ViewImports.cshtml"
using LinkaBlog.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\_ViewImports.cshtml"
using LinkaBlog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b10145e70ce5ee62041480f3237357bb9de6b45b", @"/Views/Blog/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d6f2ef45f270ad7ff63c707baa767aed35cccd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/blog-details/comment-img-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/blog-details/comment-img-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
  ViewBag.Title = Model.Title;
	ViewBag.Description = Model.Description;
	ViewBag.Keywords = $"{Model.Tags?.Replace(",", "")}{Model.Category}";

#line default
#line hidden
            BeginContext(163, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fa16a6bdb34bbca8ae293e8072a88b", async() => {
                BeginContext(169, 10, true);
                WriteLiteral("\r\n\t<title>");
                EndContext();
                BeginContext(180, 13, false);
#line 7 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(193, 10, true);
                WriteLiteral("</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(210, 306, true);
            WriteLiteral(@"

<!-- Start Blog Details Area -->



<section class=""blog-details-area ptb-100"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-lg-12"">
				<div class=""blog-details-desc blog-details-four sidebar-without"">
					<div class=""article-content"">
						<div class=""article-image"">
");
            EndContext();
#line 21 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                             if (!String.IsNullOrEmpty(Model.Image))
							{
								var image_path = $"/Image/{Model.Image}";


#line default
#line hidden
            BeginContext(628, 12, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 640, "\"", 657, 1);
#line 25 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
WriteAttributeValue("", 646, image_path, 646, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(658, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 26 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"

							}

#line default
#line hidden
            BeginContext(673, 98, true);
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"entry-meta\">\r\n\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t<li><span>Posted On:</span> <a>");
            EndContext();
            BeginContext(772, 52, false);
#line 31 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                          Write(String.Format("{0:yyyy/MM/dd/hh:mm}", Model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(824, 59, true);
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t\t<li><span>Posted By:</span> <a href=\"#\">");
            EndContext();
            BeginContext(884, 15, false);
#line 32 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                                   Write(Model.AdminName);

#line default
#line hidden
            EndContext();
            BeginContext(899, 62, true);
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<h3 class=\"mb-3\">");
            EndContext();
            BeginContext(962, 11, false);
#line 35 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                    Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(973, 18, true);
            WriteLiteral("</h3>\r\n\r\n\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(992, 10, false);
#line 37 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                      Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(1751, 911, true);
            WriteLiteral(@"


						<div class=""article-footer"">
							<div class=""article-tags"">
								<span><i class='bx bx-share-alt'></i></span>

								<a href=""#"">Share</a>
							</div>

							<div class=""article-share"">
								<ul class=""social"">
									<li>
										<a href=""#"" target=""_blank"">
											<i class='bx bxl-facebook'></i>
										</a>
									</li>
									<li>
										<a href=""#"" target=""_blank"">
											<i class='bx bxl-twitter'></i>
										</a>
									</li>
									<li>
										<a href=""#"" target=""_blank"">
											<i class='bx bxl-linkedin'></i>
										</a>
									</li>
									<li>
										<a href=""#"" target=""_blank"">
											<i class='bx bxl-pinterest-alt'></i>
										</a>
									</li>

								</ul>
							</div>
						</div>



						<div class=""comments-area"">
							<h3 class=""comments-title"">Comments:</h3>
");
            EndContext();
#line 114 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                             if (Model.MainComments == null)
							{

#line default
#line hidden
            BeginContext(2713, 52, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<h3 class=\"comments-title\">NoComments</h3>\r\n");
            EndContext();
#line 117 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
							}
							else
							{

#line default
#line hidden
            BeginContext(2798, 68, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<ol class=\"comment-list\">\r\n\t\t\t\t\t\t\t\t\t<li class=\"comment\">\r\n\r\n");
            EndContext();
#line 123 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                         foreach (var c in Model.MainComments)
										{

#line default
#line hidden
            BeginContext(2929, 145, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<footer class=\"comment-meta\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-author vcard\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3074, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40fda3a528474e858bd68c9f46d846b6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3149, 30, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<b class=\"fn\">");
            EndContext();
            BeginContext(3180, 6, false);
#line 129 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                                 Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3186, 161, true);
            WriteLiteral("</b>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"says\">says:</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-metadata\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(3348, 49, false);
#line 135 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                             Write(String.Format("{0:yyyy/MM/dd/hh:mm}", @c.Created));

#line default
#line hidden
            EndContext();
            BeginContext(3397, 134, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</footer>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-content\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(3532, 9, false);
#line 141 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                  Write(c.Message);

#line default
#line hidden
            EndContext();
            BeginContext(3541, 28, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n");
            EndContext();
#line 144 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                  
													await Html.RenderPartialAsync("_SubComment", new CommentViewModel { PostId = Model.Id, MainCommentId = c.Id });
												

#line default
#line hidden
            BeginContext(3726, 19, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 148 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                             foreach (var sc in c.SubComments)
											{

#line default
#line hidden
            BeginContext(3806, 227, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<ol class=\"children\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<li class=\"comment\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<footer class=\"comment-meta\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-author vcard\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(4033, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2204763af463497e8002eefe0a82f99c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4108, 33, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<b class=\"fn\">");
            EndContext();
            BeginContext(4142, 7, false);
#line 156 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                                             Write(sc.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4149, 177, true);
            WriteLiteral("</b>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"says\">says:</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-metadata\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span> ");
            EndContext();
            BeginContext(4327, 50, false);
#line 162 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                                          Write(String.Format("{0:yyyy/MM/dd/hh:mm}", @sc.Created));

#line default
#line hidden
            EndContext();
            BeginContext(4377, 149, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</footer>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"comment-content\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(4527, 10, false);
#line 168 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                                              Write(sc.Message);

#line default
#line hidden
            EndContext();
            BeginContext(4537, 219, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"reply\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</ol>\r\n");
            EndContext();
#line 179 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
											}

#line default
#line hidden
#line 179 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                                             
										}

#line default
#line hidden
            BeginContext(4783, 35, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\r\n\t\t\t\t\t\t\t\t</ol>\r\n");
            EndContext();
#line 185 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
							}

#line default
#line hidden
            BeginContext(4828, 7, true);
            WriteLiteral("\t\t\t\t\t\t\t");
            EndContext();
#line 186 "C:\Users\User\Desktop\LinkaBlog\LinkaBlog\Views\Blog\Post.cshtml"
                              
								await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = 0 });
							

#line default
#line hidden
            BeginContext(4968, 115, true);
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n<!-- End Blog Details Area -->\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
