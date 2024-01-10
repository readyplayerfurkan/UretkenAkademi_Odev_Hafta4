using System;
using UnityEngine;

public class Carpma : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
    }
}
