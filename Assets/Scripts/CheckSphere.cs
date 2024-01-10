using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSphere : MonoBehaviour
{
    void Update()
    {
        if(Physics.CheckSphere(transform.position, 1f))
            print("Objects were collided.");
    }
}
