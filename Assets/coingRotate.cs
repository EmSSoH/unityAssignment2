﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coingRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 3, 0);
    }
}
