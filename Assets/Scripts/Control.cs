using UnityEngine;

public class Control : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Light>().intensity = 10f;
        }
        else
        {
            GetComponent<Light>().intensity = 1f;
        }
    }
}
