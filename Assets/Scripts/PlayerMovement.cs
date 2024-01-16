using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float turnSpeed;
    
    private float _speedZ;
    private float _rotationY;
    void Update()
    {
        _speedZ = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        _rotationY = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate( 0, 0, _speedZ);
        if (_speedZ > 0)
            transform.Rotate(Vector3.up * _rotationY);
        else
            transform.Rotate(Vector3.down * _rotationY);
    }
}
