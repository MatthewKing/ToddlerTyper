using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ToddlerTyper;

/// <summary>
/// Provides functionality to enable and disable the start menu key.
/// </summary>
internal static partial class StartMenuKey
{
    private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private const int VK_LWIN = 0x5B;
    private const int VK_RWIN = 0x5C;

    /// <summary>
    /// Native methods used by this class.
    /// </summary>
    private static partial class NativeMethods
    {
        [LibraryImport("user32.dll")]
        public static partial IntPtr SetWindowsHookExA(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool UnhookWindowsHookEx(IntPtr hhk);

        [LibraryImport("user32.dll")]
        public static partial IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [LibraryImport("kernel32.dll")]
        public static partial IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.LPStr)] string lpModuleName);
    }

    /// <summary>
    /// They key hook handle.
    /// </summary>
    private static IntPtr? KeyHookHandle;

    /// <summary>
    /// Disable the start menu key.
    /// </summary>
    public static void Disable()
    {
        // If the key hook handle already has a value, we don't need to disable it again.
        if (KeyHookHandle.HasValue)
        {
            return;
        }

        using var process = Process.GetCurrentProcess();
        using var module = process?.MainModule;

        // If we couldn't find the process or module, we can't set up the key hook.
        if (process is null || module is null)
        {
            return;
        }

        KeyHookHandle = NativeMethods.SetWindowsHookExA(
            WH_KEYBOARD_LL,
            HookProcImplementation,
            NativeMethods.GetModuleHandleA(module.ModuleName),
            0);
    }

    /// <summary>
    /// Enable the start menu key.
    /// </summary>
    public static void Enable()
    {
        if (KeyHookHandle.HasValue)
        {
            NativeMethods.UnhookWindowsHookEx(KeyHookHandle.Value);
        }
    }

    private static IntPtr HookProcImplementation(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == WM_KEYDOWN)
        {
            var vkCode = Marshal.ReadInt32(lParam);
            if (vkCode == VK_LWIN || vkCode == VK_RWIN)
            {
                return 1; // Block the key
            }
        }

        return NativeMethods.CallNextHookEx(KeyHookHandle!.Value, nCode, wParam, lParam);
    }
}
