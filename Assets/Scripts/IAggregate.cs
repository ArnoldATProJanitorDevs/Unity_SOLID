public interface IAggregateByName
{
    string Name { get; set; }
    string GetName();
}

public interface IAggregateByWorth
{
    float Worth { get; set; }
    float GetWorth();
}

public interface IAggregateByConsumable
{
    bool IsConsumable { get; set; }
    
    bool GetConsumable();
}

public interface IAggregateByLootable
{
    bool isLootable { get; set; }

    bool GetLootable();
}

