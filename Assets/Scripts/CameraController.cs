using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float _xRotation = 0.0f;
    public float mouseSensitivity = 100f;
    public GameObject player;
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;

        _xRotation += mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        player.transform.Rotate(Vector3.up * mouseX);
    }
}
