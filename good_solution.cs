public static class HtmlHelperExtensionMethods
{
    public static IHtmlContent Bold(this IHtmlHelper htmlHelper, string content)
    {
        var encoded = System.Net.WebUtility.HtmlEncode(content);
        return new HtmlString($"<span class='bold'>{encoded}</span>");
    }
}