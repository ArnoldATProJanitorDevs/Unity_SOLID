using System;
using UnityEngine;

public class Coin : MonoBehaviour, IPickup
{
    public KeyCode key;
    private float timer = 0f;
    void Update()
    {
        if (timer > 0)
            timer -= Time.deltaTime;

        if (Input.GetKeyDown(key))
        {
            Pickup();
            timer = 1f;
        }

        if(timer < 0 )
            Destroy(gameObject);
    }

    public void Pickup()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up*800);
    }
}
