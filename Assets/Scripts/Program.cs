using UnityEngine;

public class Program : MonoBehaviour {
    [SerializeField]
    private Key[] keys;

    private void Awake() {
        Application.targetFrameRate = 60;
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
