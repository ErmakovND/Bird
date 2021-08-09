using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -2)
        {
            Destroy(gameObject);
        }
    }
}
