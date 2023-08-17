using System;
using System.Collections;
using System.Net.NetworkInformation;
using System.Text;
using System.Web;

namespace Common.Net
{
    public static class Extensions
    {
        public static string GetRelativePath(this string url)
        {
            if (url == null) return "/";

            url = url.Split('?')[0];

            if (url == "") return "/";

            var schemeIndex = url.IndexOf("://");

            if (schemeIndex == -1) return $"/{url.Trim('/')}";

            var pathIndex = url.IndexOf("/", schemeIndex + 3);

            if (pathIndex == -1) return "/";

            return url.Substring(pathIndex).TrimEnd('/');
        }

        public static string GetQueryString(this string url)
        {
            if (url == null) return "/";

            var urlParts = url.Split(new [] {'?'}, 2);

            return urlParts.Length == 1 ? "" : urlParts[1];
        }

        public static Hashtable ParseQueryString(this string querystring)
        {
            var data = new Hashtable();

            var items = querystring.Split('&');

            foreach (var item in items)
            {
                var itemParts = item.Split(new[] { '=' }, 2);
                data[itemParts[0]] = itemParts.Length == 2
                    ? itemParts[1].UrlDecode()
                    : "";
            }

            return data;
        }

        public static string UrlDecode(this string text)
        {
            return HttpUtility.UrlDecode(text);
        }
    }
}
