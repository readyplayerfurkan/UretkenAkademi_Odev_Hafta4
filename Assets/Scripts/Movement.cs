using UnityEngine;

public class Movement : MonoBehaviour
{
    private float movementSpeed = 5.0f;
    void Update()
    {
        Vector3 playerMovement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        
        transform.Translate(playerMovement * movementSpeed * Time.deltaTime);
    }
}
