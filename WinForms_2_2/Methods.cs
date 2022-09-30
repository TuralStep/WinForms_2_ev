static class ExtensionMethods
{
    public static string removeStart(this string str)
    {
        if (str.StartsWith("/r"))
            str = str.Remove(0, 2);

        return str;
    }
}