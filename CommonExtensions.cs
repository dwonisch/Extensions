using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class CommonExtensions
    {
        public static string ToStringOrEmpty(this object value) {
            return value + string.Empty;
        }
    }
}
