using UnityEngine;

public static class ColorHandler
{
    public static Color GenRandColor()
    {
        return new Color(Random.Range(0, 1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f), 1);
    }
}
