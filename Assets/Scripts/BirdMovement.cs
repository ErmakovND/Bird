using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public GameSettings settings;
   
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Flap();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    private void Flap()
    {
        _rb.velocity = Vector2.zero;
        _rb.AddForce(Vector2.up * settings.flap_force, ForceMode2D.Impulse);
    }
}
