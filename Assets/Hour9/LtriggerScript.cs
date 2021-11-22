using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered LTrigger");
    }

    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still with LTrigger");
    }

    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left LTrigger");
    }
}
