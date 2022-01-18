using System.Runtime.InteropServices;

public static class NativeInput {
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int key);

    public static bool KeyDown(int key) {
        return (GetAsyncKeyState(key) & 0x8000) != 0;
    }
}
