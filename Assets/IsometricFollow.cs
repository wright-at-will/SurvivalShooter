﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricFollow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + Vector3.back * 10 + Vector3.up*5;
    }
}
