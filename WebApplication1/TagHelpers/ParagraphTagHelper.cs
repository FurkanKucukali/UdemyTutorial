using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication1.TagHelpers
{
    [HtmlTargetElement("paragraph")]
    public class ParagraphTagHelper:TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent("<b>Custom Tag Helper works<b>");

            base.Process(context, output);
        }
    }
}
