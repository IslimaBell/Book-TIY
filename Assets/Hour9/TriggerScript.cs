using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered CUBE");
    }

    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still one with CUBE");
    }

    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has forsaken the CUBE");
    }
}
