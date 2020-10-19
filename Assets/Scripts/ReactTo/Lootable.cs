using System;

class Lootable : FallingObject, IAggregateByLootable
{
    
    public bool isLootable { get; set; }
    
    public bool GetLootable()
    {
        return isLootable;
    }
    
    void Awake()
    {
        Random random = new Random();
        isLootable = Convert.ToBoolean(random.Next(0, 2));
    }
}