using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FilterObjects : MonoBehaviour
{
    private List<Coin> AllCoins = new List<Coin>();
    private List<Coin> ReColorCoins = new List<Coin>();
    private List<Coin> DestroyCoins = new List<Coin>();

    CoinFilter cf = new CoinFilter();

    void OnTriggerEnter2D(Collider2D col)
    {
        AllCoins.Add(col.GetComponent<Coin>());
        ReColorCoins = cf.Filter(AllCoins, new Coin.CoinTypeSpecification(Coin.CoinType.GOOD));
        RecolorObjects(ReColorCoins);
        DestroyCoins = cf.Filter(AllCoins, new Coin.DestroyableSpecification(Coin.DestroyType.FAST));
        DestroyObjects(DestroyCoins);

        List<Coin> PoisionRecolor = new List<Coin>();

        PoisionRecolor = cf.Filter(AllCoins, new Coin.DamageTypeSpecification(Coin.DamageType.POISON));
        PoisionRecolor = cf.Filter(PoisionRecolor, new Coin.CoinTypeSpecification(Coin.CoinType.GOOD));
        RecolorObjects(PoisionRecolor);
    }

    public void RecolorObjects(List<Coin> inputList)
    {
        foreach (var coin in inputList)
        {
            coin.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0, 1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f), 1);
        }
    }

    public void DestroyObjects(List<Coin> inputList)
    {
        foreach (var coin in inputList)
        {
            coin.gameObject.SetActive(false);
        }
    }
}

public class CoinFilter : IFilter<Coin>
{
    public List<Coin> Filter(IEnumerable<Coin> objects, ISpecification<Coin> specification) =>
        objects.Where(m => specification.IsClassified(m)).ToList();
}


