using UnityEngine;

[CreateAssetMenu(fileName = "Game Settings", menuName = "New Game Settings", order = 52)]
public class GameSettings : ScriptableObject
{
    public float fly_speed;
    public float flap_force;
}
