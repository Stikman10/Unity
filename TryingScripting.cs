using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryingScripting : MonoBehaviour
{
    void Update ()
    {
        if (Inputa.KeyDown(KeyCode.E))
        {
            GetComponent<Renderer>().material.color = color.orange;
        }
        if (Input.KeyDown(KeyCode.G))
        { GetComponent<Render>().material.color = color.black;
        }
        if (Input.KeyDown(KeyCode.B))
        {
            GetComponent<Render>().material.color = Color.magenta;

        }
    
