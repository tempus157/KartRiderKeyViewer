using UnityEngine;

public class KeyViewer : MonoBehaviour {
    private Key[] keys;

    private void Awake() {
        keys = GetComponentsInChildren<Key>();
    }

    private void Update() {
        foreach (var key in keys) {
            if (NativeInput.KeyDown(key.KeyCode)) {
                key.OnKeyDown();
            } else {
                key.OnKeyUp();
            }
        }
    }
}
