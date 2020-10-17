using System.Linq;
using UnityEngine;

class Square : GeoObject
{
    public void Awake()
    {
        id = Random.Range(2, 4);
        Values = new int[] { 8, 2, 8, 2 };

        if (id % 2 == 0)
        {
            //light wooden color
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0.83f, 0.68f, 0.21f, 1);

        }
        else
        {
            //dark wooden color
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0.66f,0.66f,0.67f,1);
        }
    }

    public Square(int[] values, int id) : base(values, id)
    {
    }

    public override int AdditionOfValues() => Values.Where(x => x % id == 0).Sum();
}