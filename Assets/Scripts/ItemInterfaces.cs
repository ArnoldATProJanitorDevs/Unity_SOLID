using UnityEngine;

internal interface IFlame
{
    void Flame();
}

internal interface ICrunch
{
    void Crunch();
}

internal interface IThrow
{
    void Throw();
}

internal interface IKick
{
    void Kick();
}

interface IPickup
{
    void Pickup();
}



interface ISmell
{
    void Smell();
}

interface ISmellLonger
{
    void SmellForSeconds(float seconds);
}

interface ISmellTheLongest
{
    void SmellForever(bool? forever = true);
}


public class SmellyCircle : MonoBehaviour, ISmell
{
    public void Smell()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 800);
    }
}

public class MoreSmellyCircle : MonoBehaviour, ISmellLonger
{
   
    public void SmellForSeconds(float seconds)
    {
        //smell for seconds
    }
}

public class DeadCircle : MonoBehaviour, ISmellTheLongest
{

    public void SmellForever(bool? forever)
    {
        throw new System.NotImplementedException();
    }
}