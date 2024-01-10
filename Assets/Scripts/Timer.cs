using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _timer;
    private float _fixedTimer;
    
    void Update()
    {
        // Time.deltaTime = 1/fps
        _timer += Time.deltaTime;
        if (_timer > 1.0f && _timer < 1.4f)
            print("Timer : " + _timer);
    }

    private void FixedUpdate()
    {
        _fixedTimer += Time.fixedDeltaTime;
        if (_fixedTimer > 1.0f && _fixedTimer < 1.4f)
            print("Fixed timer :" + _fixedTimer);
        
    }
}
