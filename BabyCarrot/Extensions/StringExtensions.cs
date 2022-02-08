﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyCarrot.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNumeric(this string s)
        {
            long result;
            return long.TryParse(s, out result);
            //문자열이 long형인가 ?
        }

        public static bool IsDateTime(this string s)
        {
            if(String.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                DateTime result;
                return DateTime.TryParse(s, out result);
                // 문자열이 DateTime 형식인가 ?
            }
        }
    }
}
