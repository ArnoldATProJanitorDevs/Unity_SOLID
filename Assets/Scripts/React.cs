using UnityEngine;

public class React : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GeoObject myGeoObject = col.gameObject.GetComponent<GeoObject>();
        
        if (myGeoObject == null)
            return;
            
        GeoObjectReact(myGeoObject);
    }

    void GeoObjectReact(GeoObject myGeoObject)
    {
        Debug.Log("Type: " + myGeoObject.GetType() + " ,ID: " + myGeoObject.id + " ,Sum: " +  myGeoObject.AdditionOfValues());
    }

}


