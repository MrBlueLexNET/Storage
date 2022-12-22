using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace Storage.TagHelpers
{
    [HtmlTargetElement("level")]
    public class CategoryTagHelper : TagHelper
    {
        public int Category { get; set; }
       
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            //output.AddClass("level", HtmlEncoder.Default);

            if (Category == 0 || Category == 32)
            {
                output.Content.SetHtmlContent("Store in section N/A".ToString());
            }
            else if (Category == 7 || Category == 8)
            {
                output.Content.SetHtmlContent("Store in section IR".ToString());
            }
            else
            {
                output.Content.SetHtmlContent("Place the item label on the right hand side and Store".ToString());
            }

        }
    }
}
