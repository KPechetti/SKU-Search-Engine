using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_SKU_Search
{
    public class Track
    {
        private static string formName;

        public static string GetFormName()
        {
            return formName;
        }

        public static void SetFormName(string name)
        {
            formName = name;
        }
    }
}
