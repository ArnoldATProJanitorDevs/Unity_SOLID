using UnityEngine;

public class ChangeColorPropagateColor : MonoBehaviour
{
    public Color color;
    private SpriteRenderer _spriteRenderer;
    private SpriteRenderer _spriteRenderer1;

    private void Start()
    {
        _spriteRenderer1 = gameObject.GetComponent<SpriteRenderer>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _spriteRenderer.color = new Color(
                Random.Range(0,1.0f), Random.Range(0, 1.0f),Random.Range(0, 1.0f),1);
            color = _spriteRenderer1.color;
            Debug.Log(color);
        }
    }
}
