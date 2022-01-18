using System;
using System.Linq;
using System.Runtime.InteropServices;

public static class RawInput {
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int keyCode);

    public static bool KeyDown(RawKeyCode keyCode) {
        return (GetAsyncKeyState((int) keyCode) & 0x8000) != 0;
    }

    public static RawKeyCode CurrentKey() {
        return Enum
            .GetValues(typeof(RawKeyCode))
            .Cast<RawKeyCode>()
            .FirstOrDefault(KeyDown);
    }
}
