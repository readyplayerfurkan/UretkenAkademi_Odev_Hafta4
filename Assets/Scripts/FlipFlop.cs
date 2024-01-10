using UnityEngine;

public class FlipFlop : MonoBehaviour
{
    private bool _isLightOpen;
    
    void Start()
    {
        _isLightOpen = true;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            GetComponent<Light>().enabled = false;
            _isLightOpen = false;
        }
        else
        {
            GetComponent<Light>().enabled = true;
            _isLightOpen = true;
        }
    }
}
