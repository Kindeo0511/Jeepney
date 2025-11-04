using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeep.View
{
    internal static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static void Clear() => (Username, Role) = (null, null);
    }
}
