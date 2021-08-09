using UnityEngine;

public class GroundControl : MonoBehaviour
{
    private float _width;
    
    void Start()
    {
        _width = GetComponent<SpriteRenderer>().size.x;
    }
    
    void Update()
    {
        if (transform.position.x < -_width)
        {
            Move();
        }
    }

    private void Move()
    {
        transform.Translate(_width * 2, 0, 0);
    }
}
