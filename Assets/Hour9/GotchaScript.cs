using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotchaScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered your mom");
    }

    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " gotcha gotcha");
    }

    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " didn't like the joke");
    }
}
