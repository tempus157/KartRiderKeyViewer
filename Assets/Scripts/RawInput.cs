using System.Runtime.InteropServices;

public static class RawInput {
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int keyCode);

    public static bool KeyDown(int keyCode) {
        return (GetAsyncKeyState(keyCode) & 0x8000) != 0;
    }
}
