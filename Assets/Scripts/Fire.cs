using UnityEngine;

public class Fire : MonoBehaviour
{
    private RaycastHit _hit;
    
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out _hit, Mathf.Infinity))
            print(_hit.collider.gameObject);
    }
}
