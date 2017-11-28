using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MVP.Core
{
    public static class UrlSlugGenerator
    {
        public static string GenerateSlug(this string phrase, int maxLength = 100)
        {
            string str = phrase.ToLower();
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            str = Regex.Replace(str, @"[\s-]+", " ").Trim();
            str = str.Substring(0, str.Length <= maxLength ? str.Length : maxLength).Trim();
            str = Regex.Replace(str, @"\s", "-");
            return str;
        }
    }
}
