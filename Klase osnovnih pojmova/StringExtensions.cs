using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    public static class StringExtensions
    {
        public static int PrebrojiRijeci(this String str)
        {
            var niz = str.Split(' ');
            return niz.Length;
        }
        public static string SkratiRecenicu(this String str, int brojRijeci)
        {
            if (brojRijeci <= 0)
                throw new ArgumentOutOfRangeException("brojRijeci mora biti veći od 0");
            var niz = str.Split(' ');

            if (niz.Length <= brojRijeci)
                return str;

            return string.Join(" ", niz.Take(brojRijeci)) + "...";
        }

    }
}
