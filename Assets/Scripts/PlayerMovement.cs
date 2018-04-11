﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = Input.mousePosition;
        temp.z = 10f;
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}
