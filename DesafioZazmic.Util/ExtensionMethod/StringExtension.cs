using System;

namespace DesafioZazmic.Util.ExtensionMethods
{
    public static class StringExtension
    {
        public static int PegaInteiro(this string stringContent)
        {
            var isValid = int.TryParse(stringContent, out int result);

            if (isValid)
                return result;
            else
                return 0;
        }
    }
}
