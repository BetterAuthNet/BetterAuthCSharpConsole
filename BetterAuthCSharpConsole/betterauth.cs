using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace BetterAuthCSharpConsole
{

    class betterauth
    {
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool init_application(String application_name);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool get_file(UInt32 id, out UInt64 data, out UInt32 size);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool c_register(String username, String password);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool c_login(String username, String password);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool c_activatekey(String key);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern string has_sub(UInt32 id, out bool hassub);
      
    }
}
