﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private Vector3 delta;
    // Start is called before the first frame update
    void Start()
    {
        delta = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + delta;
    }
}
