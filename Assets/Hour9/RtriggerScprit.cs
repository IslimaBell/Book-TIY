using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RtriggerScprit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered RTrigger");
    }

    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is with RTrigger");
    }

    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has broken up with RTrigger");
    }
}
