using UnityEngine;

public class KeyViewer : MonoBehaviour {
    private Key[] keys;

    private void Awake() {
        Application.targetFrameRate = 60;
        keys = GetComponentsInChildren<Key>();
    }

    private void Update() {
        foreach (var key in keys) {
            if (RawInput.KeyDown((RawKeyCode) key.KeyCode)) {
                key.OnKeyDown();
            } else {
                key.OnKeyUp();
            }
        }
    }
}
