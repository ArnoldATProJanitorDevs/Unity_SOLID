using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color;

    public void ChangeColor()
    {
        color = ColorHandler.GenRandColor();
        ApplyColor(color);
        Logger.PrintToConsole(color);
    }

    private void ApplyColor(Color clr)
    {
        gameObject.GetComponent<SpriteRenderer>().color = clr;
    }

  
}
