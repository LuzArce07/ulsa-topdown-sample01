﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    
    void Update()
    {
        //Se mueve a la derecha muy rapido
        transform.Translate(Vector2.right * 2f * Time.deltaTime);

    }



}
