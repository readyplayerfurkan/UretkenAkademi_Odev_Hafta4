using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject vehicle;
    private Vector3 _cameraOffset;

    private void Start()
    {
        _cameraOffset = new Vector3(0, 4, -6);
    }

    private void Update()
    {
        transform.position = vehicle.transform.position + _cameraOffset;
        //transform.rotation = vehicle.transform.rotation;
    }
}
