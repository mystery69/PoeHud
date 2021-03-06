﻿using System;

namespace PoeHUD.Framework.Helpers
{
    public static class ConvertHelper
    {
        public static string ToShorten(double value, string format = "0")
        {
            double abs = Math.Abs(value);
            if (abs >= 1000000)
            {
                return string.Concat((value / 1000000).ToString("F2"), "M");
            }

            if (abs >= 1000)
			{
				return string.Concat((value / 1000).ToString("F1"), "K");
			}

            return value.ToString(format);
        }
    }
}