using UnityEngine;
using UnityEngine.UI;

public class AggregatorWorth : MonoBehaviour
{
    public Text statisticText;
    public int aggAmount = 0;
    public string label = "Worth: ";
    void OnTriggerEnter2D(Collider2D col)
    {
        CanBeCounted(col.gameObject.GetComponent<IAggregateByWorth>() ?? null);
    }

    private void CanBeCounted(IAggregateByWorth fallingObject)
    {
        if (fallingObject == null)
            return;
        
        if (fallingObject.GetWorth() > 0 )
            aggAmount++;
        statisticText.text = label + aggAmount;
    }
}
