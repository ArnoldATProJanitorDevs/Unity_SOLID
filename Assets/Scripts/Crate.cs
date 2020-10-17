using System;
using UnityEngine;

class Crate : MonoBehaviour, IPickableItem
{
    public KeyCode key;
    public float throttle;
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Kick();
        }
    }


    public void Pickup()
    {
        throw new NotImplementedException();
    }

    public void Throw()
    {
        throw new NotImplementedException();
    }

    public void Crunch()
    {
        throw new NotImplementedException();
    }

    public void Kick()
    {

        gameObject.GetComponent<Rigidbody2D>().AddForce((Vector2.up + Vector2.left) * throttle);
    }

    public void Flame()
    {
        throw new NotImplementedException();
    }
}
