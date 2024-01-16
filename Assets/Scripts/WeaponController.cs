using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private RaycastHit _hit;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out _hit, Mathf.Infinity))
            {
                if(_hit.collider.gameObject.CompareTag("Enemy"))
                    Destroy(_hit.collider.gameObject);
            }
        }
    }
}
