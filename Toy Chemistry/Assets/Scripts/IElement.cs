using TMPro;
using UnityEngine.UI;
using UnityEngine;

public interface IElement
{
    void DisplayName(TextMeshProUGUI text);
    void DisplayDescription(TextMeshProUGUI text);
    void SetImage(Image image);
}