using System;
using UnityEngine;

public class payertrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print(message: "Collision");
    }

    private void OnTriggerEnter(Collider other)
    {
        print(message:"Trigger");  
    }
}
