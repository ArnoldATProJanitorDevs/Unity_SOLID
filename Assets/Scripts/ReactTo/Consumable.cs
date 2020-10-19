using System;

class Consumable : FallingObject, IAggregateByConsumable, IAggregateByWorth
{
    public bool IsConsumable { get; set; }

    public bool GetConsumable()
    {
        return IsConsumable;
    }
    
    public float Worth { get; set; }
    public float GetWorth()
    {
        return Worth;
    }

    void Awake()
    {
        Random random = new Random();

        Worth = (float)random.NextDouble()*3;
        IsConsumable = Convert.ToBoolean(new Random().Next(0,2)); 
    }


   
}
