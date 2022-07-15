using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHelpers.Common
{
    public static class ExtensionMethods
    {
        public static string ConvertToString<T>(this IList<T> list)
        {
            return string.Join(',', list);
        }
    }
}
