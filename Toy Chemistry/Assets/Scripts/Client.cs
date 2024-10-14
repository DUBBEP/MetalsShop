using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI examineText;
    public Image ExamineImage;
    private IElement tempElement;

    public void SetElement(ElementType type)
    {
        tempElement = ElementFactory.instance.GetElement(type);

        tempElement.DisplayName(NameText);
        tempElement.SetImage(ExamineImage);
        tempElement.DisplayDescription(examineText);
    }

    public void OnGold() { SetElement(ElementType.Gold); }
    public void OnIron() { SetElement(ElementType.Iron); }
    public void OnCopper() { SetElement(ElementType.Copper); }
    public void OnBismuth() { SetElement(ElementType.Bismuth); }
    public void OnTungsten() { SetElement(ElementType.Tungsten); }
    public void OnZinc() { SetElement(ElementType.Zinc); }
}
