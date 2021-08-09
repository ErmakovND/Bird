using UnityEngine;

public class PipeControl : MonoBehaviour
{
    public GameObject pipe;
    
    private float _spawnTime = 1.2f;
    private float _timer;
    
    private System.Random _rand = new System.Random();
    
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _spawnTime)
        {
            var r = new Random();
            CreatePipe((float)_rand.NextDouble() - 0.5f);
            _timer = 0;
        }

    }

    private void CreatePipe(float y)
    {
        Instantiate(pipe, new Vector3(2, y, 0), Quaternion.identity);
    }
}
