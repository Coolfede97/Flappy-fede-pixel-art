﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadormalmov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        Debug.Log(Input.GetAxis("Vertical"));
        transform.Translate(0, Input.GetAxis("Vertical") * 0.3f, 0);

    }
}
