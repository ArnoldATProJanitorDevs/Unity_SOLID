using UnityEngine;
using UnityEngine.UI;

public class AggregatorName : MonoBehaviour
{
    public Text statisticText;
    public int aggAmount = 0;
    public string label = "Name: ";

    void OnTriggerEnter2D(Collider2D col)
    {
        CanBeCounted(col.gameObject.GetComponent<IAggregateByName>() ?? null);
    }

    private void CanBeCounted(IAggregateByName fallingObject)
    {
        if (fallingObject == null)
            return;
            
        if (fallingObject.GetName() == "Coin" ||
            fallingObject.GetName() == "Apple" )
            aggAmount++;
        statisticText.text = label + aggAmount;
    }
}
