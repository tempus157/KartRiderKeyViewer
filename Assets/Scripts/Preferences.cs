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

    public void GetControlInput(TextMeshProUGUI text) {
        text.text = "-";
        StartCoroutine(Test());


        IEnumerator Test() {
            while (true) {
                Debug.Log(Event.current.keyCode);
                yield return null;
            }
        }
    }
}
