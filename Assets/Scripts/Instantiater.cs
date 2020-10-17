using UnityEngine;

class Instantiater : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField]private float initTime;
    private float timer;

    void Awake()
    {
        timer = initTime;
    }
    
    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(prefab, gameObject.transform.localPosition, Quaternion.identity); 
            timer = initTime;
        }
    }
}

