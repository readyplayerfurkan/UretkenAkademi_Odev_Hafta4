using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _timer;
    
    void Update()
    {
        // Time.deltaTime = 1/fps
        _timer += Time.deltaTime;
        print(_timer);
    }
}
