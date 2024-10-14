using UnityEngine;

public class ElementFactory : MonoBehaviour
{
    [SerializeField]
    private Sprite goldSprite;
    public Sprite GoldSprite { get { return goldSprite; } }

    [SerializeField]
    private Sprite ironSprite;
    public Sprite IronSprite { get { return ironSprite; } }

    [SerializeField]
    private Sprite copperSprite;
    public Sprite CopperSprite { get { return copperSprite; } }

    [SerializeField]
    private Sprite bismuthSprite;
    public Sprite BismuthSprite {  get { return bismuthSprite; } }

    [SerializeField]
    private Sprite tungstenSprite;
    public Sprite TungstenSprite {  get { return tungstenSprite; } }

    [SerializeField]
    private Sprite zincSprite;
    public Sprite ZincSprite { get { return zincSprite; } }


    public static ElementFactory instance;

    private void Awake() { instance = this; }

    public IElement GetElement(ElementType type)
    {
        switch (type)
        {
            case ElementType.Iron:
                IElement iron = new Iron();
                return iron;
            case ElementType.Gold:
                IElement gold = new Gold();
                return gold;
            case ElementType.Copper:
                IElement copper = new Copper();
                return copper;
            case ElementType.Bismuth:
                IElement bismuth = new Bismuth();
                return bismuth;
            case ElementType.Tungsten:
                IElement tungsten = new Tungsten();
                return tungsten;
            case ElementType.Zinc:
                IElement zinc = new Zinc();
                return zinc;
        }
        return null;
    }
}
