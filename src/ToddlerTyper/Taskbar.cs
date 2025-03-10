using System.Runtime.InteropServices;

namespace ToddlerTyper;

/// <summary>
/// Provides functionality to interact with the taskbar.
/// </summary>
internal static partial class Taskbar
{
    /// <summary>
    /// Native methods used by this class.
    /// </summary>
    private static partial class NativeMethods
    {
        [LibraryImport("user32.dll", StringMarshalling = StringMarshalling.Utf8)]
        public static partial IntPtr FindWindowA(string lpClassName, string lpWindowName);

        [LibraryImport("user32.dll", StringMarshalling = StringMarshalling.Utf8)]
        public static partial IntPtr FindWindowExA(IntPtr parentHwnd, IntPtr childAfterHwnd, IntPtr className, string windowText);

        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }

    /// <summary>
    /// Start Menu orb class atom.
    /// </summary>
    private const int StartMenuClassAtom = 0xC017;

    /// <summary>
    /// Start Menu orb title.
    /// </summary>
    private const string StartMenuTitle = "Start";

    /// <summary>
    /// Taskbar class name.
    /// </summary>
    private const string TaskbarClassName = "Shell_TrayWnd";

    /// <summary>
    /// Lock object to use to keep everything thread safe.
    /// </summary>
    private static Lock Lock { get; } = new Lock();

    /// <summary>
    /// Show the Windows Taskbar (including Start Menu orb).
    /// </summary>
    public static void Show()
    {
        const int ShowNormal = 0x01;

        lock (Lock)
        {
            // Show the taskbar.
            var hWnd = NativeMethods.FindWindowA(TaskbarClassName, string.Empty);
            NativeMethods.ShowWindow(hWnd, ShowNormal);

            // Show the start menu.
            var hwndOrb = NativeMethods.FindWindowExA(IntPtr.Zero, IntPtr.Zero, (IntPtr)StartMenuClassAtom, StartMenuTitle);
            NativeMethods.ShowWindow(hwndOrb, ShowNormal);
        }
    }

    /// <summary>
    /// Hide the Windows Taskbar (including Start Menu orb).
    /// </summary>
    public static void Hide()
    {
        const int Hide = 0;

        lock (Lock)
        {
            // Hide the taskbar.
            var hWnd = NativeMethods.FindWindowA(TaskbarClassName, string.Empty);
            NativeMethods.ShowWindow(hWnd, Hide);

            // Hide the start menu.
            var hwndOrb = NativeMethods.FindWindowExA(IntPtr.Zero, IntPtr.Zero, (IntPtr)StartMenuClassAtom, StartMenuTitle);
            NativeMethods.ShowWindow(hwndOrb, Hide);
        }
    }
}
