using UnityEngine;

class Rock: MonoBehaviour, ICrunch
{

    public KeyCode key;
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Crunch();
        }
    }
    public void Crunch()
    {
        Destroy(gameObject);
    }
}