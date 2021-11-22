﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigibody = GetComponent<Rigidbody>();
        rigibody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
