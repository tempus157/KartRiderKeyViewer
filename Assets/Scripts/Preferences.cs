using UnityEngine;
using UnityEngine.UI;

public class Preferences : MonoBehaviour {
    private static readonly Color SelectionColor =
        new Color(0.5411765f, 0.7058824f, 0.972549f);

    private static readonly Color DeselectionColor = Color.white;

    public void SelectTab(Image image) {
        image.color = SelectionColor;
    }

    public void DeselectTab(Image image) {
        image.color = DeselectionColor;
    }
}
