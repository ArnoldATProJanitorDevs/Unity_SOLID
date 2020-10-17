using UnityEngine;
using UnityEngine.Events;

public class CheckInput : MonoBehaviour
{
    public KeyCode InvokingKey;

    public UnityEvent keyPressed;
    void Update()
    {
        if (Input.GetKeyDown(InvokingKey))
        {
            keyPressed.Invoke();
        }
    }
}
