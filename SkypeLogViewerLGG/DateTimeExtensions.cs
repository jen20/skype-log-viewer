﻿using System;

namespace SkypeLogViewerLGG
{
    public static class DateTimeExtensions
    {
        public static long ToUnixTimestamp(this DateTime target)
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            var unixTimestamp = Convert.ToInt64((target - date).TotalSeconds);

            return unixTimestamp;
        }
    }
}