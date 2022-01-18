using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour {
    private static readonly Color KeyDown = new Color(0f, 0.5333334f, 1f);
    private static readonly Color KeyUp = Color.black;
    private static readonly Color SymbolDown = Color.white;
    private static readonly Color SymbolUp = new Color(0f, 0.5333334f, 1f);

    [SerializeField]
    private Graphic key;

    [SerializeField]
    private Graphic symbol;

    [SerializeField]
    private int keyCode;

    public int KeyCode => keyCode;

    public void OnKeyDown() {
        key.color = KeyDown;
        symbol.color = SymbolDown;
    }

    public void OnKeyUp() {
        key.color = KeyUp;
        symbol.color = SymbolUp;
    }
}
