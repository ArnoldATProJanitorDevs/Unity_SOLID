using UnityEngine;

public abstract class GeoObject: MonoBehaviour
{
    protected int[] Values;
    public int id;

    public GeoObject(int[] values, int id)
    {
        Values = values;
        this.id = id;
    }

    public abstract int AdditionOfValues();
}