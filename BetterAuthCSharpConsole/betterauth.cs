using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace BetterAuthCSharpConsole
{

    class betterauth
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool init_application(String application_name);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        unsafe public static extern bool get_file(UInt32 id, UInt64* data, UInt32* size);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool c_register(String username, String password);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool c_login(String username, String password);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        public static extern bool c_activatekey(String key);
        [DllImport("BetterAuthUser.dll", CharSet = CharSet.Unicode)]
        unsafe public static extern string has_sub(UInt32 id, bool* has_sub);
    


            
      
    }
}
