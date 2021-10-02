using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController 
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    public Action TryToInteract = delegate { };


    public void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.E))
            TryToInteract?.Invoke();

        //Vector2 dir = new Vector2(horizontal, vertical);
        //dir = dir.normalized;
        //Vector3 velocity = dir * _movementSpeed;
    }
}
