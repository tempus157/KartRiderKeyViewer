using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Preferences : MonoBehaviour {
    public void SelectTab(Image image) {
        image.color = new Color(0.5411765f, 0.7058824f, 0.972549f);
    }

    public void DeselectTab(Image image) {
        image.color = Color.white;
    }

    public void SetControl(TextMeshProUGUI text) {
        IEnumerator Coroutine() {
            text.text = "-";
            var keyCode = RawKeyCode.None;

            yield return new WaitWhile(() => {
                keyCode = RawInput.CurrentKey();
                return keyCode == RawKeyCode.None;
            });
            text.text = keyCode.ToString();
        }

        StartCoroutine(Coroutine());
    }
}
