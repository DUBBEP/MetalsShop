using TMPro;
using UnityEngine.UI;
using UnityEngine;

public enum ElementType
{
    Gold,
    Iron,
    Copper,
    Bismuth,
    Tungsten,
    Zinc
}

public class Gold : IElement
{
    public void DisplayName(TextMeshProUGUI text)
    {
        text.text = "Gold";
    }
    public void DisplayDescription(TextMeshProUGUI text)
    {
        text.text = "Sorry but you don't have the cash for that";
    }
    public void SetImage(Image image)
    {
        image.sprite = ElementFactory.instance.GoldSprite;
    }
}
public class Iron : IElement
{
    public void DisplayName(TextMeshProUGUI text)
    {
        text.text = "Iron";
    }
    public void DisplayDescription(TextMeshProUGUI text)
    {
        text.text = "A sturdy metal";
    }

    public void SetImage(Image image)
    {
        image.sprite = ElementFactory.instance.IronSprite;
    }
}
public class Copper : IElement
{
    public void DisplayName(TextMeshProUGUI text)
    {
        text.text = "Copper";
    }
    public void DisplayDescription(TextMeshProUGUI text)
    {
        text.text = "A great conductor";
    }
    public void SetImage(Image image)
    {
        image.sprite = ElementFactory.instance.CopperSprite;
    }
}
public class Bismuth : IElement
{
    public void DisplayName(TextMeshProUGUI text)
    {
        text.text = "Bismuth";
    }
    public void DisplayDescription(TextMeshProUGUI text)
    {
        text.text = "One of the most colorful Metals";
    }
    public void SetImage(Image image)
    {
        image.sprite = ElementFactory.instance.BismuthSprite;
    }
}
public class Tungsten : IElement
{
    public void DisplayName(TextMeshProUGUI text)
    {
        text.text = "Tungsten";
    }
    public void DisplayDescription(TextMeshProUGUI text)
    {
        text.text = "Are you sure you're strong enough to carry that out of here?";
    }
    public void SetImage(Image image)
    {
        image.sprite = ElementFactory.instance.TungstenSprite;
    }
}
public class Zinc : IElement
{
    public void DisplayName(TextMeshProUGUI text)
    {
        text.text = "Zinc";
    }
    public void DisplayDescription(TextMeshProUGUI text)
    {
        text.text = "Someone once told me this is the 'healthiest metal' whatever that means.";
    }
    public void SetImage(Image image)
    {
        image.sprite = ElementFactory.instance.ZincSprite;
    }
}