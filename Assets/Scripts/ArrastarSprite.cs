using UnityEngine;

public class ArrastrarSprite : MonoBehaviour
{
    private Vector3 offset;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
    }

    void OnMouseDrag()
    {
        Vector3 nuevaPosicion = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)) + offset;
        rb.MovePosition(new Vector2(nuevaPosicion.x, nuevaPosicion.y));
    }
}