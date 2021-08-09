using UnityEngine;

public class ScrollMovement : MonoBehaviour
{
    public GameSettings settings;

    void Update()
    {
        transform.Translate(settings.fly_speed * Time.deltaTime * Vector2.left);
    }
}
