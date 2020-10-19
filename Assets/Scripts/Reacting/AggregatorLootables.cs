using UnityEngine;
using UnityEngine.UI;

public class AggregatorLootables : MonoBehaviour
{
    public Text statisticText;
    public int aggAmount = 0;
    public string label = "Radar: ";

    void OnTriggerEnter2D(Collider2D col)
    {
        CanBeCounted(col.gameObject.GetComponent<IAggregateByLootable>()?? null);
       
    }

    private void CanBeCounted(IAggregateByLootable fallingObject)
    {
        if (fallingObject == null)
            return;
        
        if (fallingObject.GetLootable())
            aggAmount++;
        statisticText.text = label + aggAmount;
    }
}
