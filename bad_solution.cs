public static class HtmlHelperExtensionMethods
{
    public static IHtmlContent Bold(this IHtmlHelper htmlHelper, string content)
    {
        return new HtmlString($"<span class='bold'>{content}</span>");
    }
}