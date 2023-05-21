using Microsoft.Win32;

namespace SimpleWinlogonAutostart
{
    class Program
    {
        static void Main()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "Shell", string.Empty) as string + ", " + "notepad.exe");
            }
            catch { }

        }
    }
}

