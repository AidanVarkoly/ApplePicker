﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Kills the apples if they get to far on the screen
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);



            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

            // Call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();
        }
    }
}
