using UnityEngine;

public class GetAxiss : MonoBehaviour
{
    private float _verticalInputValue;
    private float _horizontalInputValue;
    private byte _layerNumber;

    private void Update()
    {
        _horizontalInputValue = Input.GetAxis("Horizontal");
        _verticalInputValue = Input.GetAxis("Vertical");

        switch (_horizontalInputValue)
        {
            case > 0:
                Debug.Log("You are moving to the right.");
                break;
            case 0:
                Debug.Log("You are standing.");
                break;
            default:
                Debug.Log("You are moving to the left.");
                break;
        }
        
        switch (_verticalInputValue)
        {
            case > 0:
                Debug.Log("You are moving to the sky.");
                break;
            case 0:
                Debug.Log("You are standing.");
                break;
            default:
                Debug.Log("You are moving to the ground.");
                break;
        }
    }

    private void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        players[0].SetActive(false); 
    }
}
